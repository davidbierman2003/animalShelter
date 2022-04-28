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
            this.lblNumOfDay = new System.Windows.Forms.Label();
            this.lblTimesPerDay = new System.Windows.Forms.Label();
            this.txtFrequencyDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.numTimesPerDay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicationTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesPerDay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnimalid
            // 
            this.lblAnimalid.AutoSize = true;
            this.lblAnimalid.Location = new System.Drawing.Point(32, 57);
            this.lblAnimalid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimalid.Name = "lblAnimalid";
            this.lblAnimalid.Size = new System.Drawing.Size(137, 32);
            this.lblAnimalid.TabIndex = 0;
            this.lblAnimalid.Text = "Animal ID";
            // 
            // txtAnimalid
            // 
            this.txtAnimalid.Location = new System.Drawing.Point(213, 53);
            this.txtAnimalid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnimalid.Name = "txtAnimalid";
            this.txtAnimalid.Size = new System.Drawing.Size(722, 38);
            this.txtAnimalid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.dgMedicationTable.Location = new System.Drawing.Point(242, 152);
            this.dgMedicationTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgMedicationTable.MultiSelect = false;
            this.dgMedicationTable.Name = "dgMedicationTable";
            this.dgMedicationTable.ReadOnly = true;
            this.dgMedicationTable.RowHeadersWidth = 102;
            this.dgMedicationTable.RowTemplate.Height = 40;
            this.dgMedicationTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMedicationTable.Size = new System.Drawing.Size(1341, 394);
            this.dgMedicationTable.TabIndex = 3;
            this.dgMedicationTable.TabStop = false;
            // 
            // lblDose
            // 
            this.lblDose.AutoSize = true;
            this.lblDose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDose.Location = new System.Drawing.Point(53, 601);
            this.lblDose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDose.Name = "lblDose";
            this.lblDose.Size = new System.Drawing.Size(284, 32);
            this.lblDose.TabIndex = 4;
            this.lblDose.Text = "Animal Specific Dose";
            // 
            // txtDose
            // 
            this.txtDose.Location = new System.Drawing.Point(356, 597);
            this.txtDose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(351, 38);
            this.txtDose.TabIndex = 5;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMethod.Location = new System.Drawing.Point(37, 680);
            this.lblMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(299, 32);
            this.lblMethod.TabIndex = 6;
            this.lblMethod.Text = "Administration Method";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStartDate.Location = new System.Drawing.Point(791, 597);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(142, 32);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date";
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(958, 597);
            this.dateStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 38);
            this.dateStart.TabIndex = 9;
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(958, 671);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 38);
            this.dateEnd.TabIndex = 11;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEndDate.Location = new System.Drawing.Point(802, 671);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(133, 32);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(96, 750);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(233, 32);
            this.lblStaff.TabIndex = 12;
            this.lblStaff.Text = "Assigned Staff ID";
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(356, 750);
            this.txtStaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(351, 38);
            this.txtStaff.TabIndex = 13;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(350, 1000);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(1121, 274);
            this.txtNotes.TabIndex = 15;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(327, 952);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(89, 32);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.Text = "Notes";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(788, 1300);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(244, 79);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbAdminMethod
            // 
            this.cmbAdminMethod.FormattingEnabled = true;
            this.cmbAdminMethod.Location = new System.Drawing.Point(356, 674);
            this.cmbAdminMethod.Name = "cmbAdminMethod";
            this.cmbAdminMethod.Size = new System.Drawing.Size(351, 39);
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
            this.groupBox1.Location = new System.Drawing.Point(1234, 601);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 363);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frequency";
            // 
            // lblNumOfDay
            // 
            this.lblNumOfDay.AutoSize = true;
            this.lblNumOfDay.Location = new System.Drawing.Point(23, 69);
            this.lblNumOfDay.Name = "lblNumOfDay";
            this.lblNumOfDay.Size = new System.Drawing.Size(217, 32);
            this.lblNumOfDay.TabIndex = 0;
            this.lblNumOfDay.Text = "Number of Days";
            // 
            // lblTimesPerDay
            // 
            this.lblTimesPerDay.AutoSize = true;
            this.lblTimesPerDay.Location = new System.Drawing.Point(23, 136);
            this.lblTimesPerDay.Name = "lblTimesPerDay";
            this.lblTimesPerDay.Size = new System.Drawing.Size(197, 32);
            this.lblTimesPerDay.TabIndex = 2;
            this.lblTimesPerDay.Text = "Times per Day";
            // 
            // txtFrequencyDesc
            // 
            this.txtFrequencyDesc.Location = new System.Drawing.Point(187, 190);
            this.txtFrequencyDesc.Multiline = true;
            this.txtFrequencyDesc.Name = "txtFrequencyDesc";
            this.txtFrequencyDesc.Size = new System.Drawing.Size(318, 154);
            this.txtFrequencyDesc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // numDays
            // 
            this.numDays.Location = new System.Drawing.Point(267, 63);
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(120, 38);
            this.numDays.TabIndex = 19;
            // 
            // numTimesPerDay
            // 
            this.numTimesPerDay.Location = new System.Drawing.Point(267, 130);
            this.numTimesPerDay.Name = "numTimesPerDay";
            this.numTimesPerDay.Size = new System.Drawing.Size(120, 38);
            this.numTimesPerDay.TabIndex = 20;
            // 
            // AddPerscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1821, 1391);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddPerscriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Perscription";
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicationTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesPerDay)).EndInit();
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
    }
}