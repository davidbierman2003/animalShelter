namespace FrontEndAnimalShelter
{
    partial class ViewAnimalForm
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
            this.dgAnimalTable = new System.Windows.Forms.DataGridView();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.animalSearchBox = new System.Windows.Forms.GroupBox();
            this.txtAnimlId = new System.Windows.Forms.TextBox();
            this.lblAnimalID = new System.Windows.Forms.Label();
            this.cmbDueOut = new System.Windows.Forms.ComboBox();
            this.cmbIntake = new System.Windows.Forms.ComboBox();
            this.cmbBirthdate = new System.Windows.Forms.ComboBox();
            this.cmbWeight = new System.Windows.Forms.ComboBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.dtpDueOutDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueOut = new System.Windows.Forms.Label();
            this.dtpIntakeDate = new System.Windows.Forms.DateTimePicker();
            this.lblIntake = new System.Windows.Forms.Label();
            this.txtKennel = new System.Windows.Forms.TextBox();
            this.lblKennel = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMicrochipId = new System.Windows.Forms.TextBox();
            this.lblMicrochipId = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lbxColor = new System.Windows.Forms.ListBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lbxBreed = new System.Windows.Forms.ListBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.additionalInfoLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.personalInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimalTable)).BeginInit();
            this.animalSearchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAnimalTable
            // 
            this.dgAnimalTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgAnimalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnimalTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgAnimalTable.Location = new System.Drawing.Point(0, 358);
            this.dgAnimalTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgAnimalTable.Name = "dgAnimalTable";
            this.dgAnimalTable.RowHeadersWidth = 102;
            this.dgAnimalTable.RowTemplate.Height = 40;
            this.dgAnimalTable.Size = new System.Drawing.Size(1095, 356);
            this.dgAnimalTable.TabIndex = 0;
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Location = new System.Drawing.Point(443, 80);
            this.cmbSpecies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(132, 28);
            this.cmbSpecies.TabIndex = 1;
            // 
            // animalSearchBox
            // 
            this.animalSearchBox.Controls.Add(this.additionalInfoLabel);
            this.animalSearchBox.Controls.Add(this.descriptionLabel);
            this.animalSearchBox.Controls.Add(this.personalInfoLabel);
            this.animalSearchBox.Controls.Add(this.txtAnimlId);
            this.animalSearchBox.Controls.Add(this.lblAnimalID);
            this.animalSearchBox.Controls.Add(this.cmbDueOut);
            this.animalSearchBox.Controls.Add(this.cmbIntake);
            this.animalSearchBox.Controls.Add(this.cmbBirthdate);
            this.animalSearchBox.Controls.Add(this.cmbWeight);
            this.animalSearchBox.Controls.Add(this.dtpBirthdate);
            this.animalSearchBox.Controls.Add(this.lblBirthdate);
            this.animalSearchBox.Controls.Add(this.txtWeight);
            this.animalSearchBox.Controls.Add(this.lblWeight);
            this.animalSearchBox.Controls.Add(this.dtpDueOutDate);
            this.animalSearchBox.Controls.Add(this.lblDueOut);
            this.animalSearchBox.Controls.Add(this.dtpIntakeDate);
            this.animalSearchBox.Controls.Add(this.lblIntake);
            this.animalSearchBox.Controls.Add(this.txtKennel);
            this.animalSearchBox.Controls.Add(this.lblKennel);
            this.animalSearchBox.Controls.Add(this.btnSearch);
            this.animalSearchBox.Controls.Add(this.txtMicrochipId);
            this.animalSearchBox.Controls.Add(this.lblMicrochipId);
            this.animalSearchBox.Controls.Add(this.lblColor);
            this.animalSearchBox.Controls.Add(this.lbxColor);
            this.animalSearchBox.Controls.Add(this.lblBreed);
            this.animalSearchBox.Controls.Add(this.lbxBreed);
            this.animalSearchBox.Controls.Add(this.lblSex);
            this.animalSearchBox.Controls.Add(this.cmbSex);
            this.animalSearchBox.Controls.Add(this.lblSpecies);
            this.animalSearchBox.Controls.Add(this.cmbSpecies);
            this.animalSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.animalSearchBox.Location = new System.Drawing.Point(0, 0);
            this.animalSearchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animalSearchBox.Name = "animalSearchBox";
            this.animalSearchBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animalSearchBox.Size = new System.Drawing.Size(1095, 420);
            this.animalSearchBox.TabIndex = 2;
            this.animalSearchBox.TabStop = false;
            this.animalSearchBox.Text = "Search Animals";
            // 
            // txtAnimlId
            // 
            this.txtAnimlId.Location = new System.Drawing.Point(158, 80);
            this.txtAnimlId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnimlId.Name = "txtAnimlId";
            this.txtAnimlId.Size = new System.Drawing.Size(132, 26);
            this.txtAnimlId.TabIndex = 27;
            // 
            // lblAnimalID
            // 
            this.lblAnimalID.AutoSize = true;
            this.lblAnimalID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAnimalID.Location = new System.Drawing.Point(59, 80);
            this.lblAnimalID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimalID.Name = "lblAnimalID";
            this.lblAnimalID.Size = new System.Drawing.Size(78, 20);
            this.lblAnimalID.TabIndex = 26;
            this.lblAnimalID.Text = "Animal ID";
            // 
            // cmbDueOut
            // 
            this.cmbDueOut.FormattingEnabled = true;
            this.cmbDueOut.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cmbDueOut.Location = new System.Drawing.Point(160, 356);
            this.cmbDueOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDueOut.Name = "cmbDueOut";
            this.cmbDueOut.Size = new System.Drawing.Size(44, 28);
            this.cmbDueOut.TabIndex = 25;
            // 
            // cmbIntake
            // 
            this.cmbIntake.FormattingEnabled = true;
            this.cmbIntake.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cmbIntake.Location = new System.Drawing.Point(160, 318);
            this.cmbIntake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIntake.Name = "cmbIntake";
            this.cmbIntake.Size = new System.Drawing.Size(44, 28);
            this.cmbIntake.TabIndex = 24;
            // 
            // cmbBirthdate
            // 
            this.cmbBirthdate.FormattingEnabled = true;
            this.cmbBirthdate.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cmbBirthdate.Location = new System.Drawing.Point(160, 277);
            this.cmbBirthdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBirthdate.Name = "cmbBirthdate";
            this.cmbBirthdate.Size = new System.Drawing.Size(44, 28);
            this.cmbBirthdate.TabIndex = 23;
            // 
            // cmbWeight
            // 
            this.cmbWeight.FormattingEnabled = true;
            this.cmbWeight.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cmbWeight.Location = new System.Drawing.Point(443, 180);
            this.cmbWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbWeight.Name = "cmbWeight";
            this.cmbWeight.Size = new System.Drawing.Size(44, 28);
            this.cmbWeight.TabIndex = 22;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(206, 277);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(131, 26);
            this.dtpBirthdate.TabIndex = 21;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBirthdate.Location = new System.Drawing.Point(70, 277);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(74, 20);
            this.lblBirthdate.TabIndex = 20;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(489, 180);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(131, 26);
            this.txtWeight.TabIndex = 19;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWeight.Location = new System.Drawing.Point(333, 180);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(93, 20);
            this.lblWeight.TabIndex = 18;
            this.lblWeight.Text = "Weight (lbs)";
            // 
            // dtpDueOutDate
            // 
            this.dtpDueOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueOutDate.Location = new System.Drawing.Point(206, 356);
            this.dtpDueOutDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDueOutDate.Name = "dtpDueOutDate";
            this.dtpDueOutDate.Size = new System.Drawing.Size(131, 26);
            this.dtpDueOutDate.TabIndex = 17;
            // 
            // lblDueOut
            // 
            this.lblDueOut.AutoSize = true;
            this.lblDueOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDueOut.Location = new System.Drawing.Point(36, 356);
            this.lblDueOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDueOut.Name = "lblDueOut";
            this.lblDueOut.Size = new System.Drawing.Size(108, 20);
            this.lblDueOut.TabIndex = 16;
            this.lblDueOut.Text = "Due Out Date";
            // 
            // dtpIntakeDate
            // 
            this.dtpIntakeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIntakeDate.Location = new System.Drawing.Point(206, 318);
            this.dtpIntakeDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpIntakeDate.Name = "dtpIntakeDate";
            this.dtpIntakeDate.Size = new System.Drawing.Size(131, 26);
            this.dtpIntakeDate.TabIndex = 15;
            // 
            // lblIntake
            // 
            this.lblIntake.AutoSize = true;
            this.lblIntake.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIntake.Location = new System.Drawing.Point(51, 318);
            this.lblIntake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntake.Name = "lblIntake";
            this.lblIntake.Size = new System.Drawing.Size(93, 20);
            this.lblIntake.TabIndex = 14;
            this.lblIntake.Text = "Intake Date";
            // 
            // txtKennel
            // 
            this.txtKennel.Location = new System.Drawing.Point(160, 180);
            this.txtKennel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKennel.Name = "txtKennel";
            this.txtKennel.Size = new System.Drawing.Size(131, 26);
            this.txtKennel.TabIndex = 13;
            // 
            // lblKennel
            // 
            this.lblKennel.AutoSize = true;
            this.lblKennel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblKennel.Location = new System.Drawing.Point(84, 180);
            this.lblKennel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKennel.Name = "lblKennel";
            this.lblKennel.Size = new System.Drawing.Size(58, 20);
            this.lblKennel.TabIndex = 12;
            this.lblKennel.Text = "Kennel";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(725, 337);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(188, 45);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMicrochipId
            // 
            this.txtMicrochipId.Location = new System.Drawing.Point(159, 128);
            this.txtMicrochipId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMicrochipId.Name = "txtMicrochipId";
            this.txtMicrochipId.Size = new System.Drawing.Size(131, 26);
            this.txtMicrochipId.TabIndex = 9;
            // 
            // lblMicrochipId
            // 
            this.lblMicrochipId.AutoSize = true;
            this.lblMicrochipId.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMicrochipId.Location = new System.Drawing.Point(43, 128);
            this.lblMicrochipId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMicrochipId.Name = "lblMicrochipId";
            this.lblMicrochipId.Size = new System.Drawing.Size(97, 20);
            this.lblMicrochipId.TabIndex = 8;
            this.lblMicrochipId.Text = "Microchip ID";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblColor.Location = new System.Drawing.Point(662, 180);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(46, 20);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color";
            // 
            // lbxColor
            // 
            this.lbxColor.FormattingEnabled = true;
            this.lbxColor.ItemHeight = 20;
            this.lbxColor.Location = new System.Drawing.Point(725, 180);
            this.lbxColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxColor.Name = "lbxColor";
            this.lbxColor.Size = new System.Drawing.Size(258, 84);
            this.lbxColor.TabIndex = 6;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBreed.Location = new System.Drawing.Point(654, 80);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(52, 20);
            this.lblBreed.TabIndex = 5;
            this.lblBreed.Text = "Breed";
            // 
            // lbxBreed
            // 
            this.lbxBreed.FormattingEnabled = true;
            this.lbxBreed.ItemHeight = 20;
            this.lbxBreed.Location = new System.Drawing.Point(725, 80);
            this.lbxBreed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxBreed.Name = "lbxBreed";
            this.lbxBreed.Size = new System.Drawing.Size(258, 84);
            this.lbxBreed.TabIndex = 4;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSex.Location = new System.Drawing.Point(388, 128);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(36, 20);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "Sex";
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(443, 128);
            this.cmbSex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(132, 28);
            this.cmbSex.TabIndex = 3;
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSpecies.Location = new System.Drawing.Point(358, 80);
            this.lblSpecies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(66, 20);
            this.lblSpecies.TabIndex = 0;
            this.lblSpecies.Text = "Species";
            // 
            // additionalInfoLabel
            // 
            this.additionalInfoLabel.AutoSize = true;
            this.additionalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalInfoLabel.Location = new System.Drawing.Point(35, 234);
            this.additionalInfoLabel.Name = "additionalInfoLabel";
            this.additionalInfoLabel.Size = new System.Drawing.Size(221, 25);
            this.additionalInfoLabel.TabIndex = 34;
            this.additionalInfoLabel.Text = "Additional Information";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(336, 38);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(120, 25);
            this.descriptionLabel.TabIndex = 33;
            this.descriptionLabel.Text = "Description";
            // 
            // personalInfoLabel
            // 
            this.personalInfoLabel.AutoSize = true;
            this.personalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoLabel.Location = new System.Drawing.Point(35, 38);
            this.personalInfoLabel.Name = "personalInfoLabel";
            this.personalInfoLabel.Size = new System.Drawing.Size(210, 25);
            this.personalInfoLabel.TabIndex = 32;
            this.personalInfoLabel.Text = "Personal Information";
            // 
            // ViewAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1095, 714);
            this.ControlBox = false;
            this.Controls.Add(this.animalSearchBox);
            this.Controls.Add(this.dgAnimalTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewAnimalForm";
            this.Text = "ViewAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimalTable)).EndInit();
            this.animalSearchBox.ResumeLayout(false);
            this.animalSearchBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAnimalTable;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.GroupBox animalSearchBox;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ListBox lbxColor;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.ListBox lbxBreed;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TextBox txtMicrochipId;
        private System.Windows.Forms.Label lblMicrochipId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDueOutDate;
        private System.Windows.Forms.Label lblDueOut;
        private System.Windows.Forms.DateTimePicker dtpIntakeDate;
        private System.Windows.Forms.Label lblIntake;
        private System.Windows.Forms.TextBox txtKennel;
        private System.Windows.Forms.Label lblKennel;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.ComboBox cmbWeight;
        private System.Windows.Forms.ComboBox cmbDueOut;
        private System.Windows.Forms.ComboBox cmbIntake;
        private System.Windows.Forms.ComboBox cmbBirthdate;
        private System.Windows.Forms.TextBox txtAnimlId;
        private System.Windows.Forms.Label lblAnimalID;
        private System.Windows.Forms.Label additionalInfoLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label personalInfoLabel;
    }
}