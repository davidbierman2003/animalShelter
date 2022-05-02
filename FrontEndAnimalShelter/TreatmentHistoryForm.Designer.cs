namespace FrontEndAnimalShelter
{
    partial class TreatmentHistoryForm
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
            this.dgMedications = new System.Windows.Forms.DataGridView();
            this.dgVaccines = new System.Windows.Forms.DataGridView();
            this.lblAnimalInfo = new System.Windows.Forms.Label();
            this.personalInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccines)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMedications
            // 
            this.dgMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedications.Location = new System.Drawing.Point(29, 126);
            this.dgMedications.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgMedications.Name = "dgMedications";
            this.dgMedications.ReadOnly = true;
            this.dgMedications.RowHeadersWidth = 102;
            this.dgMedications.RowTemplate.Height = 40;
            this.dgMedications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMedications.ShowCellErrors = false;
            this.dgMedications.ShowCellToolTips = false;
            this.dgMedications.ShowEditingIcon = false;
            this.dgMedications.ShowRowErrors = false;
            this.dgMedications.Size = new System.Drawing.Size(613, 165);
            this.dgMedications.TabIndex = 0;
            // 
            // dgVaccines
            // 
            this.dgVaccines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccines.Location = new System.Drawing.Point(29, 340);
            this.dgVaccines.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgVaccines.Name = "dgVaccines";
            this.dgVaccines.ReadOnly = true;
            this.dgVaccines.RowHeadersWidth = 102;
            this.dgVaccines.RowTemplate.Height = 40;
            this.dgVaccines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVaccines.ShowCellErrors = false;
            this.dgVaccines.ShowEditingIcon = false;
            this.dgVaccines.ShowRowErrors = false;
            this.dgVaccines.Size = new System.Drawing.Size(613, 184);
            this.dgVaccines.TabIndex = 1;
            // 
            // lblAnimalInfo
            // 
            this.lblAnimalInfo.AutoSize = true;
            this.lblAnimalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimalInfo.Location = new System.Drawing.Point(23, 23);
            this.lblAnimalInfo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAnimalInfo.Name = "lblAnimalInfo";
            this.lblAnimalInfo.Size = new System.Drawing.Size(248, 25);
            this.lblAnimalInfo.TabIndex = 2;
            this.lblAnimalInfo.Text = "Animal ID / Animal Name";
            // 
            // personalInfoLabel
            // 
            this.personalInfoLabel.AutoSize = true;
            this.personalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoLabel.Location = new System.Drawing.Point(26, 99);
            this.personalInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.personalInfoLabel.Name = "personalInfoLabel";
            this.personalInfoLabel.Size = new System.Drawing.Size(94, 17);
            this.personalInfoLabel.TabIndex = 29;
            this.personalInfoLabel.Text = "Medications";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Vaccinations";
            // 
            // TreatmentHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(939, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personalInfoLabel);
            this.Controls.Add(this.lblAnimalInfo);
            this.Controls.Add(this.dgVaccines);
            this.Controls.Add(this.dgMedications);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "TreatmentHistoryForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 21);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treatment History";
            ((System.ComponentModel.ISupportInitialize)(this.dgMedications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMedications;
        private System.Windows.Forms.DataGridView dgVaccines;
        private System.Windows.Forms.Label lblAnimalInfo;
        private System.Windows.Forms.Label personalInfoLabel;
        private System.Windows.Forms.Label label1;
    }
}