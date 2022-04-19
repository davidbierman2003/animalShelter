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
    public partial class ViewAnimal : Form
    {
        public ViewAnimal()
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

            AnimalMedical.sexDataTable dtSex = Utility.GetSexID();
            cmbSex.DataSource = dtSex;
            cmbSex.ValueMember = dtSex.sex_idColumn.ColumnName;
            cmbSex.DisplayMember = dtSex.sex_nameColumn.ColumnName;
            cmbSex.SelectedItem = null;
            #endregion

            #region Events
            cmbSpecies.SelectionChangeCommitted += CmbSpecies_SelectionChangeCommitted;
            #endregion
            DatabaseTableFormatting();
        }

        private void DatabaseTableFormatting()
        {
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
            dgAnimalTable.Columns["species_id"].HeaderText = "Species ID";

            dgAnimalTable.Columns["animal_id"].Visible = false;
            dgAnimalTable.Columns["altered"].Visible = false;

            //TODO: make sure the sex column says male/female/unknown instaed of the sex_id
        }

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

        /// <summary>
        /// Formatting the column headers and filling the list and combo boxes with data from the grid
        /// </summary>
        public void FormatTable()
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();
            List<AnimalMedical.animalRow> selectedAnimals = dtAnimalTable.ToList();

            //Species LINQ
            if (cmbSpecies.SelectedItem != null) 
                selectedAnimals = selectedAnimals.Where(x => x.species_id.Equals(cmbSpecies.SelectedValue)).ToList();

            //TODO: Sex/Breed/Color searches
            //if (cmbSex.SelectedItem != null)
            //    selectedAnimals = selectedAnimals.Where(x => x.sex.Equals(cmbSex.SelectedValue)).ToList();

            //if (lbxBreed.SelectedItem != null)
            //{

            //    selectedAnimals = selectedAnimals.Where(x => x.sex.Equals(cmbSex.SelectedValue)).ToList();
            //}


            //Microchip ID TODO: Microchip info needs to be fixed in the database (spelling error??)
            if (txtMicrochipId.TextLength > 0)
                selectedAnimals = selectedAnimals.Where(x => x.microchip_id == txtMicrochipId.Text).ToList();

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



            //dgAnimalTable.DataSource = selectedAnimals;  TODO: this needs to be tested once microship_id is removed from database
        }
    }
}
