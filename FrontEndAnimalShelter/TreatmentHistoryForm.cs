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
    public partial class TreatmentHistoryForm : Form
    {
        public TreatmentHistoryForm()
        {
            InitializeComponent();
        }
        public TreatmentHistoryForm(DataGridViewRow selectedAnimal)
        {
            InitializeComponent();
            AnimalMedical.medication_administration_logDataTable dtAministeredMeds = Utility.GetMedicationAdministrationLog();
            var selectedAnimalAdminMeds = dtAministeredMeds.Where(x => x.animal_id == (int)selectedAnimal.Cells["animal_id"].Value).ToList();
            dgMedications.DataSource = selectedAnimalAdminMeds;

            AnimalMedical.vaccine_administration_logDataTable dtAdministeredVaccineTable = Utility.GetVaccineAdministration();
            var selectedAnimalVaccines = dtAdministeredVaccineTable.Where(x => x.animal_id == (int)selectedAnimal.Cells["animal_id"].Value).ToList();
            dgVaccines.DataSource = selectedAnimalVaccines;

            lblAnimalInfo.Text = $"Animal ID: {selectedAnimal.Cells["db_bridge_id"].Value.ToString()}\n" +
                $"Name: {selectedAnimal.Cells["animal_name"].Value.ToString()}";

            //Medication table formatting
            dgMedications.Columns["animal_id"].HeaderText = "Animal ID";
            dgMedications.Columns["medication_id"].HeaderText = "Medication";
            dgMedications.Columns["employee_id"].HeaderText = "Admin Employee";
            dgMedications.Columns["datetime_given"].HeaderText = "Date Given";
            dgMedications.Columns["med_log_id"].Visible = false;
            dgMedications.Columns["animalRow"].Visible = false;
            dgMedications.Columns["medicationRow"].Visible = false;
            dgMedications.Columns["employeeRow"].Visible = false;
            dgMedications.Columns["RowError"].Visible = false;
            dgMedications.Columns["RowState"].Visible = false;
            dgMedications.Columns["Table"].Visible = false;
            dgMedications.Columns["HasErrors"].Visible = false;
            dgMedications.RowHeadersVisible = false;
            //Vaccine table formatting
            dgVaccines.Columns["animal_id"].HeaderText = "Animal ID";
            dgVaccines.Columns["vaccine_id"].HeaderText = "Vaccine";
            dgVaccines.Columns["employee_id"].HeaderText = "Admin Employee";
            dgVaccines.Columns["date_given"].HeaderText = "Date Given";
            dgVaccines.Columns["next_date_due"].HeaderText = "Next Date Due";
            dgVaccines.Columns["vaccine_log_id"].Visible = false;
            dgVaccines.Columns["animalRow"].Visible = false;
            dgVaccines.Columns["vaccineRow"].Visible = false;
            dgVaccines.Columns["employeeRow"].Visible = false;
            dgVaccines.Columns["RowError"].Visible = false;
            dgVaccines.Columns["RowState"].Visible = false;
            dgVaccines.Columns["Table"].Visible = false;
            dgVaccines.Columns["HasErrors"].Visible = false;
            dgVaccines.RowHeadersVisible = false;

            dgVaccines.DataBindingComplete += DgVaccines_DataBindingComplete;
            dgMedications.DataBindingComplete += DgMedications_DataBindingComplete;
        }

        private void DgMedications_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgMedications.ClearSelection();
        }

        private void DgVaccines_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgVaccines.ClearSelection();
        }
    }
}
