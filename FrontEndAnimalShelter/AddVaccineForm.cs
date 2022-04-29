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
    public partial class AddVaccineForm : Form
    {
        List<int> animaIds = new List<int>();
        DataGridViewRow vaccineRow;
        int employeeId = 0;
        public AddVaccineForm()
        {
            InitializeComponent();
            MoreInitializing();
        }
        public AddVaccineForm(DataGridViewSelectedRowCollection selectedAnimals)
        {
            InitializeComponent();
            MoreInitializing();
            foreach (DataGridViewRow animal in selectedAnimals)
            {
                txtAnimalId.Text += animal.Cells["db_bridge_id"].Value.ToString() + " ";
                animaIds.Add((int)animal.Cells["animal_id"].Value);
            }
        }
        public void MoreInitializing()
        {

            #region Data Binding
            AnimalMedical.vaccineDataTable dtVaccineTable = new AnimalMedical.vaccineDataTable();
            dtVaccineTable = Utility.GetVaccine();
            dgVaccineTable.DataSource = dtVaccineTable;
            #endregion
            
            FormatTable();

            #region Events
            dgVaccineTable.DataBindingComplete += DgVaccineTable_DataBindingComplete;
            dgVaccineTable.CellClick += DgVaccineTable_CellClick;
            txtEmpId.Leave += TxtEmpId_Leave;
            #endregion
        }

        private void TxtEmpId_Leave(object sender, EventArgs e)
        {
            if (txtEmpId.TextLength > 0)
            {
                AnimalMedical.employeeDataTable dtEmployeeTable = Utility.GetEmployees();
                var employeeResults = dtEmployeeTable.Where(x => x.employee_id == int.Parse(txtEmpId.Text)).ToList();
                if (employeeResults.Count == 0)
                {
                    //MessageBox.Show("Employee ID is not valid.");
                    errorEmpId.SetError(txtEmpId, "Employee ID is not valid");
                }
                else
                {
                    employeeId = int.Parse(txtEmpId.Text);
                    errorEmpId.Clear();
                }
            }
        }

        private void DgVaccineTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            vaccineRow = dg.Rows[0];  //only one row can be selected
        }

        private void DgVaccineTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgVaccineTable.ClearSelection();
        }
        private void FormatTable()
        {
            dgVaccineTable.Columns["vaccine_id"].Visible = false;
            dgVaccineTable.Columns["vaccine_name"].HeaderText = "Vaccine Name";
            dgVaccineTable.Columns["lot_id"].HeaderText = "Lot ID";
            dgVaccineTable.Columns["expiration"].HeaderText = "Expiration";
            dgVaccineTable.Columns["concentration"].HeaderText = "Concentration";

            dgVaccineTable.RowHeadersVisible = false;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string validIds = "";
            string invalidIds = "";
            AnimalMedical.animalDataTable aniamlDB = Utility.GetAnimals();

            if (animaIds.Count == 0)  //mutliple animals were not selected from the grid
            {
                var animalIdResults = aniamlDB.Where(x => x.db_bridge_id == txtAnimalId.Text).Select(y => y.animal_id).ToList();
                animaIds.Add(animalIdResults[0]); //collect the database animal id
            }

            foreach (int id in animaIds)
            {
                //Check if animal has been added to the database
                var validId = aniamlDB.Where(x => x.animal_id == id).ToList();  //does animal exist in database
                if (validId.Count > 0) //animal does exist in the database
                {
                    validIds += id + " ";
                    Utility.SaveAdministeredVaccine(validId[0].animal_id, (int)vaccineRow.Cells["vaccine_id"].Value, int.Parse(txtEmpId.Text),dateGiven.Value, dateDue.Value);
                }
                else  //animal id is not valid (not in database)
                {
                    invalidIds += id + " ";
                }
            }
            if (!string.IsNullOrEmpty(validIds))
            {
                MessageBox.Show($"Vaccines for animals {validIds} have been saved.");
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
