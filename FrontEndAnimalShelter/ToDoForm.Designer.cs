namespace FrontEndAnimalShelter
{
    partial class ToDoForm
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
            this.headerDate = new System.Windows.Forms.Label();
            this.lblVaccine = new System.Windows.Forms.Label();
            this.dgVaccineToDo = new System.Windows.Forms.DataGridView();
            this.dgMedications = new System.Windows.Forms.DataGridView();
            this.lblMedication = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAnimalID = new System.Windows.Forms.TextBox();
            this.Vacine = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxVaccineID = new System.Windows.Forms.TextBox();
            this.txtBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.btnSubmitVaccine = new System.Windows.Forms.Button();
            this.dateGiven = new System.Windows.Forms.DateTimePicker();
            this.dateNextDateDue = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccineToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedications)).BeginInit();
            this.SuspendLayout();
            // 
            // headerDate
            // 
            this.headerDate.AutoSize = true;
            this.headerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerDate.Location = new System.Drawing.Point(515, 33);
            this.headerDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerDate.Name = "headerDate";
            this.headerDate.Size = new System.Drawing.Size(155, 47);
            this.headerDate.TabIndex = 0;
            this.headerDate.Text = "header";
            // 
            // lblVaccine
            // 
            this.lblVaccine.AutoSize = true;
            this.lblVaccine.Location = new System.Drawing.Point(45, 279);
            this.lblVaccine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVaccine.Name = "lblVaccine";
            this.lblVaccine.Size = new System.Drawing.Size(74, 20);
            this.lblVaccine.TabIndex = 1;
            this.lblVaccine.Text = "Vaccines";
            // 
            // dgVaccineToDo
            // 
            this.dgVaccineToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccineToDo.Location = new System.Drawing.Point(48, 302);
            this.dgVaccineToDo.Margin = new System.Windows.Forms.Padding(2);
            this.dgVaccineToDo.Name = "dgVaccineToDo";
            this.dgVaccineToDo.RowHeadersWidth = 102;
            this.dgVaccineToDo.RowTemplate.Height = 40;
            this.dgVaccineToDo.Size = new System.Drawing.Size(878, 229);
            this.dgVaccineToDo.TabIndex = 2;
            // 
            // dgMedications
            // 
            this.dgMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedications.Location = new System.Drawing.Point(48, 601);
            this.dgMedications.Margin = new System.Windows.Forms.Padding(2);
            this.dgMedications.Name = "dgMedications";
            this.dgMedications.RowHeadersWidth = 102;
            this.dgMedications.RowTemplate.Height = 40;
            this.dgMedications.Size = new System.Drawing.Size(878, 229);
            this.dgMedications.TabIndex = 4;
            // 
            // lblMedication
            // 
            this.lblMedication.AutoSize = true;
            this.lblMedication.Location = new System.Drawing.Point(45, 578);
            this.lblMedication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedication.Name = "lblMedication";
            this.lblMedication.Size = new System.Drawing.Size(94, 20);
            this.lblMedication.TabIndex = 3;
            this.lblMedication.Text = "Medications";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Animal ID";
            // 
            // txtBoxAnimalID
            // 
            this.txtBoxAnimalID.Location = new System.Drawing.Point(168, 111);
            this.txtBoxAnimalID.Name = "txtBoxAnimalID";
            this.txtBoxAnimalID.Size = new System.Drawing.Size(168, 26);
            this.txtBoxAnimalID.TabIndex = 6;
            // 
            // Vacine
            // 
            this.Vacine.AutoSize = true;
            this.Vacine.Location = new System.Drawing.Point(78, 154);
            this.Vacine.Name = "Vacine";
            this.Vacine.Size = new System.Drawing.Size(66, 20);
            this.Vacine.TabIndex = 7;
            this.Vacine.Text = "Vaccine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date Given";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Next Date Due";
            // 
            // txtBoxVaccineID
            // 
            this.txtBoxVaccineID.Location = new System.Drawing.Point(168, 152);
            this.txtBoxVaccineID.Name = "txtBoxVaccineID";
            this.txtBoxVaccineID.Size = new System.Drawing.Size(168, 26);
            this.txtBoxVaccineID.TabIndex = 11;
            // 
            // txtBoxEmployeeID
            // 
            this.txtBoxEmployeeID.Location = new System.Drawing.Point(168, 197);
            this.txtBoxEmployeeID.Name = "txtBoxEmployeeID";
            this.txtBoxEmployeeID.Size = new System.Drawing.Size(168, 26);
            this.txtBoxEmployeeID.TabIndex = 12;
            // 
            // btnSubmitVaccine
            // 
            this.btnSubmitVaccine.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSubmitVaccine.ForeColor = System.Drawing.Color.White;
            this.btnSubmitVaccine.Location = new System.Drawing.Point(753, 226);
            this.btnSubmitVaccine.Name = "btnSubmitVaccine";
            this.btnSubmitVaccine.Size = new System.Drawing.Size(173, 54);
            this.btnSubmitVaccine.TabIndex = 13;
            this.btnSubmitVaccine.Text = "Submit Vaccine";
            this.btnSubmitVaccine.UseVisualStyleBackColor = false;
            this.btnSubmitVaccine.Click += new System.EventHandler(this.btnSubmitVaccine_Click);
            // 
            // dateGiven
            // 
            this.dateGiven.Location = new System.Drawing.Point(501, 152);
            this.dateGiven.Name = "dateGiven";
            this.dateGiven.Size = new System.Drawing.Size(282, 26);
            this.dateGiven.TabIndex = 14;
            // 
            // dateNextDateDue
            // 
            this.dateNextDateDue.Location = new System.Drawing.Point(501, 108);
            this.dateNextDateDue.Name = "dateNextDateDue";
            this.dateNextDateDue.Size = new System.Drawing.Size(300, 26);
            this.dateNextDateDue.TabIndex = 15;
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 848);
            this.Controls.Add(this.dateNextDateDue);
            this.Controls.Add(this.dateGiven);
            this.Controls.Add(this.btnSubmitVaccine);
            this.Controls.Add(this.txtBoxEmployeeID);
            this.Controls.Add(this.txtBoxVaccineID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Vacine);
            this.Controls.Add(this.txtBoxAnimalID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMedications);
            this.Controls.Add(this.lblMedication);
            this.Controls.Add(this.dgVaccineToDo);
            this.Controls.Add(this.lblVaccine);
            this.Controls.Add(this.headerDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ToDoForm";
            this.Text = "ToDoForm";
            this.Load += new System.EventHandler(this.ToDoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccineToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerDate;
        private System.Windows.Forms.Label lblVaccine;
        private System.Windows.Forms.DataGridView dgVaccineToDo;
        private System.Windows.Forms.DataGridView dgMedications;
        private System.Windows.Forms.Label lblMedication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxAnimalID;
        private System.Windows.Forms.Label Vacine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxVaccineID;
        private System.Windows.Forms.TextBox txtBoxEmployeeID;
        private System.Windows.Forms.Button btnSubmitVaccine;
        private System.Windows.Forms.DateTimePicker dateGiven;
        private System.Windows.Forms.DateTimePicker dateNextDateDue;
    }
}