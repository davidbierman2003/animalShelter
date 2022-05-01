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
            ((System.ComponentModel.ISupportInitialize)(this.dgMedications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccines)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMedications
            // 
            this.dgMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedications.Location = new System.Drawing.Point(199, 317);
            this.dgMedications.Name = "dgMedications";
            this.dgMedications.ReadOnly = true;
            this.dgMedications.RowHeadersWidth = 102;
            this.dgMedications.RowTemplate.Height = 40;
            this.dgMedications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMedications.ShowCellErrors = false;
            this.dgMedications.ShowCellToolTips = false;
            this.dgMedications.ShowEditingIcon = false;
            this.dgMedications.ShowRowErrors = false;
            this.dgMedications.Size = new System.Drawing.Size(1078, 373);
            this.dgMedications.TabIndex = 0;
            // 
            // dgVaccines
            // 
            this.dgVaccines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccines.Location = new System.Drawing.Point(75, 853);
            this.dgVaccines.Name = "dgVaccines";
            this.dgVaccines.ReadOnly = true;
            this.dgVaccines.RowHeadersWidth = 102;
            this.dgVaccines.RowTemplate.Height = 40;
            this.dgVaccines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVaccines.ShowCellErrors = false;
            this.dgVaccines.ShowEditingIcon = false;
            this.dgVaccines.ShowRowErrors = false;
            this.dgVaccines.Size = new System.Drawing.Size(1342, 373);
            this.dgVaccines.TabIndex = 1;
            // 
            // lblAnimalInfo
            // 
            this.lblAnimalInfo.AutoSize = true;
            this.lblAnimalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimalInfo.Location = new System.Drawing.Point(62, 54);
            this.lblAnimalInfo.Name = "lblAnimalInfo";
            this.lblAnimalInfo.Size = new System.Drawing.Size(209, 76);
            this.lblAnimalInfo.TabIndex = 2;
            this.lblAnimalInfo.Text = "label1";
            // 
            // TreatmentHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1493, 1407);
            this.Controls.Add(this.lblAnimalInfo);
            this.Controls.Add(this.dgVaccines);
            this.Controls.Add(this.dgMedications);
            this.Name = "TreatmentHistoryForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
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
    }
}