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
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccineTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmpId)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnimalId
            // 
            this.lblAnimalId.AutoSize = true;
            this.lblAnimalId.Location = new System.Drawing.Point(33, 30);
            this.lblAnimalId.Name = "lblAnimalId";
            this.lblAnimalId.Size = new System.Drawing.Size(137, 32);
            this.lblAnimalId.TabIndex = 0;
            this.lblAnimalId.Text = "Animal ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vaccine";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(33, 631);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(176, 32);
            this.lblEmployeeId.TabIndex = 2;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // lblDateGiven
            // 
            this.lblDateGiven.AutoSize = true;
            this.lblDateGiven.Location = new System.Drawing.Point(33, 488);
            this.lblDateGiven.Name = "lblDateGiven";
            this.lblDateGiven.Size = new System.Drawing.Size(157, 32);
            this.lblDateGiven.TabIndex = 3;
            this.lblDateGiven.Text = "Date Given";
            // 
            // txtNextDate
            // 
            this.txtNextDate.AutoSize = true;
            this.txtNextDate.Location = new System.Drawing.Point(33, 556);
            this.txtNextDate.Name = "txtNextDate";
            this.txtNextDate.Size = new System.Drawing.Size(199, 32);
            this.txtNextDate.TabIndex = 4;
            this.txtNextDate.Text = "Next Due Date";
            // 
            // txtAnimalId
            // 
            this.txtAnimalId.Location = new System.Drawing.Point(212, 23);
            this.txtAnimalId.Name = "txtAnimalId";
            this.txtAnimalId.Size = new System.Drawing.Size(516, 38);
            this.txtAnimalId.TabIndex = 5;
            // 
            // dgVaccineTable
            // 
            this.dgVaccineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccineTable.Location = new System.Drawing.Point(39, 142);
            this.dgVaccineTable.MultiSelect = false;
            this.dgVaccineTable.Name = "dgVaccineTable";
            this.dgVaccineTable.ReadOnly = true;
            this.dgVaccineTable.RowHeadersVisible = false;
            this.dgVaccineTable.RowHeadersWidth = 102;
            this.dgVaccineTable.RowTemplate.Height = 40;
            this.dgVaccineTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVaccineTable.Size = new System.Drawing.Size(1123, 320);
            this.dgVaccineTable.TabIndex = 6;
            // 
            // dateGiven
            // 
            this.dateGiven.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGiven.Location = new System.Drawing.Point(302, 488);
            this.dateGiven.Name = "dateGiven";
            this.dateGiven.Size = new System.Drawing.Size(200, 38);
            this.dateGiven.TabIndex = 7;
            // 
            // dateDue
            // 
            this.dateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDue.Location = new System.Drawing.Point(302, 550);
            this.dateDue.Name = "dateDue";
            this.dateDue.Size = new System.Drawing.Size(200, 38);
            this.dateDue.TabIndex = 8;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(302, 624);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(200, 38);
            this.txtEmpId.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(708, 533);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(198, 77);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorEmpId
            // 
            this.errorEmpId.ContainerControl = this;
            // 
            // AddVaccineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 806);
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
    }
}