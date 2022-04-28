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

            dgVaccineToDo.DataSource = dtVaccineAdministration;

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
