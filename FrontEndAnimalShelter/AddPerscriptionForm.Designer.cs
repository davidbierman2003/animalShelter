namespace FrontEndAnimalShelter
{
    partial class AddPerscriptionForm
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
            this.lblAnimalid = new System.Windows.Forms.Label();
            this.txtAnimalid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgMedicationTable = new System.Windows.Forms.DataGridView();
            this.lblDose = new System.Windows.Forms.Label();
            this.txtDose = new System.Windows.Forms.TextBox();
            this.txtAdminMethod = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnimalid
            // 
            this.lblAnimalid.AutoSize = true;
            this.lblAnimalid.Location = new System.Drawing.Point(32, 58);
            this.lblAnimalid.Name = "lblAnimalid";
            this.lblAnimalid.Size = new System.Drawing.Size(137, 32);
            this.lblAnimalid.TabIndex = 0;
            this.lblAnimalid.Text = "Animal ID";
            // 
            // txtAnimalid
            // 
            this.txtAnimalid.Location = new System.Drawing.Point(213, 52);
            this.txtAnimalid.Name = "txtAnimalid";
            this.txtAnimalid.Size = new System.Drawing.Size(722, 38);
            this.txtAnimalid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medication";
            // 
            // dgMedicationTable
            // 
            this.dgMedicationTable.AllowUserToAddRows = false;
            this.dgMedicationTable.AllowUserToOrderColumns = true;
            this.dgMedicationTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgMedicationTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgMedicationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedicationTable.Location = new System.Drawing.Point(38, 152);
            this.dgMedicationTable.MultiSelect = false;
            this.dgMedicationTable.Name = "dgMedicationTable";
            this.dgMedicationTable.ReadOnly = true;
            this.dgMedicationTable.RowHeadersWidth = 102;
            this.dgMedicationTable.RowTemplate.Height = 40;
            this.dgMedicationTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMedicationTable.Size = new System.Drawing.Size(1268, 394);
            this.dgMedicationTable.TabIndex = 3;
            this.dgMedicationTable.TabStop = false;
            // 
            // lblDose
            // 
            this.lblDose.AutoSize = true;
            this.lblDose.Location = new System.Drawing.Point(38, 602);
            this.lblDose.Name = "lblDose";
            this.lblDose.Size = new System.Drawing.Size(284, 32);
            this.lblDose.TabIndex = 4;
            this.lblDose.Text = "Animal Specific Dose";
            // 
            // txtDose
            // 
            this.txtDose.Location = new System.Drawing.Point(355, 596);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(350, 38);
            this.txtDose.TabIndex = 5;
            // 
            // txtAdminMethod
            // 
            this.txtAdminMethod.Location = new System.Drawing.Point(355, 656);
            this.txtAdminMethod.Name = "txtAdminMethod";
            this.txtAdminMethod.Size = new System.Drawing.Size(350, 38);
            this.txtAdminMethod.TabIndex = 7;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(38, 662);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(299, 32);
            this.lblMethod.TabIndex = 6;
            this.lblMethod.Text = "Administration Method";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(38, 719);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(142, 32);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date";
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(355, 719);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 38);
            this.dateStart.TabIndex = 9;
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(355, 773);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 38);
            this.dateEnd.TabIndex = 11;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(38, 773);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(133, 32);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(38, 830);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(233, 32);
            this.lblStaff.TabIndex = 12;
            this.lblStaff.Text = "Assigned Staff ID";
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(355, 830);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(350, 38);
            this.txtStaff.TabIndex = 13;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(183, 891);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(951, 274);
            this.txtNotes.TabIndex = 15;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(38, 891);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(89, 32);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.Text = "Notes";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(543, 1229);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(244, 79);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddPerscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1331, 1369);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtAdminMethod);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.txtDose);
            this.Controls.Add(this.lblDose);
            this.Controls.Add(this.dgMedicationTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnimalid);
            this.Controls.Add(this.lblAnimalid);
            this.Name = "AddPerscriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Perscription";
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicationTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimalid;
        private System.Windows.Forms.TextBox txtAnimalid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMedicationTable;
        private System.Windows.Forms.Label lblDose;
        private System.Windows.Forms.TextBox txtDose;
        private System.Windows.Forms.TextBox txtAdminMethod;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnSubmit;
    }
}