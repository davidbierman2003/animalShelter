using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace FrontEndAnimalShelter
{
    public partial class ToDoForm : Form
    {
        public ToDoForm()
        {
            InitializeComponent();
            AnimalMedical.vaccine_administration_logDataTable dtVaccineAdministration = Utility.GetVaccineAdministration();
            AnimalMedical.prescriptionDataTable dtPrescriptions = Utility.GetPrescription();
            dgVaccineToDo.DataSource = dtVaccineAdministration;
            dgMedications.DataSource = dtPrescriptions;

            //Change the widths of the columns
          //  dgMedications.Columns["med_log_id"].Width = 120;
          //  dgMedications.Columns["animal_id"].Width = 120;
          //  dgMedications.Columns["employee_id"].Width = 120;
          //  dgMedications.Columns["datetime_given"].Width = 120;

          //  dgMedications.Columns["med_log_id"].HeaderText = "Med Log Id";
         //   dgMedications.Columns["animal_id"].HeaderText = "Animal Id";
         //   dgMedications.Columns["employee_id"].HeaderText = "Employee Id";
        //    dgMedications.Columns["datetime_given"].HeaderText = "Date Time Given";





        }

        private void ToDoForm_Load(object sender, EventArgs e)
        {
            headerDate.Text = $"To Do List for {DateTime.Today.ToString("MM/dd/yyyy")}";        
        }
        
        

    }
}
