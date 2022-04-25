using System;
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
            lbxColor.DisplayMember = dtColors.colorColumn.ColumnName;
            lbxColor.SelectedItem = null;

            AnimalMedical.sexDataTable dtSex = Utility.GetSexID();
            cmbSex.DataSource = dtSex;
            cmbSex.ValueMember = dtSex.sex_idColumn.ColumnName;
            cmbSex.DisplayMember = dtSex.sex_nameColumn.ColumnName;
            cmbSex.SelectedItem = null;
            #endregion

            #region Events
            cmbSpecies.SelectionChangeCommitted += CmbSpecies_SelectionChangeCommitted;
            cmbSex.SelectionChangeCommitted += CmbSex_SelectionChangeCommitted;
            dgAnimalTable.RowStateChanged += DgAnimalTable_RowStateChanged;
            #endregion

            DatabaseTableFormatting();
        }

        private void DgAnimalTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            System.Diagnostics.Debug.WriteLine(dg.SelectedRows.Count);
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
            dgAnimalTable.Columns["name"].HeaderText = "Name";
            dgAnimalTable.Columns["sex"].HeaderText = "Sex";
            dgAnimalTable.Columns["birthdate"].HeaderText = "Birth Date";
            dgAnimalTable.Columns["microchip_id"].HeaderText = "Microchip ID"; 
            dgAnimalTable.Columns["due_out_date"].HeaderText = "Due Out";
            dgAnimalTable.Columns["intake_date"].HeaderText = "Intake";
            //dgAnimalTable.Columns["notes"].HeaderText = "Notes";
            dgAnimalTable.Columns["weight"].HeaderText = "Weight";
            dgAnimalTable.Columns["kennel"].HeaderText = "Kennal";
            //dgAnimalTable.Columns["species_id"].HeaderText = "Species ID";
            dgAnimalTable.Columns["altered"].HeaderText = "Altered";
            dgAnimalTable.Columns["animal_id"].Visible = false;

            //TODO: make sure the sex column says male/female/unknown instaed of the sex_id

            //Add Treatment Button
            DataGridViewButtonColumn treatmentColumn = new DataGridViewButtonColumn();
            treatmentColumn.HeaderText = "Treatment";
            treatmentColumn.Text = "Treatment";
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
        private void CmbSex_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AnimalMedical.breedDataTable dtBreed = Utility.GetBreed();
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
            AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();
            List<AnimalMedical.animalRow> selectedAnimals = dtAnimalTable.ToList();
            
            //Animal ID LINQ
            if (txtAnimlId.TextLength>0)
                selectedAnimals = selectedAnimals.Where(x => x.db_bridge_id.Equals(txtAnimlId.Text)).ToList();
            ////TODO: Species LINQ
            //if (cmbSpecies.SelectedItem != null) 
            //    selectedAnimals = selectedAnimals.Where(x => x.species_id.Equals(cmbSpecies.SelectedValue)).ToList();

            //TODO: Sex/Breed/Color searches

            //Microchip LINQ
            if (txtMicrochipId.TextLength > 0)
                selectedAnimals = selectedAnimals.Where(x => x.microchip_id.Equals(txtMicrochipId.Text)).ToList();
            
            //Weight LINQ
            if (txtWeight.TextLength >0)
            {
                if (cmbWeight.Text.Equals(">"))
                    selectedAnimals = selectedAnimals.Where(x => x.weight > decimal.Parse(txtWeight.Text)).ToList();
                else if (cmbWeight.Text.Equals("<"))
                    selectedAnimals = selectedAnimals.Where(x => x.weight < decimal.Parse(txtWeight.Text)).ToList();
                else if (cmbWeight.Text.Equals("="))
                    selectedAnimals = selectedAnimals.Where(x => x.weight == decimal.Parse(txtWeight.Text)).ToList();
            }
            //Kennel LINQ
            if (txtKennel.TextLength > 0)
                selectedAnimals = selectedAnimals.Where(x => x.kennel.Equals(txtKennel.Text)).ToList();
            
            //BirthdateLINQ
            if (cmbBirthdate.Text.Equals(">"))
                selectedAnimals = selectedAnimals.Where(x => x.birthdate.Ticks > dtpBirthdate.Value.Ticks).ToList();
            else if (cmbBirthdate.Text.Equals("<"))
                selectedAnimals = selectedAnimals.Where(x => x.birthdate.Ticks < dtpBirthdate.Value.Ticks).ToList();
            else if (cmbBirthdate.Text.Equals("="))
                selectedAnimals = selectedAnimals.Where(x => x.birthdate.Ticks == dtpBirthdate.Value.Ticks).ToList();

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
            dgAnimalTable.Columns["sexRow"].Visible = false;
            dgAnimalTable.Columns["RowError"].Visible = false;
            dgAnimalTable.Columns["RowState"].Visible = false;
            dgAnimalTable.Columns["Table"].Visible = false;
            dgAnimalTable.Columns["HasErrors"].Visible = false;
        }

        private void dgAnimalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int  animalId= -1;
            DataGridView dg = (DataGridView)sender;

            //DataGridViewRow rowToBeOperatedUpon = dg.Rows[e.RowIndex];
            //currentDeptID = int.Parse(rowToBeOperatedUpon.Cells["DeptID"].Value.ToString());

            ////********************* Display Department Information in the data entry area *************************
            //if (e.ColumnIndex == -1)  //-1 index is the dummy row that selects the entire row
            //{
            //    DisplayAndEditDeptInfoDataEntry(rowToBeOperatedUpon);
            //    return;
            //}
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
                            //Utility.DeleteDepartment(selectedCell.RowIndex);
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
    }
}
