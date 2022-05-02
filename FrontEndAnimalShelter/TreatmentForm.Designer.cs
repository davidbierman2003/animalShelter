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
            this.personalInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedications)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVaccines
            // 
            this.dgVaccines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccines.Location = new System.Drawing.Point(8, 94);
            this.dgVaccines.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgVaccines.Name = "dgVaccines";
            this.dgVaccines.RowHeadersWidth = 102;
            this.dgVaccines.RowTemplate.Height = 40;
            this.dgVaccines.Size = new System.Drawing.Size(658, 159);
            this.dgVaccines.TabIndex = 0;
            // 
            // dgMedications
            // 
            this.dgMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedications.Location = new System.Drawing.Point(8, 292);
            this.dgMedications.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgMedications.Name = "dgMedications";
            this.dgMedications.RowHeadersWidth = 102;
            this.dgMedications.RowTemplate.Height = 40;
            this.dgMedications.Size = new System.Drawing.Size(658, 151);
            this.dgMedications.TabIndex = 1;
            // 
            // lblVaccineTable
            // 
            this.lblVaccineTable.AutoSize = true;
            this.lblVaccineTable.Location = new System.Drawing.Point(10, 72);
            this.lblVaccineTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVaccineTable.Name = "lblVaccineTable";
            this.lblVaccineTable.Size = new System.Drawing.Size(0, 13);
            this.lblVaccineTable.TabIndex = 2;
            // 
            // lblMedicationTable
            // 
            this.lblMedicationTable.AutoSize = true;
            this.lblMedicationTable.Location = new System.Drawing.Point(10, 268);
            this.lblMedicationTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedicationTable.Name = "lblMedicationTable";
            this.lblMedicationTable.Size = new System.Drawing.Size(0, 13);
            this.lblMedicationTable.TabIndex = 3;
            // 
            // personalInfoLabel
            // 
            this.personalInfoLabel.AutoSize = true;
            this.personalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoLabel.Location = new System.Drawing.Point(5, 72);
            this.personalInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.personalInfoLabel.Name = "personalInfoLabel";
            this.personalInfoLabel.Size = new System.Drawing.Size(178, 17);
            this.personalInfoLabel.TabIndex = 29;
            this.personalInfoLabel.Text = "Vaccination Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Medication Information";
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personalInfoLabel);
            this.Controls.Add(this.lblMedicationTable);
            this.Controls.Add(this.lblVaccineTable);
            this.Controls.Add(this.dgMedications);
            this.Controls.Add(this.dgVaccines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
        private System.Windows.Forms.Label personalInfoLabel;
        private System.Windows.Forms.Label label1;
    }
}