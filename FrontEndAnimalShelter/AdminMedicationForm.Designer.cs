namespace FrontEndAnimalShelter
{
    partial class AdminMedicationForm
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
            this.lblAnimalId = new System.Windows.Forms.Label();
            this.txtAnimalId = new System.Windows.Forms.TextBox();
            this.lblMedications = new System.Windows.Forms.Label();
            this.dgPerscriptions = new System.Windows.Forms.DataGridView();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblGiven = new System.Windows.Forms.Label();
            this.dateGiven = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.personalInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerscriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnimalId
            // 
            this.lblAnimalId.AutoSize = true;
            this.lblAnimalId.Location = new System.Drawing.Point(12, 18);
            this.lblAnimalId.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAnimalId.Name = "lblAnimalId";
            this.lblAnimalId.Size = new System.Drawing.Size(52, 13);
            this.lblAnimalId.TabIndex = 0;
            this.lblAnimalId.Text = "Animal ID";
            // 
            // txtAnimalId
            // 
            this.txtAnimalId.Location = new System.Drawing.Point(77, 15);
            this.txtAnimalId.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtAnimalId.Name = "txtAnimalId";
            this.txtAnimalId.Size = new System.Drawing.Size(202, 20);
            this.txtAnimalId.TabIndex = 1;
            // 
            // lblMedications
            // 
            this.lblMedications.AutoSize = true;
            this.lblMedications.Location = new System.Drawing.Point(12, 44);
            this.lblMedications.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMedications.Name = "lblMedications";
            this.lblMedications.Size = new System.Drawing.Size(0, 13);
            this.lblMedications.TabIndex = 2;
            // 
            // dgPerscriptions
            // 
            this.dgPerscriptions.AllowUserToAddRows = false;
            this.dgPerscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPerscriptions.Location = new System.Drawing.Point(15, 77);
            this.dgPerscriptions.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgPerscriptions.Name = "dgPerscriptions";
            this.dgPerscriptions.RowHeadersWidth = 102;
            this.dgPerscriptions.RowTemplate.Height = 40;
            this.dgPerscriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPerscriptions.ShowCellErrors = false;
            this.dgPerscriptions.ShowCellToolTips = false;
            this.dgPerscriptions.ShowEditingIcon = false;
            this.dgPerscriptions.ShowRowErrors = false;
            this.dgPerscriptions.Size = new System.Drawing.Size(1006, 172);
            this.dgPerscriptions.TabIndex = 3;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(259, 260);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(149, 13);
            this.lblEmployeeID.TabIndex = 4;
            this.lblEmployeeID.Text = "Administered by (employee ID)";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(412, 258);
            this.txtEmployeeId.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(88, 20);
            this.txtEmployeeId.TabIndex = 5;
            // 
            // lblGiven
            // 
            this.lblGiven.AutoSize = true;
            this.lblGiven.Location = new System.Drawing.Point(596, 261);
            this.lblGiven.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblGiven.Name = "lblGiven";
            this.lblGiven.Size = new System.Drawing.Size(61, 13);
            this.lblGiven.TabIndex = 6;
            this.lblGiven.Text = "Date Given";
            // 
            // dateGiven
            // 
            this.dateGiven.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGiven.Location = new System.Drawing.Point(660, 258);
            this.dateGiven.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dateGiven.Name = "dateGiven";
            this.dateGiven.Size = new System.Drawing.Size(78, 20);
            this.dateGiven.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(483, 306);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 31);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // personalInfoLabel
            // 
            this.personalInfoLabel.AutoSize = true;
            this.personalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoLabel.Location = new System.Drawing.Point(15, 59);
            this.personalInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.personalInfoLabel.Name = "personalInfoLabel";
            this.personalInfoLabel.Size = new System.Drawing.Size(94, 17);
            this.personalInfoLabel.TabIndex = 29;
            this.personalInfoLabel.Text = "Medications";
            // 
            // AdminMedicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1047, 363);
            this.Controls.Add(this.personalInfoLabel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateGiven);
            this.Controls.Add(this.lblGiven);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.dgPerscriptions);
            this.Controls.Add(this.lblMedications);
            this.Controls.Add(this.txtAnimalId);
            this.Controls.Add(this.lblAnimalId);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "AdminMedicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medication Administration";
            ((System.ComponentModel.ISupportInitialize)(this.dgPerscriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimalId;
        private System.Windows.Forms.TextBox txtAnimalId;
        private System.Windows.Forms.Label lblMedications;
        private System.Windows.Forms.DataGridView dgPerscriptions;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblGiven;
        private System.Windows.Forms.DateTimePicker dateGiven;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label personalInfoLabel;
    }
}