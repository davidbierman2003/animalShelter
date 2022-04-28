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
    public partial class AdminMedicationForm : Form
    {
        List<int> animalIds = new List<int>();
        DataGridViewRow medicationRow;
        int employeeId = 0;
        public AdminMedicationForm()
        {
            InitializeComponent();
            MoreInitializing();
        }
        public AdminMedicationForm(DataGridViewSelectedRowCollection selectedAnimals)
        {
            InitializeComponent();
            MoreInitializing();
            foreach (DataGridViewRow animal in selectedAnimals)
            {
                txtAnimalId.Text += animal.Cells["db_bridge_id"].Value.ToString() + " ";
                animalIds.Add((int)animal.Cells["animal_id"].Value);
            }
        }
        public void MoreInitializing()
        {
            FormatTable();

            dgPerscriptions.DataBindingComplete += DgPerscriptions_DataBindingComplete;
        }
        public void FormatTable()
        {
            AnimalMedical.prescriptionDataTable dtPrescriptionTable = new AnimalMedical.prescriptionDataTable();
            dtPrescriptionTable = Utility.GetPrescriptions();

            DataGridViewColumn animalidColumn = new DataGridViewColumn();
            animalidColumn.HeaderText = "Animal ID";
            animalidColumn.Name = "shelter_AnimalId";
            animalidColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgPerscriptions.Columns.Add(animalidColumn);

            DataGridViewColumn medicationColumn = new DataGridViewColumn();
            medicationColumn.HeaderText = "Medication";
            medicationColumn.Name = "medication_name";
            medicationColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgPerscriptions.Columns.Add(medicationColumn);

            DataGridViewColumn frequencyColumn = new DataGridViewColumn();
            frequencyColumn.HeaderText = "Frequency";
            frequencyColumn.Name = "frequency";
            frequencyColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgPerscriptions.Columns.Add(frequencyColumn);

            DataGridViewColumn methodColumn = new DataGridViewColumn();
            methodColumn.HeaderText = "Method";
            methodColumn.Name = "method";
            methodColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgPerscriptions.Columns.Add(methodColumn);

            dgPerscriptions.DataSource = dtPrescriptionTable;

            dgPerscriptions.Columns["animal_specific_dose"].HeaderText = "Animal Dose";
            dgPerscriptions.Columns["assigned_staff"].HeaderText = "Assigned Staff";
            dgPerscriptions.Columns["start_date"].HeaderText = "Start Date";
            dgPerscriptions.Columns["end_date"].HeaderText = "End Date";
            dgPerscriptions.Columns["notes"].HeaderText = "Notes";

            dgPerscriptions.Columns["prescription_id"].Visible = false;
            dgPerscriptions.Columns["animal_id"].Visible = false;
            dgPerscriptions.Columns["medication_id"].Visible = false;
            dgPerscriptions.Columns["frequency_id"].Visible = false;
            dgPerscriptions.Columns["animal_specific_method_id"].Visible = false;

            dgPerscriptions.RowHeadersVisible = false;
            dgPerscriptions.ReadOnly = true;

        }
        private void DgPerscriptions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgPerscriptions.ClearSelection();

            //Fill animal ID colomn
            if (dgPerscriptions.Columns.Contains("shelter_animalId"))
            {
                AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();

                foreach (DataGridViewRow row in dgPerscriptions.Rows)
                {
                    if (row.Cells["animal_id"].Value != null)
                    {
                        var idResults = dtAnimalTable.Where(x => x.animal_id ==  (int)row.Cells["animal_id"].Value).Select(y => y.db_bridge_id).ToList();
                        if (idResults.Count > 0)
                            row.Cells["shelter_animalId"].Value = idResults.First();
                    }
                }
            }
            //Fill medication name colomn
            if (dgPerscriptions.Columns.Contains("medication_name"))
            {
                AnimalMedical.medicationDataTable medicationTable = Utility.GetMedication();

                foreach (DataGridViewRow row in dgPerscriptions.Rows)
                {
                    if (row.Cells["medication_id"].Value != null)
                    {
                        var medResults = medicationTable.Where(x => x.medication_id == (int)row.Cells["medication_id"].Value).Select(y => y.medication_name).ToList();
                        if (medResults.Count > 0)
                            row.Cells["medication_name"].Value = medResults.First();
                    }
                }
            }
            //Fill Frequency colomn
            if (dgPerscriptions.Columns.Contains("frequency"))
            {
                AnimalMedical.frequencyDataTable dgFrequencyTable = Utility.GetFrequency();

                foreach (DataGridViewRow row in dgPerscriptions.Rows)
                {
                    if (row.Cells["frequency_id"].Value != null)
                    {
                        var frequencyResults = dgFrequencyTable.Where(x => x.frequency_id == (int)row.Cells["frequency_id"].Value).Select(y => y.num_times).ToList();
                        if (frequencyResults.Count > 0)
                            row.Cells["frequency"].Value = frequencyResults.First();
                    }
                }
            }
            //Fill method colomn
            if (dgPerscriptions.Columns.Contains("method"))
            {
                AnimalMedical.admin_methodDataTable dgMethodTable = Utility.GetAdminMethod();

                foreach (DataGridViewRow row in dgPerscriptions.Rows)
                {
                    if (row.Cells["animal_specific_method_id"].Value != null)
                    {
                        var frequencyResults = dgMethodTable.Where(x => x.admin_method_id == (int)row.Cells["animal_specific_method_id"].Value).Select(y => y.admin_method_name).ToList();
                        if (frequencyResults.Count > 0)
                            row.Cells["method"].Value = frequencyResults.First();
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            AnimalMedical.animalDataTable aniamlDB = Utility.GetAnimals();
            string validIds = "";
            string invalidIds = "";
            if (animalIds.Count == 0)  //mutliple animals were not selected from the grid
            {
                var animalIdResults = aniamlDB.Where(x => x.db_bridge_id == txtAnimalId.Text).Select(y => y.animal_id).ToList();
                animalIds.Add(animalIdResults[0]); //collect the database animal id
            }

            foreach (int id in animalIds)
            {
                //Check if animal has been added to the database
                var validId = aniamlDB.Where(x => x.animal_id == id).ToList();  //does animal exist in database
                if (validId.Count > 0) //animal does exist in the database
                {
                    validIds += id + " ";
                    //Utility.SaveMedicationAdministration(id,medID,int.Parse(txtEmployeeId.Text), dateGiven.Value);
                }
                else  //animal id is not valid (not in database)
                {
                    invalidIds += id + " ";
                }
            }
            if (!string.IsNullOrEmpty(validIds))
            {
                MessageBox.Show($"Medication administration log for animals {validIds} have been saved.");
            }
            if (string.IsNullOrEmpty(invalidIds))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show($"An invalid animal ID has been entered. The animal needs to be added to the database or there was a typo: {invalidIds}");
                txtAnimalId.Text = invalidIds;
                txtAnimalId.Focus();
            }
        }
    }
}
