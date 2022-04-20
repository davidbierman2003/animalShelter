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
            this.lblAnimalId = new System.Windows.Forms.Label();
            this.txtAnimalId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedications)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVaccines
            // 
            this.dgVaccines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccines.Location = new System.Drawing.Point(24, 487);
            this.dgVaccines.Name = "dgVaccines";
            this.dgVaccines.RowHeadersWidth = 102;
            this.dgVaccines.RowTemplate.Height = 40;
            this.dgVaccines.Size = new System.Drawing.Size(1756, 306);
            this.dgVaccines.TabIndex = 0;
            // 
            // dgMedications
            // 
            this.dgMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedications.Location = new System.Drawing.Point(24, 895);
            this.dgMedications.Name = "dgMedications";
            this.dgMedications.RowHeadersWidth = 102;
            this.dgMedications.RowTemplate.Height = 40;
            this.dgMedications.Size = new System.Drawing.Size(1756, 306);
            this.dgMedications.TabIndex = 1;
            // 
            // lblVaccineTable
            // 
            this.lblVaccineTable.AutoSize = true;
            this.lblVaccineTable.Location = new System.Drawing.Point(24, 449);
            this.lblVaccineTable.Name = "lblVaccineTable";
            this.lblVaccineTable.Size = new System.Drawing.Size(361, 32);
            this.lblVaccineTable.TabIndex = 2;
            this.lblVaccineTable.Text = "Animal Vaccine Information";
            // 
            // lblMedicationTable
            // 
            this.lblMedicationTable.AutoSize = true;
            this.lblMedicationTable.Location = new System.Drawing.Point(24, 851);
            this.lblMedicationTable.Name = "lblMedicationTable";
            this.lblMedicationTable.Size = new System.Drawing.Size(398, 32);
            this.lblMedicationTable.TabIndex = 3;
            this.lblMedicationTable.Text = "Animal Medication Information";
            // 
            // lblAnimalId
            // 
            this.lblAnimalId.AutoSize = true;
            this.lblAnimalId.Location = new System.Drawing.Point(12, 26);
            this.lblAnimalId.Name = "lblAnimalId";
            this.lblAnimalId.Size = new System.Drawing.Size(137, 32);
            this.lblAnimalId.TabIndex = 4;
            this.lblAnimalId.Text = "Animal ID";
            // 
            // txtAnimalId
            // 
            this.txtAnimalId.Location = new System.Drawing.Point(173, 26);
            this.txtAnimalId.Name = "txtAnimalId";
            this.txtAnimalId.Size = new System.Drawing.Size(212, 38);
            this.txtAnimalId.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(417, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 44);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 1377);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAnimalId);
            this.Controls.Add(this.lblAnimalId);
            this.Controls.Add(this.lblMedicationTable);
            this.Controls.Add(this.lblVaccineTable);
            this.Controls.Add(this.dgMedications);
            this.Controls.Add(this.dgVaccines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label lblAnimalId;
        private System.Windows.Forms.TextBox txtAnimalId;
        private System.Windows.Forms.Button btnSearch;
    }
}