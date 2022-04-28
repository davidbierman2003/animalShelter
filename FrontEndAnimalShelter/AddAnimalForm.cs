using DataAccessLayer;
using System;
using System.Windows.Forms;
using System.Linq;

namespace FrontEndAnimalShelter
{
    public partial class AddAnimalForm : Form
    {
        public AddAnimalForm()
        {
            InitializeComponent();
            AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();

            #region data bind region
            
            AnimalMedical.speciesDataTable dtSpecies = Utility.GetSpecies();
            cmbBoxSpecies.DataSource = dtSpecies;
            cmbBoxSpecies.ValueMember = dtSpecies.species_idColumn.ColumnName;
            cmbBoxSpecies.DisplayMember = dtSpecies.species_nameColumn.ColumnName;
            // Display member
            // value member
            // cmbBoxSpecies.DataSource


            #endregion
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            Decimal weight = string.IsNullOrEmpty(txtBxWeight.Text) ? 0 : decimal.Parse(txtBxWeight.Text);
            //string animalId = string.IsNullOrEmpty(txtBxAnimalID.Text) ? 0 : txtBxAnimalID.Text;//int.Parse(txtBxAnimalID.Text);

            


           //the animalId must be unique.
           AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();

           var findAnimalId = dtAnimalTable.Where(x => x.db_bridge_id == txtBxAnimalID.Text).ToList();
            //if the user selects an animal id that has already been taken the program will end. 
            if(findAnimalId.Count > 0)
            {
                MessageBox.Show("The anamial id " + txtBxAnimalID.Text + " has already been taken.\nChoose a different animal id!");
                return;
            }


            int gender = cmbBoxGender.SelectedIndex;  //TODO: this is a string in this database, 
            int speciesID = int.Parse(cmbBoxSpecies.SelectedValue.ToString());

            int kennelid = 0;
            AnimalMedical.kennelDataTable kennelTable = Utility.GetKennel();
            var findKennelName = kennelTable.Where(x => x.kennel_description == txtBxKennel.Text).Select(y => y.kennel_id).ToList();
            if (findKennelName.Count > 0) {kennelid = findKennelName.First(); }
            
            Utility.SaveAnimal(txtBxAnimalID.Text,txtBxName.Text, gender.ToString(), dateTimePickerDateOfBirth.Value, txtBxMicrochipID.Text,
                 dateTimePickerDueOutDate.Value, dateTimePickerIntakeDate.Value, txtBxNotes.Text, weight,kennelid, speciesID,ckbAltered.Checked);

            MessageBox.Show($"Animial {txtBxAnimalID.Text} has been saved.");

            Reset();
        }
        private void Reset()
        {
            txtBxAnimalID.Text = "";
            txtBxKennel.Text = "";
            txtBxMicrochipID.Text = "";
            txtBxName.Text = "";
            txtBxNotes.Text = "";
            txtBxWeight.Text = "";

            ckbAltered.Checked = false;

            dateTimePickerDateOfBirth.Value = DateTime.Today;
            dateTimePickerDueOutDate.Value = DateTime.Today;
            dateTimePickerIntakeDate.Value = DateTime.Today;

            cmbBoxGender.SelectedItem = default;
            cmbBoxSpecies.SelectedItem = default;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        
    }
}
