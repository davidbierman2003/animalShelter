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
    public partial class AddPerscriptionForm : Form
    {
        List<string> animaIds = new List<string>();
        DataGridViewRow medicationRow;
        public AddPerscriptionForm()
        {
            InitializeComponent();
            MoreInitializing();
        }
        public AddPerscriptionForm(DataGridViewSelectedRowCollection selectedAnimals)
        {
            InitializeComponent();
            MoreInitializing();
            foreach (DataGridViewRow animal in selectedAnimals)
            {
                txtAnimalid.Text += animal.Cells["db_bridge_id"].Value.ToString() + " ";
                animaIds.Add(animal.Cells["db_bridge_id"].Value.ToString());
            }
        }
        private void FormatTable()
        {
            AnimalMedical.unitDataTable dtUnitTable = Utility.GetUnit();
            
            dgMedicationTable.Columns["medication_id"].Visible = false;
            dgMedicationTable.Columns["unit_id"].Visible = false;
            //Rename the headers
            dgMedicationTable.Columns["medication_name"].HeaderText = "Medication Name";
            dgMedicationTable.Columns["concentration"].HeaderText = "Concentration";
            dgMedicationTable.Columns["dose"].HeaderText = "Dose";
            dgMedicationTable.Columns["dose"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            //Adding unit name column
            DataGridViewColumn unitColumn = new DataGridViewColumn();
            unitColumn.CellTemplate = dgMedicationTable.Columns["medication_name"].CellTemplate;
            unitColumn.HeaderText = "Unit";
            unitColumn.Name = "unit_name";
            dgMedicationTable.Columns.Add(unitColumn);

            //remove the first column with no information in it.
            dgMedicationTable.RowHeadersVisible = false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string validIds = "";
            string invalidIds = "";
            if (animaIds.Count == 0)  //mutliple animals were not selected from the grid
            {
                animaIds.Add(txtAnimalid.Text); //collect the ID entered on the screen
            }
            AnimalMedical.animalDataTable aniamlDB = Utility.GetAnimals();
            foreach(string id in animaIds)
            {
                //Check if animal has been added to the database
                var validId = aniamlDB.Where(x => x.db_bridge_id == id).ToList();  //does animal exist in database
                if (validId.Count > 0) //animal does exist in the database
                {
                    validIds += id + " ";
                    Utility.SavePrescription(validId[0].animal_id,int.Parse(medicationRow.Cells["medication_id"].Value.ToString()),txtDose.Text,0,dateStart.Value,dateEnd.Value,txtStaff.Text,txtNotes.Text);
                }
                else  //animal id is not valid (not in database)
                {
                    invalidIds += id + " ";
                }
            }
            if (!string.IsNullOrEmpty(validIds))
            {
                MessageBox.Show($"Prescriptions for animals {validIds} have been saved.");
            }
            if (string.IsNullOrEmpty(invalidIds))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show($"An invalid animal ID has been entered. The animal needs to be added to the database or there was a typo: {invalidIds}");
                txtAnimalid.Text = invalidIds;
                txtAnimalid.Focus();
            }
        }

        private void MoreInitializing()
        {
            AnimalMedical.medicationDataTable dtMedicationTable = Utility.GetMedication();
            dgMedicationTable.DataSource = dtMedicationTable;
            FormatTable();

            dgMedicationTable.CellClick += DgMedicationTable_CellClick;
            dgMedicationTable.DataBindingComplete += DgMedicationTable_DataBindingComplete;
        }

        private void DgMedicationTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgMedicationTable.ClearSelection();  //clears any initial row selection that was not performed by user
        }
        /// <summary>
        ///When user clicks on grid cell the entire row is selected. We collect that row information here 
        /// </summary>
        private void DgMedicationTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cell click selects the entire row
            DataGridView dg = (DataGridView)sender;
            medicationRow = dg.Rows[0];  //only one row can be selected
        }

        private void dgMedicationTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
