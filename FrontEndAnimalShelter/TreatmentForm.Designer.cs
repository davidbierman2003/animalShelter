namespace FrontEndAnimalShelter
{
    partial class TreatmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgVaccines = new System.Windows.Forms.DataGridView();
            this.dgMedications = new System.Windows.Forms.DataGridView();
            this.lblVaccineTable = new System.Windows.Forms.Label();
            this.lblMedicationTable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedications)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVaccines
            // 
            this.dgVaccines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccines.Location = new System.Drawing.Point(20, 225);
            this.dgVaccines.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgVaccines.Name = "dgVaccines";
            this.dgVaccines.RowHeadersWidth = 102;
            this.dgVaccines.RowTemplate.Height = 40;
            this.dgVaccines.Size = new System.Drawing.Size(1756, 380);
            this.dgVaccines.TabIndex = 0;
            // 
            // dgMedications
            // 
            this.dgMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedications.Location = new System.Drawing.Point(20, 696);
            this.dgMedications.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgMedications.Name = "dgMedications";
            this.dgMedications.RowHeadersWidth = 102;
            this.dgMedications.RowTemplate.Height = 40;
            this.dgMedications.Size = new System.Drawing.Size(1756, 361);
            this.dgMedications.TabIndex = 1;
            // 
            // lblVaccineTable
            // 
            this.lblVaccineTable.AutoSize = true;
            this.lblVaccineTable.Location = new System.Drawing.Point(27, 172);
            this.lblVaccineTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVaccineTable.Name = "lblVaccineTable";
            this.lblVaccineTable.Size = new System.Drawing.Size(361, 32);
            this.lblVaccineTable.TabIndex = 2;
            this.lblVaccineTable.Text = "Animal Vaccine Information";
            // 
            // lblMedicationTable
            // 
            this.lblMedicationTable.AutoSize = true;
            this.lblMedicationTable.Location = new System.Drawing.Point(27, 640);
            this.lblMedicationTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicationTable.Name = "lblMedicationTable";
            this.lblMedicationTable.Size = new System.Drawing.Size(398, 32);
            this.lblMedicationTable.TabIndex = 3;
            this.lblMedicationTable.Text = "Animal Medication Information";
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1947, 1107);
            this.ControlBox = false;
            this.Controls.Add(this.lblMedicationTable);
            this.Controls.Add(this.lblVaccineTable);
            this.Controls.Add(this.dgMedications);
            this.Controls.Add(this.dgVaccines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TreatmentForm";
            this.Text = "TreatmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVaccines;
        private System.Windows.Forms.DataGridView dgMedications;
        private System.Windows.Forms.Label lblVaccineTable;
        private System.Windows.Forms.Label lblMedicationTable;
    }
}