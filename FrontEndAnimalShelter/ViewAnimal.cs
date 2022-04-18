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
            FormatTable();  //formats headers and binds list/combo boxes to tables
            #endregion

            #region Events
            #endregion
        }

        /// <summary>
        /// Formatting the column headers and filling the list and combo boxes with data from the grid
        /// </summary>
        public void FormatTable()
        {
            //Formating headers
            dgAnimalTable.Columns["animal_id"].HeaderText = "ID";
            dgAnimalTable.Columns["name"].HeaderText = "Name";
            dgAnimalTable.Columns["sex"].HeaderText = "Sex";
            dgAnimalTable.Columns["birthdate"].HeaderText = "Birth Date";
            dgAnimalTable.Columns["microchip_id"].HeaderText = "Microchip ID"; //TODO this coloumn says "microship_id", needs to be changed in database
            dgAnimalTable.Columns["due_out_date"].HeaderText = "Due Out";
            dgAnimalTable.Columns["intake_date"].HeaderText = "Intake";
            dgAnimalTable.Columns["notes"].HeaderText = "Notes";
            dgAnimalTable.Columns["weight"].HeaderText = "Weight";
            dgAnimalTable.Columns["kennel"].HeaderText = "Kennal";
            dgAnimalTable.Columns["species_id"].HeaderText = "Species ID";

            //Populate combo and list boxes from the database
            AnimalMedical.speciesDataTable dtSpecies = Utility.GetSpecies();
            cmbSpecies.DataSource = dtSpecies;
            cmbSpecies.ValueMember = dtSpecies.species_idColumn.ColumnName;  //value is the species ID code
            cmbSpecies.DisplayMember = dtSpecies.species_typeColumn.ColumnName;  //value displayed is the species name
            cmbSpecies.SelectedItem = null;

            AnimalMedical.breedDataTable dtBreed = Utility.GetBreed();
            lbxBreed.DataSource = dtBreed;
            lbxBreed.ValueMember = dtBreed.breed_idColumn.ColumnName;  //value is the species ID code
            //TODO: ask if database can put in another column to identify the species of the breed --then we can try to limit the breed choices to the species
            lbxBreed.DisplayMember = dtBreed.breed_nameColumn.ColumnName;  //value displayed is the species name
            lbxBreed.SelectedItem = null;

            AnimalMedical.colorDataTable dtColors = Utility.GetColors();
            lbxColor.DataSource = dtColors;
            lbxColor.ValueMember = dtColors.color_idColumn.ColumnName;
            lbxColor.DisplayMember = dtColors.color_nameColumn.ColumnName;
            lbxColor.SelectedItem = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();
            List<AnimalMedical.animalRow> selectedAnimals = dtAnimalTable.ToList();

            //Species LINQ
            if (cmbSpecies.SelectedItem != null) 
                selectedAnimals = selectedAnimals.Where(x => x.species_id1.Equals(cmbSpecies.SelectedValue)).ToList();

            //TODO: Sex/Breed/Color searches

            //Microchip ID TODO: Microchip info needs to be fixed in the database (spelling error??)
            //if (txtMicrochipId.TextLength > 0)
            //    selectedAnimals = selectedAnimals.Where(x => x.microship_id == txtMicrochipId.Text).ToList();

            //Weight LINQ
            if(txtWeight.TextLength >0)
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
