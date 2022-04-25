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
    public partial class ViewEmployees : Form
    {
        AnimalMedical.employeeDataTable dtEmployees = new AnimalMedical.employeeDataTable();
        public ViewEmployees()
        {
            InitializeComponent();

            #region data bind region
            dtEmployees = Utility.GetEmployees();
            dgEmployees.DataSource = dtEmployees;
            #endregion

            #region 
            dgEmployees.CellClick += DgEmployees_CellClick;
            #endregion
            FormatGrid();
        }

        private void DgEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentEmpId = -1;
            DataGridView dg = (DataGridView)sender;  //have to cast here because sender is passed using type object, we want it to be DataGridView
            DataGridViewRow rowToBeOperatedUpon = dg.Rows[e.RowIndex];

            if (dg.SelectedCells[0] is DataGridViewButtonCell)
            {
                currentEmpId = int.Parse(rowToBeOperatedUpon.Cells["employee_id"].Value.ToString());

                DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                if (selectedCell.Value.Equals("Delete"))
                {
                    DialogResult deleteCheck = MessageBox.Show("You have selected to delete employee " + currentEmpId + ". Countinue with delete?", "Delete Employee", MessageBoxButtons.YesNo);
                    if (deleteCheck == DialogResult.Yes)
                    {
                        Utility.DeleteEmployee(selectedCell.RowIndex);
                        dgEmployees.DataSource = Utility.GetEmployees();
                    }
                }
                else if (selectedCell.Value.Equals("Save"))
                {
                    if (AreDigitsOnly(rowToBeOperatedUpon.Cells["employee_id"].Value.ToString()))
                    {
                        var employee = dtEmployees.Where(x => x.employee_id == currentEmpId).ToList();
                        if (employee.Count > 0) //employee is already in the database, any changes are taken as an edit to that emplyee
                        {
                            Utility.EditEmployee(int.Parse(rowToBeOperatedUpon.Cells["employee_id"].Value.ToString()), rowToBeOperatedUpon.Cells["first_name"].Value.ToString(), rowToBeOperatedUpon.Cells["last_name"].Value.ToString());
                            MessageBox.Show("Edits to employee " + currentEmpId + " have been saved to the database");
                        }
                        else  //changes made are for a new employee, a new employee is added to the database
                        {
                            Utility.AddEmployee(int.Parse(rowToBeOperatedUpon.Cells["employee_id"].Value.ToString()), rowToBeOperatedUpon.Cells["first_name"].Value.ToString(), rowToBeOperatedUpon.Cells["last_name"].Value.ToString());
                            MessageBox.Show($"Employee {currentEmpId} has been added to the database.");
                        }

                        dgEmployees.DataSource = Utility.GetEmployees();
                    }
                    else
                    {
                        MessageBox.Show($"Emplyee ID {rowToBeOperatedUpon.Cells["employee_id"].Value.ToString()} is not in the correct format. ID can not be empty and be numbers only");
                    }
                }
            }
        }
        private void FormatGrid()
        {
            dgEmployees.Columns["employee_id"].HeaderText = "Employee ID";
            dgEmployees.Columns["first_name"].HeaderText = "First Name";
            dgEmployees.Columns["last_name"].HeaderText = "Last Name";

            //Edit Button
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Save";
            editColumn.Text = "Save";
            editColumn.UseColumnTextForButtonValue = true;
            editColumn.Name = "saveButton";
            dgEmployees.Columns.Add(editColumn);

            //Delete Button
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Name = "deleteButton";
            dgEmployees.Columns.Add(deleteColumn);
        }
        public static bool AreDigitsOnly(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            foreach (char character in text)
            {
                if (character < '0' || character > '9')
                    return false;
            }
            return true;
        }
    }
}
