
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
            this.label12 = new System.Windows.Forms.Label();
            this.cmbBoxSpecies = new System.Windows.Forms.ComboBox();
            this.ckbAltered = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.personalInfoLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.additionalInfoLabel = new System.Windows.Forms.Label();
            this.cmbKennel = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbBreed = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.ckbAdopted = new System.Windows.Forms.CheckBox();
            this.ckbActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(75, 631);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(343, 76);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(144, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(249, 215);
            this.txtBxName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(260, 38);
            this.txtBxName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(96, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Animal ID";
            // 
            // txtBxAnimalID
            // 
            this.txtBxAnimalID.Location = new System.Drawing.Point(249, 136);
            this.txtBxAnimalID.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtBxAnimalID.Name = "txtBxAnimalID";
            this.txtBxAnimalID.Size = new System.Drawing.Size(260, 38);
            this.txtBxAnimalID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(729, 225);
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
            this.cmbBoxGender.Location = new System.Drawing.Point(855, 225);
            this.cmbBoxGender.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(260, 39);
            this.cmbBoxGender.TabIndex = 3;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(249, 304);
            this.dateTimePickerDateOfBirth.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.ShowUpDown = true;
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(260, 38);
            this.dateTimePickerDateOfBirth.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(59, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(68, 484);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Microchip ID";
            // 
            // txtBxMicrochipID
            // 
            this.txtBxMicrochipID.Location = new System.Drawing.Point(249, 484);
            this.txtBxMicrochipID.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtBxMicrochipID.Name = "txtBxMicrochipID";
            this.txtBxMicrochipID.Size = new System.Drawing.Size(260, 38);
            this.txtBxMicrochipID.TabIndex = 5;
            // 
            // dateTimePickerDueOutDate
            // 
            this.dateTimePickerDueOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDueOutDate.Location = new System.Drawing.Point(1490, 149);
            this.dateTimePickerDueOutDate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dateTimePickerDueOutDate.Name = "dateTimePickerDueOutDate";
            this.dateTimePickerDueOutDate.ShowUpDown = true;
            this.dateTimePickerDueOutDate.Size = new System.Drawing.Size(260, 38);
            this.dateTimePickerDueOutDate.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(1284, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Due Out Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(1314, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Arrival Date";
            // 
            // dateTimePickerIntakeDate
            // 
            this.dateTimePickerIntakeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIntakeDate.Location = new System.Drawing.Point(1490, 228);
            this.dateTimePickerIntakeDate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dateTimePickerIntakeDate.Name = "dateTimePickerIntakeDate";
            this.dateTimePickerIntakeDate.ShowUpDown = true;
            this.dateTimePickerIntakeDate.Size = new System.Drawing.Size(260, 38);
            this.dateTimePickerIntakeDate.TabIndex = 7;
            // 
            // txtBxNotes
            // 
            this.txtBxNotes.Location = new System.Drawing.Point(1490, 421);
            this.txtBxNotes.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtBxNotes.Multiline = true;
            this.txtBxNotes.Name = "txtBxNotes";
            this.txtBxNotes.Size = new System.Drawing.Size(530, 224);
            this.txtBxNotes.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(1335, 429);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Notes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(676, 442);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "Weight (lbs)";
            // 
            // txtBxWeight
            // 
            this.txtBxWeight.Location = new System.Drawing.Point(855, 442);
            this.txtBxWeight.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtBxWeight.Name = "txtBxWeight";
            this.txtBxWeight.Size = new System.Drawing.Size(260, 38);
            this.txtBxWeight.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(132, 389);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 32);
            this.label11.TabIndex = 20;
            this.label11.Text = "Kennel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(724, 146);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 32);
            this.label12.TabIndex = 21;
            this.label12.Text = "Species";
            // 
            // cmbBoxSpecies
            // 
            this.cmbBoxSpecies.FormattingEnabled = true;
            this.cmbBoxSpecies.Location = new System.Drawing.Point(855, 146);
            this.cmbBoxSpecies.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cmbBoxSpecies.Name = "cmbBoxSpecies";
            this.cmbBoxSpecies.Size = new System.Drawing.Size(260, 39);
            this.cmbBoxSpecies.TabIndex = 23;
            // 
            // ckbAltered
            // 
            this.ckbAltered.AutoSize = true;
            this.ckbAltered.Location = new System.Drawing.Point(971, 520);
            this.ckbAltered.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbAltered.Name = "ckbAltered";
            this.ckbAltered.Size = new System.Drawing.Size(144, 36);
            this.ckbAltered.TabIndex = 26;
            this.ckbAltered.Text = "Altered";
            this.ckbAltered.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(457, 640);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(172, 57);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // personalInfoLabel
            // 
            this.personalInfoLabel.AutoSize = true;
            this.personalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoLabel.Location = new System.Drawing.Point(59, 60);
            this.personalInfoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.personalInfoLabel.Name = "personalInfoLabel";
            this.personalInfoLabel.Size = new System.Drawing.Size(351, 39);
            this.personalInfoLabel.TabIndex = 28;
            this.personalInfoLabel.Text = "Personal Information";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(724, 70);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(199, 39);
            this.descriptionLabel.TabIndex = 29;
            this.descriptionLabel.Text = "Description";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(748, 301);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(91, 32);
            this.lblBreed.TabIndex = 30;
            this.lblBreed.Text = "Breed";
            // 
            // additionalInfoLabel
            // 
            this.additionalInfoLabel.AutoSize = true;
            this.additionalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalInfoLabel.Location = new System.Drawing.Point(1284, 73);
            this.additionalInfoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.additionalInfoLabel.Name = "additionalInfoLabel";
            this.additionalInfoLabel.Size = new System.Drawing.Size(369, 39);
            this.additionalInfoLabel.TabIndex = 31;
            this.additionalInfoLabel.Text = "Additional Information";
            // 
            // cmbKennel
            // 
            this.cmbKennel.FormattingEnabled = true;
            this.cmbKennel.Location = new System.Drawing.Point(249, 389);
            this.cmbKennel.Name = "cmbKennel";
            this.cmbKennel.Size = new System.Drawing.Size(260, 39);
            this.cmbKennel.TabIndex = 32;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblColor.Location = new System.Drawing.Point(756, 371);
            this.lblColor.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(83, 32);
            this.lblColor.TabIndex = 34;
            this.lblColor.Text = "Color";
            // 
            // cmbBreed
            // 
            this.cmbBreed.FormattingEnabled = true;
            this.cmbBreed.Location = new System.Drawing.Point(855, 301);
            this.cmbBreed.Name = "cmbBreed";
            this.cmbBreed.Size = new System.Drawing.Size(260, 39);
            this.cmbBreed.TabIndex = 35;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(855, 371);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(260, 39);
            this.cmbColor.TabIndex = 36;
            // 
            // ckbAdopted
            // 
            this.ckbAdopted.AutoSize = true;
            this.ckbAdopted.Location = new System.Drawing.Point(1490, 297);
            this.ckbAdopted.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbAdopted.Name = "ckbAdopted";
            this.ckbAdopted.Size = new System.Drawing.Size(160, 36);
            this.ckbAdopted.TabIndex = 37;
            this.ckbAdopted.Text = "Adopted";
            this.ckbAdopted.UseVisualStyleBackColor = true;
            // 
            // ckbActive
            // 
            this.ckbActive.AutoSize = true;
            this.ckbActive.Location = new System.Drawing.Point(1490, 364);
            this.ckbActive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbActive.Name = "ckbActive";
            this.ckbActive.Size = new System.Drawing.Size(131, 36);
            this.ckbActive.TabIndex = 38;
            this.ckbActive.Text = "Active";
            this.ckbActive.UseVisualStyleBackColor = true;
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2027, 1035);
            this.ControlBox = false;
            this.Controls.Add(this.ckbActive);
            this.Controls.Add(this.ckbAdopted);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbBreed);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbKennel);
            this.Controls.Add(this.additionalInfoLabel);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.personalInfoLabel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.ckbAltered);
            this.Controls.Add(this.cmbBoxSpecies);
            this.Controls.Add(this.label12);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbBoxSpecies;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.CheckBox ckbAltered;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label personalInfoLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label additionalInfoLabel;
        private System.Windows.Forms.ComboBox cmbKennel;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbBreed;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.CheckBox ckbAdopted;
        private System.Windows.Forms.CheckBox ckbActive;
    }
}

