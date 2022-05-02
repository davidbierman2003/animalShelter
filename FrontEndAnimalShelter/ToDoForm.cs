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

            //Add a column to the table employee_name
            DataGridViewColumn employeeNameColumn = new DataGridViewColumn();
            employeeNameColumn.HeaderText = "employee name";
            employeeNameColumn.Name = "employee_name";
            employeeNameColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgVaccineToDo.Columns.Add(employeeNameColumn);

            //Add a column to the table medication_name
            DataGridViewColumn medicationNameColumn = new DataGridViewColumn();
            medicationNameColumn.HeaderText = "medication";
            medicationNameColumn.Name = "medication_name";
            medicationNameColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgPrescriptions.Columns.Add(medicationNameColumn);

            //Add a column to the vaccine table vaccine_name
            DataGridViewColumn vaccineNameColumn = new DataGridViewColumn();
            vaccineNameColumn.HeaderText = "vaccine name";
            vaccineNameColumn.Name = "vaccine_name";
            vaccineNameColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgVaccineToDo.Columns.Add(vaccineNameColumn);

            //Add a column to the prescription table Administration method
            DataGridViewColumn methodColumn = new DataGridViewColumn();
            methodColumn.HeaderText = "method";
            methodColumn.Name = "administration_method";
            methodColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgPrescriptions.Columns.Add(methodColumn);

            //Add a column to the prescription table number of times
            DataGridViewColumn numTimesColumn = new DataGridViewColumn();
            numTimesColumn.HeaderText = "number of times";
            numTimesColumn.Name = "num_times";
            numTimesColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgPrescriptions.Columns.Add(numTimesColumn);

            //Add a column to the prescriptions table num_days
            DataGridViewColumn numDaysColumn = new DataGridViewColumn();
            numDaysColumn.HeaderText = "number of days";
            numDaysColumn.Name = "num_days";
            numDaysColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgPrescriptions.Columns.Add(numDaysColumn);

            //Add a column to the prescription table desc_value
            DataGridViewColumn descValueColumn = new DataGridViewColumn();
            descValueColumn.HeaderText = "desc_value";
            descValueColumn.Name = "desc_value";
            descValueColumn.CellTemplate = new DataGridViewTextBoxCell();
            dgPrescriptions.Columns.Add(descValueColumn);



            dgVaccineToDo.DataSource = dtVaccineAdministration;
            dgPrescriptions.DataSource = dtPrescriptions;

            //This adds the data to the added columns
            dgVaccineToDo.DataBindingComplete += DgVaccineToDo_DataBindingComplete;
            dgVaccineToDo.DataBindingComplete += DgVaccineToDo_DataBindingComplete1;
            dgPrescriptions.DataBindingComplete += DgPrescriptions_DataBindingComplete;
            dgPrescriptions.DataBindingComplete += DgPrescription_Method;
            dgPrescriptions.DataBindingComplete += DgPrescrptionFrequency;

            //I removed one from the row count because there is a null roll
            int dgPrescriptionsRowCount = dgPrescriptions.Rows.Count - 1;


            dgPrescriptions.Columns["assigned_staff"].HeaderText = "Assigned Staff";

            //hide the columns that aren't being used in the dgVaccineTodo.
            dgVaccineToDo.Columns["vaccine_log_ID"].Visible = false;
            dgVaccineToDo.Columns["vaccine_id"].Visible = false;
            dgVaccineToDo.Columns["employee_id"].Visible = false;

            //hide the columns that aren't being used in the dgPrescription
            dgPrescriptions.Columns["prescription_id"].Visible = false;
            dgPrescriptions.Columns["medication_id"].Visible = false;
            dgPrescriptions.Columns["animal_specific_method_id"].Visible = false;

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

        }

        private void DgPrescrptionFrequency(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AnimalMedical.frequencyDataTable dtFrequency = Utility.GetFrequency();
            int dgPrescriptionRowCount = dgPrescriptions.Rows.Count - 1;
            int frequencyId = 0;
            int numTimes = 0;
            int numDays = 0;
            string desc_value;
            for (int i = 0; i < dgPrescriptionRowCount; i++)
            {
                frequencyId = (int)dgPrescriptions.Rows[i].Cells["frequency_id"].Value;
                numTimes = dtFrequency.FindByfrequency_id(frequencyId).num_times;
                numDays = dtFrequency.FindByfrequency_id(frequencyId).num_days;
                desc_value = dtFrequency.FindByfrequency_id(frequencyId).desc_value;
                dgPrescriptions.Rows[i].Cells["num_times"].Value = numTimes;
                dgPrescriptions.Rows[i].Cells["num_days"].Value = numDays;
                dgPrescriptions.Rows[i].Cells["desc_value"].Value = desc_value;
            }

        }

        private void DgPrescription_Method(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AnimalMedical.admin_methodDataTable dtMethod = Utility.GetAdminMethod();
            int dgPrescriptionsRowCount = dgPrescriptions.Rows.Count - 1;
            int method_id;
            string method;

            for (int i = 0; i < dgPrescriptionsRowCount; i++)
            {
                method_id = (int)dgPrescriptions.Rows[i].Cells["animal_specific_method_id"].Value;
                method = dtMethod.FindByadmin_method_id(method_id).admin_method_name;
                dgPrescriptions.Rows[i].Cells["administration_method"].Value = method;
            }
        }

        private void DgVaccineToDo_DataBindingComplete1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AnimalMedical.vaccineDataTable dtVaccine = Utility.GetVaccine();
            int dgVaccineRowCount = dgVaccineToDo.Rows.Count - 1;
            string vaccineName = string.Empty;
            int vaccineId = 0;
            //Convert the employee_ids to employee_name on the Vaccine table
            for (int q = 0; q < dgVaccineRowCount; q++)
            {

                vaccineId = (int)dgVaccineToDo.Rows[q].Cells["vaccine_id"].Value;
                vaccineName = dtVaccine.FindByvaccine_id(vaccineId).vaccine_name;
                dgVaccineToDo.Rows[q].Cells["vaccine_name"].Value = vaccineName;
            }
        }

        private void DgPrescriptions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Convert the employee_ids to employee_name on the Prescription table 
            AnimalMedical.medicationDataTable dtMedication = Utility.GetMedication();
            int dgPrescriptionsRowCount = dgPrescriptions.Rows.Count - 1;
            int medication_id = 0;
            string medicationName = string.Empty;
            int employeeId;


            for (int i = 0; i < dgPrescriptionsRowCount; i++)
            {
                //step 1 get the medication_id from the datagrid
                medication_id = (int)dgPrescriptions.Rows[i].Cells["medication_id"].Value;
                //step 2 use the FindByEMployee_id method to get employees name that corresponds to
                //the employee id
                medicationName = dtMedication.FindBymedication_id(medication_id).medication_name;
                //step 4 take the firstName and use it to replace the employee id in the data grid.
                dgPrescriptions.Rows[i].Cells["medication_name"].Value = medicationName;
            }
        }

        private void DgVaccineToDo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AnimalMedical.employeeDataTable dtEmployee = Utility.GetEmployees();
            int dgVaccineRowCount = dgVaccineToDo.Rows.Count - 1;
            int employeeId;
            string firstName;

            //Convert the employee_ids to employee_name on the Vaccine table
            for (int q = 0; q < dgVaccineRowCount; q++)
            {
                //Step 1 get the employee id from the datagrid
                employeeId = (int)dgVaccineToDo.Rows[q].Cells["employee_id"].Value;
                //Step 3 use the FindByEmployee_id method to get employees name the corresponds to the employee id
                firstName = dtEmployee.FindByemployee_id(employeeId).firstname;
                //Step 4 take the firstName and use it to replace the employee id in the data grid
                dgVaccineToDo.Rows[q].Cells["employee_name"].Value = firstName;
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
