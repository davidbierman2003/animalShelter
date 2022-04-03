using DataAccessLayer;
using System;
using System.Windows.Forms;
using System.Linq;

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
           
            Decimal weight = string.IsNullOrEmpty(txtBxWeight.Text) ? 0 : decimal.Parse(txtBxWeight.Text);
            int animalId = string.IsNullOrEmpty(txtBxAnimalID.Text) ? 0 : int.Parse(txtBxAnimalID.Text);

            


           //the animalId must be unique.
           AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();

           var findAnimalId = dtAnimalTable.Where(x => x.animal_id == animalId).ToList();
            //if the user selects an animal id that has already been taken the program will end. 
            if(findAnimalId.Count > 0)
            {
                MessageBox.Show("The anamial id " + animalId + " has already been taken.\nChoose a different animal id!");
                return;
            }


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
