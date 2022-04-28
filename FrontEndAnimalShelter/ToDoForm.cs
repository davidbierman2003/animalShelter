using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndAnimalShelter
{
    public partial class ToDoForm : Form
    {
        public ToDoForm()
        {
            InitializeComponent();
            AnimalMedical.vaccine_administration_logDataTable dtVaccineAdministration = Utility.GetVaccineAdministration();
            AnimalMedical.medication_administration_logDataTable dtMedicationAdministration = Utility.GetMedicationAdministrationLog();
            dgVaccineToDo.DataSource = dtVaccineAdministration;
            dgMedications.DataSource = dtMedicationAdministration;

            //Change the widths of the columns
            dgMedications.Columns["med_log_id"].Width = 120;
            dgMedications.Columns["animal_id"].Width = 120;
            dgMedications.Columns["employee_id"].Width = 120;
            dgMedications.Columns["datetime_given"].Width = 120;

            dgMedications.Columns["med_log_id"].HeaderText = "Med Log Id";
            dgMedications.Columns["animal_id"].HeaderText = "Animal Id";
            dgMedications.Columns["employee_id"].HeaderText = "Employee Id";
            dgMedications.Columns["datetime_given"].HeaderText = "Date Time Given";





        }

        private void ToDoForm_Load(object sender, EventArgs e)
        {
            headerDate.Text = $"To Do List for {DateTime.Today.ToString("MM/dd/yyyy")}";
            
        }

        private void btnSubmitVaccine_Click(object sender, EventArgs e)
        {
            
            int animalID = string.IsNullOrEmpty(txtBoxAnimalID.Text) ? 999: int.Parse(txtBoxAnimalID.Text);
            int vaccineID = string.IsNullOrEmpty(txtBoxVaccineID.Text) ? 999: int.Parse(txtBoxVaccineID.Text);
            int employeeID = string.IsNullOrEmpty(txtBoxEmployeeID.Text) ? 999: int.Parse(txtBoxEmployeeID.Text);

            DateTime dateGivenDate = dateGiven.Value.Date;
            DateTime dateNextDateDueDate = dateNextDateDue.Value.Date;

            
            Utility.SaveVaccineAdmin(animalID, vaccineID, employeeID, dateGivenDate, dateNextDateDueDate);
            refreshVaccineData();
        }

        private void refreshVaccineData()
        {
            AnimalMedical.vaccine_administration_logDataTable dtVaccineAdministration = Utility.GetVaccineAdministration();
            dgVaccineToDo.DataSource = dtVaccineAdministration;

        }

    }
}
