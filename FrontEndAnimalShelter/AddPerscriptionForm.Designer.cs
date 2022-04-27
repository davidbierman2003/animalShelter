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
            this.lblAnimalid.Location = new System.Drawing.Point(18, 37);
            this.lblAnimalid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimalid.Name = "lblAnimalid";
            this.lblAnimalid.Size = new System.Drawing.Size(78, 20);
            this.lblAnimalid.TabIndex = 0;
            this.lblAnimalid.Text = "Animal ID";
            // 
            // txtAnimalid
            // 
            this.txtAnimalid.Location = new System.Drawing.Point(120, 34);
            this.txtAnimalid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnimalid.Name = "txtAnimalid";
            this.txtAnimalid.Size = new System.Drawing.Size(408, 26);
            this.txtAnimalid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
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
            this.dgMedicationTable.Location = new System.Drawing.Point(21, 98);
            this.dgMedicationTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgMedicationTable.MultiSelect = false;
            this.dgMedicationTable.Name = "dgMedicationTable";
            this.dgMedicationTable.ReadOnly = true;
            this.dgMedicationTable.RowHeadersWidth = 102;
            this.dgMedicationTable.RowTemplate.Height = 40;
            this.dgMedicationTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMedicationTable.Size = new System.Drawing.Size(713, 254);
            this.dgMedicationTable.TabIndex = 3;
            this.dgMedicationTable.TabStop = false;
            this.dgMedicationTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMedicationTable_CellContentClick);
            // 
            // lblDose
            // 
            this.lblDose.AutoSize = true;
            this.lblDose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDose.Location = new System.Drawing.Point(30, 388);
            this.lblDose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDose.Name = "lblDose";
            this.lblDose.Size = new System.Drawing.Size(159, 20);
            this.lblDose.TabIndex = 4;
            this.lblDose.Text = "Animal Specific Dose";
            // 
            // txtDose
            // 
            this.txtDose.Location = new System.Drawing.Point(200, 385);
            this.txtDose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(199, 26);
            this.txtDose.TabIndex = 5;
            // 
            // txtAdminMethod
            // 
            this.txtAdminMethod.Location = new System.Drawing.Point(200, 435);
            this.txtAdminMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdminMethod.Name = "txtAdminMethod";
            this.txtAdminMethod.Size = new System.Drawing.Size(199, 26);
            this.txtAdminMethod.TabIndex = 7;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMethod.Location = new System.Drawing.Point(21, 439);
            this.lblMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(168, 20);
            this.lblMethod.TabIndex = 6;
            this.lblMethod.Text = "Administration Method";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStartDate.Location = new System.Drawing.Point(445, 385);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(83, 20);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date";
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(539, 385);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(114, 26);
            this.dateStart.TabIndex = 9;
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(539, 433);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(114, 26);
            this.dateEnd.TabIndex = 11;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEndDate.Location = new System.Drawing.Point(451, 433);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(77, 20);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(54, 484);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(135, 20);
            this.lblStaff.TabIndex = 12;
            this.lblStaff.Text = "Assigned Staff ID";
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(200, 484);
            this.txtStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(199, 26);
            this.txtStaff.TabIndex = 13;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(120, 548);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(533, 178);
            this.txtNotes.TabIndex = 15;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(38, 548);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 20);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.Text = "Notes";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(305, 793);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 51);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddPerscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(749, 677);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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