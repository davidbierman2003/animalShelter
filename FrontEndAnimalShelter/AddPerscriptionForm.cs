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
    public partial class AddPerscriptionForm : Form
    {
        List<int> animaIds = new List<int>();
        DataGridViewRow medicationRow;
        public AddPerscriptionForm()
        {
            InitializeComponent();
            MoreInitializing();
        }
        public AddPerscriptionForm(DataGridViewSelectedRowCollection selectedAnimals)
        {
            InitializeComponent();
            MoreInitializing();
            foreach (DataGridViewRow animal in selectedAnimals)
            {
                txtAnimalid.Text += animal.Cells["db_bridge_id"].Value.ToString() + " ";
                animaIds.Add((int)animal.Cells["animail_id"].Value);
            }
        }
        private void FormatTable()
        {
            AnimalMedical.unitDataTable dtUnitTable = Utility.GetUnit();
            SharedTables.Medication medication = new SharedTables.Medication();
           dgMedicationTable= medication.FormatMedicationTable(dgMedicationTable);

            dgMedicationTable.Columns["dose"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;

            //remove the first column with no information in it.
            dgMedicationTable.RowHeadersVisible = false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            AnimalMedical.animalDataTable aniamlDB = Utility.GetAnimals();

            string validIds = "";
            string invalidIds = "";
            if (animaIds.Count == 0)  //mutliple animals were not selected from the grid
            {
                var animalIdResults = aniamlDB.Where(x => x.db_bridge_id == txtAnimalid.Text).Select(y => y.animal_id).ToList();
                animaIds.Add(animalIdResults[0]); //collect the database animal id
            }
           
            int frequencyid = 0;
            AnimalMedical.frequencyDataTable dtFrequency = Utility.GetFrequency();
            var frequencyidResult = dtFrequency.Where(x => (x.num_days == (int)numDays.Value) && (x.num_days == (int)numTimesPerDay.Value) && (x.desc_value == txtFrequencyDesc.Text)).Select(y=> y.frequency_id).ToList();
            if(frequencyidResult.Count == 0)
            {
                Utility.SaveFrequency((int)numDays.Value, (int)numTimesPerDay.Value, txtFrequencyDesc.Text);
                dtFrequency = Utility.GetFrequency();
                AnimalMedical.frequencyRow lastrow = dtFrequency.Last();
                frequencyid = lastrow.frequency_id;
            }
            else
            {
                frequencyid = frequencyidResult.First();
            }

            foreach (int id in animaIds)
            {
                //Check if animal has been added to the database
                var validId = aniamlDB.Where(x => x.animal_id == id).ToList();  //does animal exist in database
                if (validId.Count > 0) //animal does exist in the database
                {
                    validIds += id + " ";
                    Utility.SavePrescription(validId[0].animal_id , int.Parse(medicationRow.Cells["medication_id"].Value.ToString()), txtDose.Text, (int)cmbAdminMethod.SelectedValue, dateStart.Value, dateEnd.Value, txtStaff.Text, frequencyid, txtNotes.Text);
                }
                else  //animal id is not valid (not in database)
                {
                    invalidIds += id + " ";
                }
            }
            if (!string.IsNullOrEmpty(validIds))
            {
                MessageBox.Show($"Prescriptions for animals {validIds} have been saved.");
            }
            if (string.IsNullOrEmpty(invalidIds))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show($"An invalid animal ID has been entered. The animal needs to be added to the database or there was a typo: {invalidIds}");
                txtAnimalid.Text = invalidIds;
                txtAnimalid.Focus();
            }
        }

        private void MoreInitializing()
        {
            AnimalMedical.medicationDataTable dtMedicationTable = Utility.GetMedication();
            dgMedicationTable.DataSource = dtMedicationTable;
            FormatTable();

            #region Data Binding
            AnimalMedical.admin_methodDataTable dtAdminMethod = Utility.GetAdminMethod();
            
            cmbAdminMethod.DataSource = dtAdminMethod;
            cmbAdminMethod.ValueMember = dtAdminMethod.admin_method_idColumn.ColumnName;  //value is the species ID code
            cmbAdminMethod.DisplayMember = dtAdminMethod.admin_method_nameColumn.ColumnName;  //value displayed is the species name
            cmbAdminMethod.SelectedItem = null;
            #endregion

            dgMedicationTable.CellClick += DgMedicationTable_CellClick;
            dgMedicationTable.DataBindingComplete += DgMedicationTable_DataBindingComplete;
        }
             
        private void DgMedicationTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgMedicationTable.ClearSelection();  //clears any initial row selection that was not performed by user

            SharedTables.Medication medication = new SharedTables.Medication();
            dgMedicationTable = medication.GetUnitName(dgMedicationTable);
        }
        /// <summary>
        ///When user clicks on grid cell the entire row is selected. We collect that row information here 
        /// </summary>
        private void DgMedicationTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cell click selects the entire row
            DataGridView dg = (DataGridView)sender;
            medicationRow = dg.SelectedRows[0];  //only one row can be selected
        }
    }
}
