﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace FrontEndAnimalShelter
{
    public partial class ViewAnimalForm : Form
    {
        DataGridViewSelectedRowCollection selectedRows;
        public ViewAnimalForm()
        {
            InitializeComponent();

            dtpBirthdate.MaxDate = DateTime.Today;
            dtpBirthdate.Value = DateTime.Today;  //setting default birthdate value to today
            dtpIntakeDate.MaxDate = DateTime.Today;
            dtpIntakeDate.Value = DateTime.Today; //setting default intake date to today

            #region Data Binding
            AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();
            dgAnimalTable.DataSource = dtAnimalTable;

            //Populate combo and list boxes from the database
            AnimalMedical.speciesDataTable dtSpecies = Utility.GetSpecies();
            cmbSpecies.DataSource = dtSpecies;
            cmbSpecies.ValueMember = dtSpecies.species_idColumn.ColumnName;  //value is the species ID code
            cmbSpecies.DisplayMember = dtSpecies.species_nameColumn.ColumnName;  //value displayed is the species name
            cmbSpecies.SelectedItem = null;

            AnimalMedical.breedDataTable dtBreed = Utility.GetBreed();
            lbxBreed.DataSource = dtBreed;
            lbxBreed.ValueMember = dtBreed.breed_idColumn.ColumnName;  //value is the species ID code
            lbxBreed.DisplayMember = dtBreed.breed_nameColumn.ColumnName;
            lbxBreed.SelectedItem = null;

            AnimalMedical.colorDataTable dtColors = Utility.GetColors();
            lbxColor.DataSource = dtColors;
            lbxColor.ValueMember = dtColors.color_idColumn.ColumnName;
            lbxColor.DisplayMember = dtColors.color_nameColumn.ColumnName;
            lbxColor.SelectedItem = null;

            //THIS TABLE IS NOT IN THIS DATABASE
            //AnimalMedical.sexDataTable dtSex = Utility.GetSexID();
            //cmbSex.DataSource = dtSex;
            //cmbSex.ValueMember = dtSex.sex_idColumn.ColumnName;
            //cmbSex.DisplayMember = dtSex.sex_nameColumn.ColumnName;
            //cmbSex.SelectedItem = null;
            #endregion
            DatabaseTableFormatting();

            #region Events
            cmbSpecies.SelectionChangeCommitted += CmbSpecies_SelectionChangeCommitted;
            dgAnimalTable.GotFocus += DgAnimalTable_GotFocus;
            #endregion
        }




        /// <summary>
        /// Formatting the column headers and filling the list and combo boxes with data from the grid
        /// </summary>
        private void DatabaseTableFormatting()
        {
            dgAnimalTable.AllowUserToAddRows = false;
            dgAnimalTable.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            //Formating headers
            dgAnimalTable.Columns["db_bridge_id"].HeaderText = "ID";
            dgAnimalTable.Columns["animal_name"].HeaderText = "Name";
            dgAnimalTable.Columns["sex"].HeaderText = "Sex";
            dgAnimalTable.Columns["birth_date"].HeaderText = "Birth Date";
            dgAnimalTable.Columns["micro_chip"].HeaderText = "Microchip ID"; 
            dgAnimalTable.Columns["due_out_date"].HeaderText = "Due Out";
            dgAnimalTable.Columns["intake_date"].HeaderText = "Intake";
            dgAnimalTable.Columns["weight"].HeaderText = "Weight";
            dgAnimalTable.Columns["kennel_id"].HeaderText = "Kennal";
            dgAnimalTable.Columns["species"].HeaderText = "Species ID";
            dgAnimalTable.Columns["altered"].HeaderText = "Altered";
            dgAnimalTable.Columns["adopted"].HeaderText = "Adopted";
            dgAnimalTable.Columns["animal_id"].Visible = false;

            //Add Treatment Button
            DataGridViewButtonColumn treatmentColumn = new DataGridViewButtonColumn();
            treatmentColumn.HeaderText = "View Treatments";
            treatmentColumn.Text = "Treatments";
            treatmentColumn.UseColumnTextForButtonValue = true;
            treatmentColumn.Name = "treatmentButton";
            dgAnimalTable.Columns.Add(treatmentColumn);

            //Edit Button
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Edit";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            editColumn.Name = "editButton";
            dgAnimalTable.Columns.Add(editColumn);

            //Delete Button
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Delete from DB";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Name = "deleteButton";
            dgAnimalTable.Columns.Add(deleteColumn);

        }
        #region Events
        private void DgAnimalTable_GotFocus(object sender, EventArgs e)
        {
            dgAnimalTable.RowStateChanged += DgAnimalTable_RowStateChanged;
        }

        private void DgAnimalTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            selectedRows = dg.SelectedRows;  //collect the selected rows
        }

        /// <summary>
        /// Generates the breeds in the combobox that are related to the selected species
        /// </summary>
        private void CmbSpecies_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AnimalMedical.breedDataTable dtBreed = Utility.GetBreed();
           
            if (cmbSpecies.SelectedItem != null)
            {
                var breedList = dtBreed.Where(x => x.species_id.ToString().Equals(cmbSpecies.SelectedValue.ToString())).ToList();
                lbxBreed.DataSource = breedList;
                lbxBreed.DisplayMember = "breed_name";
                lbxBreed.SelectedValue = "breed_id";
            }
            else
                lbxBreed.DisplayMember = dtBreed.breed_nameColumn.ColumnName;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> animalIds = new List<string>();

            AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();
            List<AnimalMedical.animalRow> selectedAnimals= new List<AnimalMedical.animalRow>();

            AnimalMedical.breedDataTable dtBreedTable = Utility.GetBreed();
            List<AnimalMedical.breedRow> selectedBreeds = dtBreedTable.ToList();
            
            //Filtering out the animals we need based on animal ID
            if (txtAnimlId.TextLength > 0)
            {
                foreach (string word in txtAnimlId.Text.Split(' '))
                {
                    animalIds.Add(word);
                }
                foreach( string id in animalIds)
                {
                    var animal = dtAnimalTable.Where(x => x.db_bridge_id.Equals(id)).ToList();
                    if(animal.Count>0)
                        selectedAnimals.Add(animal[0]);
                }
            }
            else
            {
                selectedAnimals = dtAnimalTable.ToList();
            }

            //Species LINQ
            if (cmbSpecies.SelectedItem != null)
                selectedAnimals = selectedAnimals.Where(x => x.species.ToString().Equals(cmbSpecies.SelectedValue.ToString())).ToList();

            //Sex LINQ
            if (cmbSex.SelectedItem != null)
                selectedAnimals = selectedAnimals.Where(x => x.sex.ToString().Equals(cmbSex.SelectedValue.ToString())).ToList();

            //TODO: Breed/Color searches
           
            //Microchip LINQ
            if (txtMicrochipId.TextLength > 0)
                selectedAnimals = selectedAnimals.Where(x => x.micro_chip.Equals(txtMicrochipId.Text)).ToList();
            
            //Weight LINQ
            if (txtWeight.TextLength >0)
            {
                if (cmbWeight.Text.Equals(">"))
                    selectedAnimals = selectedAnimals.Where(x => x.weight > double.Parse(txtWeight.Text)).ToList();
                else if (cmbWeight.Text.Equals("<"))
                    selectedAnimals = selectedAnimals.Where(x => x.weight < double.Parse(txtWeight.Text)).ToList();
                else if (cmbWeight.Text.Equals("="))
                    selectedAnimals = selectedAnimals.Where(x => x.weight == double.Parse(txtWeight.Text)).ToList();
            }
            //TODO Kennel LINQ
            //if (txtKennel.TextLength > 0)
            //    selectedAnimals = selectedAnimals.Where(x => x.kennel_id .Equals(txtKennel.Text)).ToList();  //TODO: this needs to be rewritten to use the kennel id instead of the name
            
            //BirthdateLINQ
            if (cmbBirthdate.Text.Equals(">"))
                selectedAnimals = selectedAnimals.Where(x => x.birth_date.Ticks > dtpBirthdate.Value.Ticks).ToList();
            else if (cmbBirthdate.Text.Equals("<"))
                selectedAnimals = selectedAnimals.Where(x => x.birth_date.Ticks < dtpBirthdate.Value.Ticks).ToList();
            else if (cmbBirthdate.Text.Equals("="))
                selectedAnimals = selectedAnimals.Where(x => x.birth_date.Ticks == dtpBirthdate.Value.Ticks).ToList();

            //Intake date LINQ
            if (cmbIntake.Text.Equals(">"))
                selectedAnimals = selectedAnimals.Where(x => x.intake_date.Ticks > dtpIntakeDate.Value.Ticks).ToList();
            else if (cmbIntake.Text.Equals("<"))
                selectedAnimals = selectedAnimals.Where(x => x.intake_date.Ticks < dtpIntakeDate.Value.Ticks).ToList();
            else if (cmbIntake.Text.Equals("="))
                selectedAnimals = selectedAnimals.Where(x => x.intake_date.Ticks == dtpIntakeDate.Value.Ticks).ToList();

            //Due Out Date LINQ
            if (cmbDueOut.Text.Equals(">"))
                selectedAnimals = selectedAnimals.Where(x => x.due_out_date.Ticks > dtpDueOutDate.Value.Ticks).ToList();
            else if (cmbDueOut.Text.Equals("<"))
                selectedAnimals = selectedAnimals.Where(x => x.due_out_date.Ticks < dtpDueOutDate.Value.Ticks).ToList();
            else if (cmbDueOut.Text.Equals("="))
                selectedAnimals = selectedAnimals.Where(x => x.due_out_date.Ticks == dtpDueOutDate.Value.Ticks).ToList();


            dgAnimalTable.DataSource = selectedAnimals;  //TODO: this needs to be tested once microship_id is removed from database

            //Format and add the buttons
            dgAnimalTable.Columns["kennelRow"].Visible = false;
            dgAnimalTable.Columns["speciesRow"].Visible = false;
            dgAnimalTable.Columns["RowError"].Visible = false;
            dgAnimalTable.Columns["RowState"].Visible = false;
            dgAnimalTable.Columns["Table"].Visible = false;
            dgAnimalTable.Columns["HasErrors"].Visible = false;
        }

        private void dgAnimalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int  animalId= -1;
            DataGridView dg = (DataGridView)sender;
            DataGridViewSelectedRowCollection selectedrows = dg.SelectedRows;

            //********************* Edit and Delete Buttons ********************************************************
            if (dg.SelectedCells.Count == 1)  //only one cell has been selected (do not want to edit/delete mutliple rows at same time)
            {

                if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    if (selectedCell.Value.Equals("Delete"))
                    {
                        DialogResult deleteCheck = MessageBox.Show("You have selected to delete department " + animalId + ". Countinue with delete?", "Delete Department", MessageBoxButtons.YesNo);
                        if (deleteCheck == DialogResult.Yes)
                        {
                            Utility.DeleteAnimal(selectedCell.RowIndex);
                            //RefreshGridData();
                        }
                    }
                    else if (selectedCell.Value.Equals("Save Edit"))
                    {
                        //Utility.EditDepartment(currentDeptID, rowToBeOperatedUpon.Cells["DeptName"].Value.ToString(), rowToBeOperatedUpon.Cells["Location"].Value.ToString(),
                            //rowToBeOperatedUpon.Cells["Address"].Value.ToString(), rowToBeOperatedUpon.Cells["ContactPersonName"].Value.ToString(), rowToBeOperatedUpon.Cells["ContactPersonPhoneNumber"].Value.ToString());

                        //RefreshGridData();
                        //MessageBox.Show("Edits to deparment " + currentDeptID + " have been saved to the database");
                    }
                }
            }
        }
        #endregion
        /// <summary>
        /// Allows user to assign a perscription to an animal and add it to the database
        /// </summary>
        private void btnPerscription_Click(object sender, EventArgs e)
        {
            if (selectedRows != null)
            {
                Form perscriptionForm = new AddPerscriptionForm(selectedRows);  //animal has been selected from the grid
                perscriptionForm.Visible = true;
            }
            else
            {
                Form perscriptionForm = new AddPerscriptionForm();  //user will input the animal ID
                perscriptionForm.Visible = true;
            }
        }

        private void btnVaccine_Click(object sender, EventArgs e)
        {
            if (selectedRows != null)
            {
                Form vaccineForm = new AddVaccineForm(selectedRows);  //animal has been selected from the grid
                vaccineForm.Visible = true;
            }
            else
            {
                Form perscriptionForm = new AddVaccineForm();  //user will input the animal ID
                perscriptionForm.Visible = true;
            }
        }

        private void btnAdminMeds_Click(object sender, EventArgs e)
        {
            if (selectedRows != null)
            {
                //Form vaccineForm = new AdminMedicationForm(selectedRows);  //animal has been selected from the grid
                //vaccineForm.Visible = true;
            }
            else
            {
                Form perscriptionForm = new AdminMedicationForm();  //user will input the animal ID
                perscriptionForm.Visible = true;
            }
        }
    }
}
