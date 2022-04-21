
namespace FrontEndAnimalShelter
{
    partial class AddAnimalForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxAnimalID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxGender = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxMicrochipID = new System.Windows.Forms.TextBox();
            this.dateTimePickerDueOutDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerIntakeDate = new System.Windows.Forms.DateTimePicker();
            this.txtBxNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBxWeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBxKennel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbBoxSpecies = new System.Windows.Forms.ComboBox();
            this.ckbAltered = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSubmit.Location = new System.Drawing.Point(1074, 697);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(272, 121);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(288, 160);
            this.txtBxName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(260, 38);
            this.txtBxName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Animal ID";
            // 
            // txtBxAnimalID
            // 
            this.txtBxAnimalID.Location = new System.Drawing.Point(288, 71);
            this.txtBxAnimalID.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtBxAnimalID.Name = "txtBxAnimalID";
            this.txtBxAnimalID.Size = new System.Drawing.Size(260, 38);
            this.txtBxAnimalID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender";
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.FormattingEnabled = true;
            this.cmbBoxGender.Items.AddRange(new object[] {
            "Unknown",
            "Male",
            "Female"});
            this.cmbBoxGender.Location = new System.Drawing.Point(288, 245);
            this.cmbBoxGender.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(260, 39);
            this.cmbBoxGender.TabIndex = 3;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(288, 349);
            this.dateTimePickerDateOfBirth.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.ShowUpDown = true;
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(260, 38);
            this.dateTimePickerDateOfBirth.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 453);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Microchip ID";
            // 
            // txtBxMicrochipID
            // 
            this.txtBxMicrochipID.Location = new System.Drawing.Point(288, 446);
            this.txtBxMicrochipID.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtBxMicrochipID.Name = "txtBxMicrochipID";
            this.txtBxMicrochipID.Size = new System.Drawing.Size(260, 38);
            this.txtBxMicrochipID.TabIndex = 5;
            // 
            // dateTimePickerDueOutDate
            // 
            this.dateTimePickerDueOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDueOutDate.Location = new System.Drawing.Point(288, 541);
            this.dateTimePickerDueOutDate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dateTimePickerDueOutDate.Name = "dateTimePickerDueOutDate";
            this.dateTimePickerDueOutDate.ShowUpDown = true;
            this.dateTimePickerDueOutDate.Size = new System.Drawing.Size(260, 38);
            this.dateTimePickerDueOutDate.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 555);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Due Out Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 663);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Arrival Date";
            // 
            // dateTimePickerIntakeDate
            // 
            this.dateTimePickerIntakeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIntakeDate.Location = new System.Drawing.Point(288, 648);
            this.dateTimePickerIntakeDate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dateTimePickerIntakeDate.Name = "dateTimePickerIntakeDate";
            this.dateTimePickerIntakeDate.ShowUpDown = true;
            this.dateTimePickerIntakeDate.Size = new System.Drawing.Size(260, 38);
            this.dateTimePickerIntakeDate.TabIndex = 7;
            // 
            // txtBxNotes
            // 
            this.txtBxNotes.Location = new System.Drawing.Point(288, 739);
            this.txtBxNotes.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtBxNotes.Multiline = true;
            this.txtBxNotes.Name = "txtBxNotes";
            this.txtBxNotes.Size = new System.Drawing.Size(527, 120);
            this.txtBxNotes.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 747);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Notes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(958, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "Weight (lbs)";
            // 
            // txtBxWeight
            // 
            this.txtBxWeight.Location = new System.Drawing.Point(1179, 62);
            this.txtBxWeight.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtBxWeight.Name = "txtBxWeight";
            this.txtBxWeight.Size = new System.Drawing.Size(260, 38);
            this.txtBxWeight.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1020, 177);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 32);
            this.label11.TabIndex = 20;
            this.label11.Text = "Kennel";
            // 
            // txtBxKennel
            // 
            this.txtBxKennel.Location = new System.Drawing.Point(1179, 177);
            this.txtBxKennel.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtBxKennel.Name = "txtBxKennel";
            this.txtBxKennel.Size = new System.Drawing.Size(260, 38);
            this.txtBxKennel.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1006, 315);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 32);
            this.label12.TabIndex = 21;
            this.label12.Text = "Species";
            // 
            // cmbBoxSpecies
            // 
            this.cmbBoxSpecies.FormattingEnabled = true;
            this.cmbBoxSpecies.Location = new System.Drawing.Point(1179, 315);
            this.cmbBoxSpecies.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cmbBoxSpecies.Name = "cmbBoxSpecies";
            this.cmbBoxSpecies.Size = new System.Drawing.Size(260, 39);
            this.cmbBoxSpecies.TabIndex = 23;
            // 
            // ckbAltered
            // 
            this.ckbAltered.AutoSize = true;
            this.ckbAltered.Location = new System.Drawing.Point(1153, 433);
            this.ckbAltered.Name = "ckbAltered";
            this.ckbAltered.Size = new System.Drawing.Size(144, 36);
            this.ckbAltered.TabIndex = 26;
            this.ckbAltered.Text = "Altered";
            this.ckbAltered.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1516, 70);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(173, 57);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 1036);
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.ckbAltered);
            this.Controls.Add(this.cmbBoxSpecies);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBxKennel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBxWeight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBxNotes);
            this.Controls.Add(this.dateTimePickerIntakeDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerDueOutDate);
            this.Controls.Add(this.txtBxMicrochipID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.cmbBoxGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxAnimalID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddAnimalForm";
            this.Text = "S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxAnimalID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoxGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxMicrochipID;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueOutDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerIntakeDate;
        private System.Windows.Forms.TextBox txtBxNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBxWeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBxKennel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbBoxSpecies;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.CheckBox ckbAltered;
        private System.Windows.Forms.Button btnReset;
    }
}

