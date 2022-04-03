using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace FrontEndAnimalShelter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();
            AnimalTable.DataSource = dtAnimalTable;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           

            DateTime test = new DateTime(2022, 10, 07);
            Decimal weight = string.IsNullOrEmpty(txtBxWeight.Text) ? 0 : decimal.Parse(txtBxWeight.Text);
            int animalId = string.IsNullOrEmpty(txtBxAnimalID.Text) ? 0 : int.Parse(txtBxAnimalID.Text);
            int gender = cmbBoxGender.SelectedIndex;
            int speciesID = string.IsNullOrEmpty(txtBxSpeciesID.Text) ? 0 : int.Parse(txtBxSpeciesID.Text);

            Utility.SaveAnimal(animalId,txtBxName.Text, gender, dateTimePickerDateOfBirth.Value, txtBxMicrochipID.Text,
                 dateTimePickerDueOutDate.Value, dateTimePickerIntakeDate.Value, txtBxNotes.Text, weight,txtBxKennel.Text, speciesID);


            RefreshGridData();


        }

        private void RefreshGridData() 
        {
            // get the current data from the database
            // and assign it to the grid
            AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();
            AnimalTable.DataSource = dtAnimalTable;


        }

        
    }
}
