using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace FrontEndAnimalShelter
{
    public partial class ToDoForm : Form
    {
      public void LoadDataFromTodo()
        {
            InitializeComponent();
            AnimalMedical.vaccine_administration_logDataTable dtVaccineAdministration = Utility.GetVaccineAdministration();
            AnimalMedical.prescriptionDataTable dtPrescriptions = Utility.GetPrescription();
            AnimalMedical.employeeDataTable dtEmployee = Utility.GetEmployees();

            dgVaccineToDo.DataSource = dtVaccineAdministration;
                       
            dgPrescriptions.DataSource = dtPrescriptions;

            //I removed one from the row count because there is a null roll
            int dgPrescriptionsRowCount = dgPrescriptions.Rows.Count - 1;

            int dgVaccineRowCount = dgVaccineToDo.Rows.Count - 1;

            dgPrescriptions.Columns["assigned_staff"].HeaderText = "Assigned Staff";

            //Convert the employee_ids to employee_name on the Prescription table 
            string assigned_staff_id = string.Empty;
            string firstName = string.Empty;
            int employeeId;
            for (int i = 0; i < dgPrescriptionsRowCount; i++)
            {
                //step 1 get the employee id from the datagrid
                assigned_staff_id = (string)dgPrescriptions.Rows[i].Cells["assigned_staff"].Value;
                //step 2 convert the string value of the employee id to an int
                employeeId = int.Parse(assigned_staff_id);
                //step 3 use the FindByEMployee_id method to get employees name that corresponds to
                //the employee id
                firstName = dtEmployee.FindByemployee_id(employeeId).firstname;
                //step 4 take the firstName and use it to replace the employee id in the data grid.
                dgPrescriptions.Rows[i].Cells["assigned_staff"].Value = firstName;
            }
            
            //Convert the employee_ids to employee_name on the Vaccine table
            for (int q = 0; q < dgVaccineRowCount; q++)
            {
                //Step 1 get the employee id from the datagrid
                employeeId = (int)dgVaccineToDo.Rows[q].Cells["employee_id"].Value;
                //Step 3 use the FindByEmployee_id method to get employees name the corresponds to the employee id
                firstName = dtEmployee.FindByemployee_id(employeeId).firstname;
                //Step 4 take the firstName and use it to replace the employee id in the data grid
             //   dgVaccineToDo.Rows[q].Cells["employee_id"].Value = firstName;
            }
        }

        public ToDoForm()
        {
            LoadDataFromTodo();
        }
        private void ToDoForm_Load(object sender, EventArgs e)
        {
            headerDate.Text = $"To Do List for {DateTime.Today.ToString("MM/dd/yyyy")}";        
        }
        
        

    }
}
