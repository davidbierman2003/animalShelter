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

            MedicationTableFormatting();
            VaccineTableFormatting();

            dgVaccines.DataBindingComplete += DgVaccines_DataBindingComplete;
            dgMedications.DataBindingComplete += DgMedications_DataBindingComplete;
        }

        private void DgMedications_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgMedications.ClearSelection();
            //display medication name instead of id in the grid
            AnimalMedical.medicationDataTable dtMedicationTable = Utility.GetMedication();
            int medication_id = 0;
            string medicationName = string.Empty;
            foreach (DataGridViewRow row in dgMedications.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["medication_id"].Value.ToString()))
                {
                    medication_id = (int)row.Cells["medication_id"].Value;
                    medicationName = dtMedicationTable.FindBymedication_id(medication_id).medication_name;
                }
                row.Cells["medication_name"].Value = medicationName;
            }
            //display employee name instead of id
            GetEmployeeName(ref dgMedications);

            dgMedications.Columns["animal_id"].DisplayIndex= 0;
            dgMedications.Columns["medication_name"].DisplayIndex= 1;
            dgMedications.Columns["datetime_given"].DisplayIndex = 2;
            dgMedications.Columns["employee_name"].DisplayIndex = 3;
        }

        private void DgVaccines_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgVaccines.ClearSelection();
            //display vaccine name instead of id in the grid
            AnimalMedical.vaccineDataTable dtVaccineTable = Utility.GetVaccine();
            int vaccine_id = 0;
            string vaccineName = string.Empty;
            foreach (DataGridViewRow row in dgVaccines.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["vaccine_id"].Value.ToString()))
                {
                    vaccine_id = (int)row.Cells["vaccine_id"].Value;
                    vaccineName = dtVaccineTable.FindByvaccine_id(vaccine_id).vaccine_name;
                }
                row.Cells["vaccine_name"].Value = vaccineName;
            }
            //display employee name instead of id
            GetEmployeeName(ref dgVaccines);

            dgVaccines.Columns["animal_id"].DisplayIndex = 0;
            dgVaccines.Columns["vaccine_name"].DisplayIndex = 1;
            dgVaccines.Columns["date_given"].DisplayIndex = 2;
            dgVaccines.Columns["next_date_due"].DisplayIndex = 3;
            dgVaccines.Columns["employee_name"].DisplayIndex = 4;
        }

        private void GetEmployeeName(ref DataGridView dg)
        {
            AnimalMedical.employeeDataTable dtEmployeesTable = Utility.GetEmployees();
            int employee_id = 0;
            string employeeName = string.Empty;
            foreach (DataGridViewRow row in dg.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["employee_id"].Value.ToString()))
                {
                    employee_id = (int)row.Cells["employee_id"].Value;
                    employeeName = dtEmployeesTable.FindByemployee_id(employee_id).firstname+ " " + dtEmployeesTable.FindByemployee_id(employee_id).lastname;
                }
                row.Cells["employee_name"].Value = employeeName;
            }
        }
        private void VaccineTableFormatting()
        {
            //Vaccine table formatting
            dgVaccines.Columns["animal_id"].HeaderText = "Animal ID";
            dgVaccines.Columns["date_given"].HeaderText = "Date Given";
            dgVaccines.Columns["next_date_due"].HeaderText = "Next Date Due";
            dgVaccines.Columns["vaccine_id"].Visible = false;
            dgVaccines.Columns["employee_id"].Visible = false;
            dgVaccines.Columns["vaccine_log_id"].Visible = false;
            dgVaccines.Columns["animalRow"].Visible = false;
            dgVaccines.Columns["vaccineRow"].Visible = false;
            dgVaccines.Columns["employeeRow"].Visible = false;
            dgVaccines.Columns["RowError"].Visible = false;
            dgVaccines.Columns["RowState"].Visible = false;
            dgVaccines.Columns["Table"].Visible = false;
            dgVaccines.Columns["HasErrors"].Visible = false;
            dgVaccines.RowHeadersVisible = false;

            DataGridViewColumn vaccineNameColumn = new DataGridViewColumn();
            vaccineNameColumn.HeaderText = "Vaccine";
            vaccineNameColumn.Name = "vaccine_name";
            vaccineNameColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgVaccines.Columns.Add(vaccineNameColumn);

            DataGridViewColumn employeeNameColumn = new DataGridViewColumn();
            employeeNameColumn.HeaderText = "Admin Employee";
            employeeNameColumn.Name = "employee_name";
            employeeNameColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgVaccines.Columns.Add(employeeNameColumn);

        }
        private void MedicationTableFormatting()
        {
            //Medication table formatting
            dgMedications.Columns["animal_id"].HeaderText = "Animal ID";
            dgMedications.Columns["datetime_given"].HeaderText = "Date Given";
            dgMedications.Columns["employee_id"].Visible = false;
            dgMedications.Columns["medication_id"].Visible = false;
            dgMedications.Columns["med_log_id"].Visible = false;
            dgMedications.Columns["animalRow"].Visible = false;
            dgMedications.Columns["medicationRow"].Visible = false;
            dgMedications.Columns["employeeRow"].Visible = false;
            dgMedications.Columns["RowError"].Visible = false;
            dgMedications.Columns["RowState"].Visible = false;
            dgMedications.Columns["Table"].Visible = false;
            dgMedications.Columns["HasErrors"].Visible = false;
            dgMedications.RowHeadersVisible = false;

            DataGridViewColumn medEmployeeNameColumn = new DataGridViewColumn();
            medEmployeeNameColumn.HeaderText = "Admin Employee";
            medEmployeeNameColumn.Name = "employee_name";
            medEmployeeNameColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgMedications.Columns.Add(medEmployeeNameColumn);

            DataGridViewColumn medicationNameColumn = new DataGridViewColumn();
            medicationNameColumn.HeaderText = "Medication";
            medicationNameColumn.Name = "medication_name";
            medicationNameColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgMedications.Columns.Add(medicationNameColumn);
        }
    }
}
