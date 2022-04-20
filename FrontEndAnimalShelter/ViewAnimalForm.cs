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
    public partial class ViewAnimalForm : Form
    {
        public ViewAnimalForm()
        {
            InitializeComponent();

            dtpBirthdate.MaxDate = DateTime.Today;
            dtpBirthdate.Value = DateTime.Today;  //setting default birthdate value to today
            dtpIntakeDate.MaxDate = DateTime.Today;
            dtpIntakeDate.Value = DateTime.Today; //setting default intake date to today

            #region Data Binding
            AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();
            dgAnimalTable.DataSource = dtAnimalTable;

            //Populate combo and list boxes from the database
            AnimalMedical.speciesDataTable dtSpecies = Utility.GetSpecies();
            cmbSpecies.DataSource = dtSpecies;
            cmbSpecies.ValueMember = dtSpecies.species_idColumn.ColumnName;  //value is the species ID code
            cmbSpecies.DisplayMember = dtSpecies.species_nameColumn.ColumnName;  //value displayed is the species name
            cmbSpecies.SelectedItem = null;

            AnimalMedical.breedDataTable dtBreed = Utility.GetBreed();
            lbxBreed.DataSource = dtBreed;
            lbxBreed.ValueMember = dtBreed.breed_idColumn.ColumnName;  //value is the species ID code
            lbxBreed.DisplayMember = dtBreed.breed_nameColumn.ColumnName;
            lbxBreed.SelectedItem = null;

            AnimalMedical.colorDataTable dtColors = Utility.GetColors();
            lbxColor.DataSource = dtColors;
            lbxColor.ValueMember = dtColors.color_idColumn.ColumnName;
            lbxColor.DisplayMember = dtColors.colorColumn.ColumnName;
            lbxColor.SelectedItem = null;

            AnimalMedical.sexDataTable dtSex = Utility.GetSexID();
            cmbSex.DataSource = dtSex;
            cmbSex.ValueMember = dtSex.sex_idColumn.ColumnName;
            cmbSex.DisplayMember = dtSex.sex_nameColumn.ColumnName;
            cmbSex.SelectedItem = null;
            #endregion

            #region Events
            cmbSpecies.SelectionChangeCommitted += CmbSpecies_SelectionChangeCommitted;
            dgAnimalTable.BindingContextChanged += DgAnimalTable_BindingContextChanged;
            #endregion
            DatabaseTableFormatting();
        }

        private void DgAnimalTable_BindingContextChanged(object sender, EventArgs e)
        {
            if (dgAnimalTable.DataSource != null)
            {
                DataTable boundTable = dgAnimalTable.DataSource as DataTable;
                if (boundTable == null)
                {
                    DataView dv = dgAnimalTable.DataSource as DataView;
                    if (dv != null)
                    {
                        boundTable = dv.Table;
                    }
                }
                if (boundTable != null)
                {
                    foreach (DataGridViewColumn c in dgAnimalTable.Columns)
                    {
                        if (c.IsDataBound)
                        {
                            DataColumn dc = boundTable.Columns[c.DataPropertyName];
                            if (!dc.AllowDBNull && dc.DataType == typeof(string))
                            {
                                c.DefaultCellStyle.DataSourceNullValue = string.Empty;
                                dc.DefaultValue = string.Empty;  // this value is pulled for new rows
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Formatting the column headers and filling the list and combo boxes with data from the grid
        /// </summary>
        private void DatabaseTableFormatting()
        {
            //Formating headers
            dgAnimalTable.Columns["db_bridge_id"].HeaderText = "ID";
            dgAnimalTable.Columns["name"].HeaderText = "Name";
            dgAnimalTable.Columns["sex"].HeaderText = "Sex";
            dgAnimalTable.Columns["birthdate"].HeaderText = "Birth Date";
            dgAnimalTable.Columns["microchip_id"].HeaderText = "Microchip ID"; 
            dgAnimalTable.Columns["due_out_date"].HeaderText = "Due Out";
            dgAnimalTable.Columns["intake_date"].HeaderText = "Intake";
            //dgAnimalTable.Columns["notes"].HeaderText = "Notes";
            dgAnimalTable.Columns["weight"].HeaderText = "Weight";
            dgAnimalTable.Columns["kennel"].HeaderText = "Kennal";
            //dgAnimalTable.Columns["species_id"].HeaderText = "Species ID";
            dgAnimalTable.Columns["altered"].HeaderText = "Altered";
            dgAnimalTable.Columns["animal_id"].Visible = false;

            //TODO: make sure the sex column says male/female/unknown instaed of the sex_id
        }

        private void CmbSpecies_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AnimalMedical.breedDataTable dtBreed = Utility.GetBreed();
           
            if (cmbSpecies.SelectedItem != null)
            {
                var breedList = dtBreed.Where(x => x.species_id.ToString().Equals(cmbSpecies.SelectedValue.ToString())).ToList();
                lbxBreed.DataSource = breedList;
                lbxBreed.DisplayMember = "breed_name";
                lbxBreed.SelectedValue = "breed_id";
            }
            else
                lbxBreed.DisplayMember = dtBreed.breed_nameColumn.ColumnName;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();
            List<AnimalMedical.animalRow> selectedAnimals = dtAnimalTable.ToList();
            
            //Animal ID LINQ
            if (txtAnimlId.TextLength>0)
                selectedAnimals = selectedAnimals.Where(x => x.db_bridge_id.Equals(txtAnimlId.Text)).ToList();
            ////TODO: Species LINQ
            //if (cmbSpecies.SelectedItem != null) 
            //    selectedAnimals = selectedAnimals.Where(x => x.species_id.Equals(cmbSpecies.SelectedValue)).ToList();

            //TODO: Sex/Breed/Color searches

            //Microchip LINQ
            if (txtMicrochipId.TextLength > 0)
                selectedAnimals = selectedAnimals.Where(x => x.microchip_id.Equals(txtMicrochipId.Text)).ToList();
            
            //Weight LINQ
            if (txtWeight.TextLength >0)
            {
                if (cmbWeight.Text.Equals(">"))
                    selectedAnimals = selectedAnimals.Where(x => x.weight > decimal.Parse(txtWeight.Text)).ToList();
                else if (cmbWeight.Text.Equals("<"))
                    selectedAnimals = selectedAnimals.Where(x => x.weight < decimal.Parse(txtWeight.Text)).ToList();
                else if (cmbWeight.Text.Equals("="))
                    selectedAnimals = selectedAnimals.Where(x => x.weight == decimal.Parse(txtWeight.Text)).ToList();
            }
            //Kennel LINQ
            if (txtKennel.TextLength > 0)
                selectedAnimals = selectedAnimals.Where(x => x.kennel.Equals(txtKennel.Text)).ToList();
            
            //BirthdateLINQ
            if (cmbBirthdate.Text.Equals(">"))
                selectedAnimals = selectedAnimals.Where(x => x.birthdate.Ticks > dtpBirthdate.Value.Ticks).ToList();
            else if (cmbBirthdate.Text.Equals("<"))
                selectedAnimals = selectedAnimals.Where(x => x.birthdate.Ticks < dtpBirthdate.Value.Ticks).ToList();
            else if (cmbBirthdate.Text.Equals("="))
                selectedAnimals = selectedAnimals.Where(x => x.birthdate.Ticks == dtpBirthdate.Value.Ticks).ToList();

            //Intake date LINQ
            if (cmbIntake.Text.Equals(">"))
                selectedAnimals = selectedAnimals.Where(x => x.intake_date.Ticks > dtpIntakeDate.Value.Ticks).ToList();
            else if (cmbIntake.Text.Equals("<"))
                selectedAnimals = selectedAnimals.Where(x => x.intake_date.Ticks < dtpIntakeDate.Value.Ticks).ToList();
            else if (cmbIntake.Text.Equals("="))
                selectedAnimals = selectedAnimals.Where(x => x.intake_date.Ticks == dtpIntakeDate.Value.Ticks).ToList();

            //Due Out Date LINQ
            if (cmbDueOut.Text.Equals(">"))
                selectedAnimals = selectedAnimals.Where(x => x.due_out_date.Ticks > dtpDueOutDate.Value.Ticks).ToList();
            else if (cmbDueOut.Text.Equals("<"))
                selectedAnimals = selectedAnimals.Where(x => x.due_out_date.Ticks < dtpDueOutDate.Value.Ticks).ToList();
            else if (cmbDueOut.Text.Equals("="))
                selectedAnimals = selectedAnimals.Where(x => x.due_out_date.Ticks == dtpDueOutDate.Value.Ticks).ToList();


            //dgAnimalTable.DataSource = selectedAnimals;  //TODO: this needs to be tested once microship_id is removed from database
        }
    }
}
