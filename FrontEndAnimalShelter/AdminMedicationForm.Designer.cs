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
            ((System.ComponentModel.ISupportInitialize)(this.dgPerscriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnimalId
            // 
            this.lblAnimalId.AutoSize = true;
            this.lblAnimalId.Location = new System.Drawing.Point(33, 36);
            this.lblAnimalId.Name = "lblAnimalId";
            this.lblAnimalId.Size = new System.Drawing.Size(137, 32);
            this.lblAnimalId.TabIndex = 0;
            this.lblAnimalId.Text = "Animal ID";
            // 
            // txtAnimalId
            // 
            this.txtAnimalId.Location = new System.Drawing.Point(206, 29);
            this.txtAnimalId.Name = "txtAnimalId";
            this.txtAnimalId.Size = new System.Drawing.Size(533, 38);
            this.txtAnimalId.TabIndex = 1;
            // 
            // lblMedications
            // 
            this.lblMedications.AutoSize = true;
            this.lblMedications.Location = new System.Drawing.Point(33, 106);
            this.lblMedications.Name = "lblMedications";
            this.lblMedications.Size = new System.Drawing.Size(168, 32);
            this.lblMedications.TabIndex = 2;
            this.lblMedications.Text = "Medications";
            // 
            // dgPerscriptions
            // 
            this.dgPerscriptions.AllowUserToAddRows = false;
            this.dgPerscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPerscriptions.Location = new System.Drawing.Point(39, 156);
            this.dgPerscriptions.Name = "dgPerscriptions";
            this.dgPerscriptions.RowHeadersWidth = 102;
            this.dgPerscriptions.RowTemplate.Height = 40;
            this.dgPerscriptions.Size = new System.Drawing.Size(2455, 410);
            this.dgPerscriptions.TabIndex = 3;
            this.dgPerscriptions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPerscriptions_CellContentClick);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(965, 32);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(402, 32);
            this.lblEmployeeID.TabIndex = 4;
            this.lblEmployeeID.Text = "Administered by (employee ID)";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(1373, 26);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(227, 38);
            this.txtEmployeeId.TabIndex = 5;
            // 
            // lblGiven
            // 
            this.lblGiven.AutoSize = true;
            this.lblGiven.Location = new System.Drawing.Point(1801, 35);
            this.lblGiven.Name = "lblGiven";
            this.lblGiven.Size = new System.Drawing.Size(157, 32);
            this.lblGiven.TabIndex = 6;
            this.lblGiven.Text = "Date Given";
            // 
            // dateGiven
            // 
            this.dateGiven.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGiven.Location = new System.Drawing.Point(1972, 29);
            this.dateGiven.Name = "dateGiven";
            this.dateGiven.Size = new System.Drawing.Size(200, 38);
            this.dateGiven.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1199, 646);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(224, 75);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AdminMedicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2617, 865);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateGiven);
            this.Controls.Add(this.lblGiven);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.dgPerscriptions);
            this.Controls.Add(this.lblMedications);
            this.Controls.Add(this.txtAnimalId);
            this.Controls.Add(this.lblAnimalId);
            this.Name = "AdminMedicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMedicationForm";
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
    }
}