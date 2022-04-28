using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Windows.Forms;

namespace SharedTables
{
    public class Medication
    {
        public Medication() { }

        public DataGridView FormatMedicationTable(DataGridView dgmedicationTable)
        {
            AnimalMedical.medicationDataTable medicationTable= Utility.GetMedication();

            dgmedicationTable.Columns["medication_id"].Visible = false;
            dgmedicationTable.Columns["unit_id"].Visible = false;
            //Rename the headers
            dgmedicationTable.Columns["medication_name"].HeaderText = "Medication Name";
            dgmedicationTable.Columns["concentration"].HeaderText = "Concentration";
            dgmedicationTable.Columns["dose"].HeaderText = "Dose";
            //Adding unit name column
            DataGridViewColumn unitColumn = new DataGridViewColumn();
            unitColumn.CellTemplate = dgmedicationTable.Columns["medication_name"].CellTemplate;
            unitColumn.HeaderText = "Unit";
            unitColumn.Name = "unit_name";
            dgmedicationTable.Columns.Add(unitColumn);

            return dgmedicationTable;
        }
        public DataGridView GetUnitName(DataGridView dgMedicationTable)
        {
            if (dgMedicationTable.Columns.Contains("unit_name"))
            {
                AnimalMedical.unitDataTable dtUnitTable = Utility.GetUnit();

                foreach (DataGridViewRow row in dgMedicationTable.Rows)
                {
                    if (row.Cells["unit_id"].Value != null)
                    {
                        var unit = dtUnitTable.Where(x => x.unit_id.ToString() == row.Cells["unit_id"].Value.ToString()).Select(y => y.unit_name).ToList();
                        if (unit.Count > 0)
                            row.Cells["unit_name"].Value = unit.First();
                    }
                }
            }
            return dgMedicationTable;
        }
    }

}
