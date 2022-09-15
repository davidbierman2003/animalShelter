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
        DataGridViewSelectedRowCollection selectedRows;
        public ViewAnimalForm()
        {
            InitializeComponent();
            
            dtpBirthdate.MaxDate = DateTime.Today;
            dtpBirthdate.Value = DateTime.Today;  //setting default birthdate value to today
            dtpIntakeDate.MaxDate = DateTime.Today;
            dtpIntakeDate.Value = DateTime.Today; //setting default intake date to today

            //dgAnimalTable.AutoGenerateColumns = false;

            ComponentDataBind();

            DatabaseTableFormatting();

            #region Events
            cmbSpecies.SelectionChangeCommitted += CmbSpecies_SelectionChangeCommitted;
            dgAnimalTable.GotFocus += DgAnimalTable_GotFocus;
            dgAnimalTable.DataBindingComplete += DgAnimalTable_DataBindingComplete;
            #endregion
        }

        private void ComponentDataBind()
        {
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

            AnimalMedical.kennelDataTable dtKennel = Utility.GetKennel();
            cmbKennel.DataSource = dtKennel;
            cmbKennel.ValueMember = dtKennel.kennel_idColumn.ColumnName;
            cmbKennel.DisplayMember = dtKennel.kennel_descriptionColumn.ColumnName;
            cmbKennel.SelectedItem = null;
            //THIS TABLE IS NOT IN THIS DATABASE
            //AnimalMedical.sexDataTable dtSex = Utility.GetSexID();
            //cmbSex.DataSource = dtSex;
            //cmbSex.ValueMember = dtSex.sex_idColumn.ColumnName;
            //cmbSex.DisplayMember = dtSex.sex_nameColumn.ColumnName;
            //cmbSex.SelectedItem = null;

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
            dgAnimalTable.Columns["altered"].HeaderText = "Altered";
            dgAnimalTable.Columns["adopted"].HeaderText = "Adopted";
            dgAnimalTable.Columns["animal_id"].Visible = false;
            dgAnimalTable.Columns["kennel_id"].Visible=false;
            dgAnimalTable.Columns["species"].Visible=false;

            DataGridViewColumn kennelNameColumn = new DataGridViewColumn();
            kennelNameColumn.HeaderText = "Kennel";
            kennelNameColumn.Name = "kennel_name";
            kennelNameColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgAnimalTable.Columns.Add(kennelNameColumn);
            
            DataGridViewColumn speciesNameColumn = new DataGridViewColumn();
            speciesNameColumn.HeaderText = "Species";
            speciesNameColumn.Name = "species_name";
            speciesNameColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgAnimalTable.Columns.Add(speciesNameColumn);

            DataGridViewColumn breedNameColumn = new DataGridViewColumn();
            breedNameColumn.HeaderText = "Breed";
            breedNameColumn.Name = "breed_name";
            breedNameColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgAnimalTable.Columns.Add(breedNameColumn);

            //Add Treatment Button
            DataGridViewButtonColumn treatmentColumn = new DataGridViewButtonColumn();
            treatmentColumn.HeaderText = "View Treatments";
            treatmentColumn.Text = "Treatments";
            treatmentColumn.UseColumnTextForButtonValue = true;
            treatmentColumn.Name = "treatmentButton";
            dgAnimalTable.Columns.Add(treatmentColumn);



            ////Edit Button
            //DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            //editColumn.HeaderText = "Edit";
            //editColumn.Text = "Edit";
            //editColumn.UseColumnTextForButtonValue = true;
            //editColumn.Name = "editButton";
            //dgAnimalTable.Columns.Add(editColumn);

            ////Delete Button
            //DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            //deleteColumn.HeaderText = "Delete from DB";
            //deleteColumn.Text = "Delete";
            //deleteColumn.UseColumnTextForButtonValue = true;
            //deleteColumn.Name = "deleteButton";
            //dgAnimalTable.Columns.Add(deleteColumn);

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
        private void DgAnimalTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AnimalMedical.kennelDataTable dtKennel = Utility.GetKennel();
            int kennel_id = 0;
            string kennelName = string.Empty;
            foreach (DataGridViewRow row in dgAnimalTable.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["kennel_id"].Value.ToString()))
                {
                    kennel_id = (int)row.Cells["kennel_id"].Value;
                    kennelName = dtKennel.FindBykennel_id(kennel_id).kennel_description;
                }
                row.Cells["kennel_name"].Value = kennelName;
            }

            AnimalMedical.speciesDataTable dtSpeciesTable = Utility.GetSpecies();
            int species_id = 0;
            string speciesName = string.Empty;
            foreach (DataGridViewRow row in dgAnimalTable.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["species"].Value.ToString())){
                    species_id = (int)row.Cells["species"].Value;
                    speciesName = dtSpeciesTable.FindByspecies_id(species_id).species_name;
                }
                row.Cells["species_name"].Value = speciesName;
            }

            AnimalMedical.animal_breedDataTable dtAnimalBreedTable = Utility.GetAnimalBreed();
            AnimalMedical.breedDataTable dtBreedTable = Utility.GetBreed();
            int animal_id=0;
            string breedName = string.Empty;
            foreach (DataGridViewRow row in dgAnimalTable.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["animal_id"].Value.ToString()))
                {
                    animal_id = (int)row.Cells["animal_id"].Value;
                    var breedId = dtAnimalBreedTable.Where(x => x.animal_id == animal_id).Select(y => y.Breed_id).ToList();
                    if (breedId.Count > 0)
                        breedName = dtBreedTable.FindBybreed_id(breedId[0]).breed_name;
                }
                row.Cells["breed_name"].Value = breedName;
            }

            dgAnimalTable.Columns["db_bridge_id"].DisplayIndex = 0;
            dgAnimalTable.Columns["animal_name"].DisplayIndex = 1;
            dgAnimalTable.Columns["species_name"].DisplayIndex = 2;
            dgAnimalTable.Columns["breed_name"].DisplayIndex = 3;
            dgAnimalTable.Columns["birth_date"].DisplayIndex = 4;
            dgAnimalTable.Columns["sex"].DisplayIndex = 5;
            dgAnimalTable.Columns["altered"].DisplayIndex = 6;
            dgAnimalTable.Columns["micro_chip"].DisplayIndex = 7;
            dgAnimalTable.Columns["weight"].DisplayIndex = 8;
            dgAnimalTable.Columns["kennel_name"].DisplayIndex = 9;
            dgAnimalTable.Columns["intake_date"].DisplayIndex = 10;
            dgAnimalTable.Columns["due_out_date"].DisplayIndex = 11;
            dgAnimalTable.Columns["adopted"].DisplayIndex = 12;
            dgAnimalTable.Columns["active"].DisplayIndex = 13;
            dgAnimalTable.Columns["treatmentButton"].DisplayIndex = 14;
            //dgAnimalTable.Columns["editButton"].DisplayIndex = 15;
            //dgAnimalTable.Columns["deleteButton"].DisplayIndex = 16;
        }

        /// <summary>
        /// Generates the breeds in the combobox that are related to the selected species
        /// </summary>
        private void CmbSpecies_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AnimalMedical.breedDataTable dtBreed = Utility.GetBreed();
           //Display the breeds associated with the selected species
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
                selectedAnimals = selectedAnimals.Where(x => x.sex.ToString().Equals(cmbSex.SelectedItem.ToString())).ToList();


            //Microchip LINQ
            if (txtMicrochipId.TextLength > 0)
                selectedAnimals = selectedAnimals.Where(x => x.micro_chip == txtMicrochipId.Text).ToList();
            
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
            //Kennel LINQ
            if (cmbKennel.SelectedIndex > 0)
                selectedAnimals = selectedAnimals.Where(x => x.kennel_id.ToString() == cmbKennel.SelectedValue.ToString()).ToList();

            //BirthdateLINQ
            if (cmbBirthdate.Text.Equals(">"))
                selectedAnimals = selectedAnimals.Where(x =>DateTime.Parse(x.birth_date).Ticks > dtpBirthdate.Value.Ticks).ToList();
            else if (cmbBirthdate.Text.Equals("<"))
                selectedAnimals = selectedAnimals.Where(x => DateTime.Parse(x.birth_date).Ticks < dtpBirthdate.Value.Ticks).ToList();
            else if (cmbBirthdate.Text.Equals("="))
                selectedAnimals = selectedAnimals.Where(x => DateTime.Parse(x.birth_date).Ticks == dtpBirthdate.Value.Ticks).ToList();

            //Intake date LINQ
            if (cmbIntake.Text.Equals(">"))
                selectedAnimals = selectedAnimals.Where(x => DateTime.Parse(x.intake_date).Ticks > dtpIntakeDate.Value.Ticks).ToList();
            else if (cmbIntake.Text.Equals("<"))
                selectedAnimals = selectedAnimals.Where(x => DateTime.Parse(x.intake_date).Ticks < dtpIntakeDate.Value.Ticks).ToList();
            else if (cmbIntake.Text.Equals("="))
                selectedAnimals = selectedAnimals.Where(x => DateTime.Parse(x.intake_date).Ticks == dtpIntakeDate.Value.Ticks).ToList();

            //Due Out Date LINQ
            if (cmbDueOut.Text.Equals(">"))
                selectedAnimals = selectedAnimals.Where(x => DateTime.Parse(x.due_out_date).Ticks > dtpDueOutDate.Value.Ticks).ToList();
            else if (cmbDueOut.Text.Equals("<"))
                selectedAnimals = selectedAnimals.Where(x => DateTime.Parse(x.due_out_date).Ticks < dtpDueOutDate.Value.Ticks).ToList();
            else if (cmbDueOut.Text.Equals("="))
                selectedAnimals = selectedAnimals.Where(x => DateTime.Parse(x.due_out_date).Ticks == dtpDueOutDate.Value.Ticks).ToList();

            //TODO: Breed/Color searches
            
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

            //********************* Edit and Delete Buttons ********************************************************
            if (dg.SelectedCells.Count == 1)  
            {

                if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    int rowIndex = dg.SelectedCells[0].RowIndex;
                    animalId = (int)dg.Rows[rowIndex].Cells["animal_id"].Value;

                    if (selectedCell.Value.Equals("Treatments"))
                    {
                        Form viewTreatmentHistory = new TreatmentHistoryForm(dg.Rows[rowIndex]);
                        viewTreatmentHistory.Visible = true;
                    }
                    //else if (selectedCell.Value.Equals("Delete"))
                    //{
                        //DialogResult deleteCheck = MessageBox.Show($"You have selected to delete animal {dg.Rows[rowIndex].Cells["db_bridge_id"].Value.ToString()} {dg.Rows[rowIndex].Cells["animal_name"].Value.ToString()}. Countinue with delete?", "Delete Department", MessageBoxButtons.
                        //No);
                        //if (deleteCheck == DialogResult.Yes)
                        //{
                            //Utility.DeleteAnimal(rowIndex);
                            //RefreshGridData();
                        //}
                    //}
                    //else if (selectedCell.Value.Equals("Edit"))//(bool)dg.Rows[rowIndex].Cells["altered"].Value(bool)dg.Rows[rowIndex].Cells["adopted"].Value(bool)dg.Rows[rowIndex].Cells["active"].Value)
                    //{
                        //Utility.EditAnimal((int)dg.Rows[rowIndex].Cells["animal_id"].Value, "TestingEdit", "Male", "2000-1-1", "13246798", "2020-1-1", "2022-1-1", 8m, 128, 2);
                        //Utility.EditAnimal((int)dg.Rows[rowIndex].Cells["animal_id"].Value, dg.Rows[rowIndex].Cells["animal_name"].Value.ToString(), dg.Rows[rowIndex].Cells["sex"].Value.ToString(), dg.Rows[rowIndex].Cells["birth_date"].Value.ToString(), dg.Rows[rowIndex].Cells["micro_chip"].Value.ToString(),
                                //dg.Rows[rowIndex].Cells["due_out_date"].Value.ToString(), dg.Rows[rowIndex].Cells["intake_date"].Value.ToString(), (decimal)dg.Rows[rowIndex].Cells["weight"].Value, (int)dg.Rows[rowIndex].Cells["kennel_id"].Value, (int)dg.Rows[rowIndex].Cells["species"].Value);//, true,
                                //false,true) ;
                        //Utility.SaveBreed(dtAnimalTable.Last().animal_id, (int)cmbBreed.SelectedValue);
                        //Utility.SaveColor(dtAnimalTable.Last().animal_id, (int)cmbColor.SelectedValue);
                        //RefreshGridData();
                        //MessageBox.Show("Edits to animal " + animalID + " have been saved to the database");
                    //}
                }
            }
        }
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
                Form vaccineForm = new AddVaccineForm();  //user will input the animal ID
                vaccineForm.Visible = true;
            }
        }

        private void btnAdminMeds_Click(object sender, EventArgs e)
        {
            if (selectedRows != null)
            {
                Form adminMedsForm = new AdminMedicationForm(selectedRows);  //animal has been selected from the grid
                adminMedsForm.Visible = true;
            }
            else
            {
                Form adminMedsForm = new AdminMedicationForm();  //user will input the animal ID
                adminMedsForm.Visible = true;
            }
        }
        #endregion
    }
}
