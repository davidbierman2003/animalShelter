namespace FrontEndAnimalShelter
{
    partial class AddVaccineForm
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
            this.components = new System.ComponentModel.Container();
            this.lblAnimalId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblDateGiven = new System.Windows.Forms.Label();
            this.txtNextDate = new System.Windows.Forms.Label();
            this.txtAnimalId = new System.Windows.Forms.TextBox();
            this.dgVaccineTable = new System.Windows.Forms.DataGridView();
            this.dateGiven = new System.Windows.Forms.DateTimePicker();
            this.dateDue = new System.Windows.Forms.DateTimePicker();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.errorEmpId = new System.Windows.Forms.ErrorProvider(this.components);
            this.personalInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccineTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmpId)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnimalId
            // 
            this.lblAnimalId.AutoSize = true;
            this.lblAnimalId.Location = new System.Drawing.Point(12, 13);
            this.lblAnimalId.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAnimalId.Name = "lblAnimalId";
            this.lblAnimalId.Size = new System.Drawing.Size(52, 13);
            this.lblAnimalId.TabIndex = 0;
            this.lblAnimalId.Text = "Animal ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(23, 265);
            this.lblEmployeeId.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeId.TabIndex = 2;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // lblDateGiven
            // 
            this.lblDateGiven.AutoSize = true;
            this.lblDateGiven.Location = new System.Drawing.Point(23, 211);
            this.lblDateGiven.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDateGiven.Name = "lblDateGiven";
            this.lblDateGiven.Size = new System.Drawing.Size(61, 13);
            this.lblDateGiven.TabIndex = 3;
            this.lblDateGiven.Text = "Date Given";
            // 
            // txtNextDate
            // 
            this.txtNextDate.AutoSize = true;
            this.txtNextDate.Location = new System.Drawing.Point(12, 234);
            this.txtNextDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtNextDate.Name = "txtNextDate";
            this.txtNextDate.Size = new System.Drawing.Size(78, 13);
            this.txtNextDate.TabIndex = 4;
            this.txtNextDate.Text = "Next Due Date";
            // 
            // txtAnimalId
            // 
            this.txtAnimalId.Location = new System.Drawing.Point(80, 10);
            this.txtAnimalId.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtAnimalId.Name = "txtAnimalId";
            this.txtAnimalId.Size = new System.Drawing.Size(196, 20);
            this.txtAnimalId.TabIndex = 5;
            // 
            // dgVaccineTable
            // 
            this.dgVaccineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccineTable.Location = new System.Drawing.Point(15, 60);
            this.dgVaccineTable.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgVaccineTable.MultiSelect = false;
            this.dgVaccineTable.Name = "dgVaccineTable";
            this.dgVaccineTable.ReadOnly = true;
            this.dgVaccineTable.RowHeadersVisible = false;
            this.dgVaccineTable.RowHeadersWidth = 102;
            this.dgVaccineTable.RowTemplate.Height = 40;
            this.dgVaccineTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVaccineTable.Size = new System.Drawing.Size(421, 134);
            this.dgVaccineTable.TabIndex = 6;
            // 
            // dateGiven
            // 
            this.dateGiven.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGiven.Location = new System.Drawing.Point(113, 205);
            this.dateGiven.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dateGiven.Name = "dateGiven";
            this.dateGiven.Size = new System.Drawing.Size(78, 20);
            this.dateGiven.TabIndex = 7;
            // 
            // dateDue
            // 
            this.dateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDue.Location = new System.Drawing.Point(113, 231);
            this.dateDue.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dateDue.Name = "dateDue";
            this.dateDue.Size = new System.Drawing.Size(78, 20);
            this.dateDue.TabIndex = 8;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(113, 262);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(78, 20);
            this.txtEmpId.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(266, 224);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(74, 32);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorEmpId
            // 
            this.errorEmpId.ContainerControl = this;
            // 
            // personalInfoLabel
            // 
            this.personalInfoLabel.AutoSize = true;
            this.personalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoLabel.Location = new System.Drawing.Point(12, 41);
            this.personalInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.personalInfoLabel.Name = "personalInfoLabel";
            this.personalInfoLabel.Size = new System.Drawing.Size(100, 17);
            this.personalInfoLabel.TabIndex = 29;
            this.personalInfoLabel.Text = "Vaccinations";
            // 
            // AddVaccineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 338);
            this.Controls.Add(this.personalInfoLabel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.dateDue);
            this.Controls.Add(this.dateGiven);
            this.Controls.Add(this.dgVaccineTable);
            this.Controls.Add(this.txtAnimalId);
            this.Controls.Add(this.txtNextDate);
            this.Controls.Add(this.lblDateGiven);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAnimalId);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "AddVaccineForm";
            this.Text = "Vaccination Administration";
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccineTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmpId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimalId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblDateGiven;
        private System.Windows.Forms.Label txtNextDate;
        private System.Windows.Forms.TextBox txtAnimalId;
        private System.Windows.Forms.DataGridView dgVaccineTable;
        private System.Windows.Forms.DateTimePicker dateGiven;
        private System.Windows.Forms.DateTimePicker dateDue;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ErrorProvider errorEmpId;
        private System.Windows.Forms.Label personalInfoLabel;
    }
}