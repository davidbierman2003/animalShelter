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
    public partial class TreatmentForm : Form
    {
        public TreatmentForm()
        {
            InitializeComponent();

            //************ Medications ***********************
            //TODO: this needs to be use the new database tables, this table no longer exists
            //AnimalMedical.medicationwithunitDataTable dtMedication = Utility.GetMedication();
            //dgMedications.DataSource = dtMedication;

            ////Hide the medication_id
            //dgMedications.Columns["medication_id"].Visible = false;

            ////Rename the headers
            //dgMedications.Columns["medication_name"].HeaderText = "Medication Name";
            //dgMedications.Columns["concentration"].HeaderText = "Concentration";
            //dgMedications.Columns["dose"].HeaderText = "Dose";
            //dgMedications.Columns["unit_name"].HeaderText = "Unit Name";


            ////remove the first column with no information in it.
            //dgMedications.RowHeadersVisible = false;
            
            ////Change the widths of the columns
            //dgMedications.Columns["medication_name"].Width = 200;
            //dgMedications.Columns["concentration"].Width = 150;
            //dgMedications.Columns["dose"].Width = 350;
            //dgMedications.Columns["unit_name"].Width = 150;


            // **************** Vaccines ***************************

            AnimalMedical.vaccineDataTable dtVaccine = Utility.GetVaccine();
            dgVaccines.DataSource = dtVaccine;

            //Hide the medication_id
            dgVaccines.Columns["vaccine_id"].Visible = false;
            
            //remove the first column with no information in it.
            dgVaccines.RowHeadersVisible = false;

            //Change the name of the column
            dgVaccines.Columns["vaccine_name"].HeaderText = "Vaccine Name";
            //change the width
            dgVaccines.Columns["vaccine_name"].Width = 850;




        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
