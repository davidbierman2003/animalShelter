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
            this.cmbAdminMethod = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numTimesPerDay = new System.Windows.Forms.NumericUpDown();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.txtFrequencyDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimesPerDay = new System.Windows.Forms.Label();
            this.lblNumOfDay = new System.Windows.Forms.Label();
            this.gbAdministration = new System.Windows.Forms.GroupBox();
            this.dateGiven = new System.Windows.Forms.DateTimePicker();
            this.lblDateGiven = new System.Windows.Forms.Label();
            this.txtAdminStaff = new System.Windows.Forms.TextBox();
            this.lblAdminEmp = new System.Windows.Forms.Label();
            this.additionalInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicationTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            this.gbAdministration.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAnimalid
            // 
            this.lblAnimalid.AutoSize = true;
            this.lblAnimalid.Location = new System.Drawing.Point(12, 24);
            this.lblAnimalid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimalid.Name = "lblAnimalid";
            this.lblAnimalid.Size = new System.Drawing.Size(52, 13);
            this.lblAnimalid.TabIndex = 0;
            this.lblAnimalid.Text = "Animal ID";
            // 
            // txtAnimalid
            // 
            this.txtAnimalid.Location = new System.Drawing.Point(80, 22);
            this.txtAnimalid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAnimalid.Name = "txtAnimalid";
            this.txtAnimalid.Size = new System.Drawing.Size(273, 20);
            this.txtAnimalid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // dgMedicationTable
            // 
            this.dgMedicationTable.AllowUserToAddRows = false;
            this.dgMedicationTable.AllowUserToOrderColumns = true;
            this.dgMedicationTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgMedicationTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgMedicationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedicationTable.Location = new System.Drawing.Point(91, 67);
            this.dgMedicationTable.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgMedicationTable.MultiSelect = false;
            this.dgMedicationTable.Name = "dgMedicationTable";
            this.dgMedicationTable.ReadOnly = true;
            this.dgMedicationTable.RowHeadersWidth = 102;
            this.dgMedicationTable.RowTemplate.Height = 40;
            this.dgMedicationTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMedicationTable.Size = new System.Drawing.Size(599, 167);
            this.dgMedicationTable.TabIndex = 3;
            this.dgMedicationTable.TabStop = false;
            // 
            // lblDose
            // 
            this.lblDose.AutoSize = true;
            this.lblDose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDose.Location = new System.Drawing.Point(92, 260);
            this.lblDose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDose.Name = "lblDose";
            this.lblDose.Size = new System.Drawing.Size(32, 13);
            this.lblDose.TabIndex = 4;
            this.lblDose.Text = "Dose";
            this.lblDose.Click += new System.EventHandler(this.lblDose_Click);
            // 
            // txtDose
            // 
            this.txtDose.Location = new System.Drawing.Point(134, 253);
            this.txtDose.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(134, 20);
            this.txtDose.TabIndex = 5;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMethod.Location = new System.Drawing.Point(81, 294);
            this.lblMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(43, 13);
            this.lblMethod.TabIndex = 6;
            this.lblMethod.Text = "Method";
            this.lblMethod.Click += new System.EventHandler(this.lblMethod_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStartDate.Location = new System.Drawing.Point(69, 328);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date";
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(135, 322);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(78, 20);
            this.dateStart.TabIndex = 9;
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(135, 353);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(78, 20);
            this.dateEnd.TabIndex = 11;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEndDate.Location = new System.Drawing.Point(72, 360);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(476, 425);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(43, 13);
            this.lblStaff.TabIndex = 12;
            this.lblStaff.Text = "Staff ID";
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(523, 422);
            this.txtStaff.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(134, 20);
            this.txtStaff.TabIndex = 13;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(135, 422);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(303, 96);
            this.txtNotes.TabIndex = 15;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(89, 422);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.Text = "Notes";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(531, 485);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 33);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbAdminMethod
            // 
            this.cmbAdminMethod.FormattingEnabled = true;
            this.cmbAdminMethod.Location = new System.Drawing.Point(134, 286);
            this.cmbAdminMethod.Margin = new System.Windows.Forms.Padding(1);
            this.cmbAdminMethod.Name = "cmbAdminMethod";
            this.cmbAdminMethod.Size = new System.Drawing.Size(134, 21);
            this.cmbAdminMethod.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numTimesPerDay);
            this.groupBox1.Controls.Add(this.numDays);
            this.groupBox1.Controls.Add(this.txtFrequencyDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTimesPerDay);
            this.groupBox1.Controls.Add(this.lblNumOfDay);
            this.groupBox1.Location = new System.Drawing.Point(289, 253);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(230, 152);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frequency";
            // 
            // numTimesPerDay
            // 
            this.numTimesPerDay.Location = new System.Drawing.Point(100, 55);
            this.numTimesPerDay.Margin = new System.Windows.Forms.Padding(1);
            this.numTimesPerDay.Name = "numTimesPerDay";
            this.numTimesPerDay.Size = new System.Drawing.Size(45, 20);
            this.numTimesPerDay.TabIndex = 20;
            // 
            // numDays
            // 
            this.numDays.Location = new System.Drawing.Point(100, 26);
            this.numDays.Margin = new System.Windows.Forms.Padding(1);
            this.numDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(45, 20);
            this.numDays.TabIndex = 19;
            // 
            // txtFrequencyDesc
            // 
            this.txtFrequencyDesc.Location = new System.Drawing.Point(100, 82);
            this.txtFrequencyDesc.Margin = new System.Windows.Forms.Padding(1);
            this.txtFrequencyDesc.Multiline = true;
            this.txtFrequencyDesc.Name = "txtFrequencyDesc";
            this.txtFrequencyDesc.Size = new System.Drawing.Size(121, 60);
            this.txtFrequencyDesc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // lblTimesPerDay
            // 
            this.lblTimesPerDay.AutoSize = true;
            this.lblTimesPerDay.Location = new System.Drawing.Point(9, 57);
            this.lblTimesPerDay.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTimesPerDay.Name = "lblTimesPerDay";
            this.lblTimesPerDay.Size = new System.Drawing.Size(75, 13);
            this.lblTimesPerDay.TabIndex = 2;
            this.lblTimesPerDay.Text = "Times per Day";
            // 
            // lblNumOfDay
            // 
            this.lblNumOfDay.AutoSize = true;
            this.lblNumOfDay.Location = new System.Drawing.Point(9, 29);
            this.lblNumOfDay.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNumOfDay.Name = "lblNumOfDay";
            this.lblNumOfDay.Size = new System.Drawing.Size(83, 13);
            this.lblNumOfDay.TabIndex = 0;
            this.lblNumOfDay.Text = "Number of Days";
            // 
            // gbAdministration
            // 
            this.gbAdministration.Controls.Add(this.dateGiven);
            this.gbAdministration.Controls.Add(this.lblDateGiven);
            this.gbAdministration.Controls.Add(this.txtAdminStaff);
            this.gbAdministration.Controls.Add(this.lblAdminEmp);
            this.gbAdministration.Location = new System.Drawing.Point(531, 253);
            this.gbAdministration.Margin = new System.Windows.Forms.Padding(1);
            this.gbAdministration.Name = "gbAdministration";
            this.gbAdministration.Padding = new System.Windows.Forms.Padding(1);
            this.gbAdministration.Size = new System.Drawing.Size(159, 152);
            this.gbAdministration.TabIndex = 19;
            this.gbAdministration.TabStop = false;
            this.gbAdministration.Text = "Administration";
            // 
            // dateGiven
            // 
            this.dateGiven.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGiven.Location = new System.Drawing.Point(78, 52);
            this.dateGiven.Margin = new System.Windows.Forms.Padding(1);
            this.dateGiven.Name = "dateGiven";
            this.dateGiven.Size = new System.Drawing.Size(78, 20);
            this.dateGiven.TabIndex = 3;
            // 
            // lblDateGiven
            // 
            this.lblDateGiven.AutoSize = true;
            this.lblDateGiven.Location = new System.Drawing.Point(2, 55);
            this.lblDateGiven.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDateGiven.Name = "lblDateGiven";
            this.lblDateGiven.Size = new System.Drawing.Size(62, 13);
            this.lblDateGiven.TabIndex = 2;
            this.lblDateGiven.Text = "Admin Date";
            // 
            // txtAdminStaff
            // 
            this.txtAdminStaff.Location = new System.Drawing.Point(78, 25);
            this.txtAdminStaff.Margin = new System.Windows.Forms.Padding(1);
            this.txtAdminStaff.Name = "txtAdminStaff";
            this.txtAdminStaff.Size = new System.Drawing.Size(76, 20);
            this.txtAdminStaff.TabIndex = 1;
            // 
            // lblAdminEmp
            // 
            this.lblAdminEmp.AutoSize = true;
            this.lblAdminEmp.Location = new System.Drawing.Point(2, 28);
            this.lblAdminEmp.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAdminEmp.Name = "lblAdminEmp";
            this.lblAdminEmp.Size = new System.Drawing.Size(43, 13);
            this.lblAdminEmp.TabIndex = 0;
            this.lblAdminEmp.Text = "Staff ID";
            // 
            // additionalInfoLabel
            // 
            this.additionalInfoLabel.AutoSize = true;
            this.additionalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalInfoLabel.Location = new System.Drawing.Point(68, 49);
            this.additionalInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.additionalInfoLabel.Name = "additionalInfoLabel";
            this.additionalInfoLabel.Size = new System.Drawing.Size(94, 17);
            this.additionalInfoLabel.TabIndex = 32;
            this.additionalInfoLabel.Text = "Medications";
            this.additionalInfoLabel.Click += new System.EventHandler(this.additionalInfoLabel_Click);
            // 
            // AddPerscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(891, 632);
            this.Controls.Add(this.additionalInfoLabel);
            this.Controls.Add(this.gbAdministration);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbAdminMethod);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.txtDose);
            this.Controls.Add(this.lblDose);
            this.Controls.Add(this.dgMedicationTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnimalid);
            this.Controls.Add(this.lblAnimalid);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "AddPerscriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Prescription";
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicationTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            this.gbAdministration.ResumeLayout(false);
            this.gbAdministration.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbAdminMethod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTimesPerDay;
        private System.Windows.Forms.Label lblNumOfDay;
        private System.Windows.Forms.TextBox txtFrequencyDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTimesPerDay;
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.GroupBox gbAdministration;
        private System.Windows.Forms.DateTimePicker dateGiven;
        private System.Windows.Forms.Label lblDateGiven;
        private System.Windows.Forms.TextBox txtAdminStaff;
        private System.Windows.Forms.Label lblAdminEmp;
        private System.Windows.Forms.Label additionalInfoLabel;
    }
}