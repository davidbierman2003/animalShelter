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
            this.animalFilterBox = new System.Windows.Forms.GroupBox();
            this.additionalInfoLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.personalInfoLabel = new System.Windows.Forms.Label();
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
            this.gpAddTreatment = new System.Windows.Forms.GroupBox();
            this.btnAdminMeds = new System.Windows.Forms.Button();
            this.btnVaccine = new System.Windows.Forms.Button();
            this.btnPerscription = new System.Windows.Forms.Button();
            this.cmbKennel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimalTable)).BeginInit();
            this.animalFilterBox.SuspendLayout();
            this.gpAddTreatment.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAnimalTable
            // 
            this.dgAnimalTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAnimalTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAnimalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnimalTable.Location = new System.Drawing.Point(13, 616);
            this.dgAnimalTable.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            this.dgAnimalTable.Name = "dgAnimalTable";
            this.dgAnimalTable.RowHeadersWidth = 102;
            this.dgAnimalTable.RowTemplate.Height = 40;
            this.dgAnimalTable.Size = new System.Drawing.Size(1524, 414);
            this.dgAnimalTable.TabIndex = 0;
            this.dgAnimalTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAnimalTable_CellContentClick);
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Location = new System.Drawing.Point(781, 124);
            this.cmbSpecies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(232, 39);
            this.cmbSpecies.TabIndex = 1;
            // 
            // animalFilterBox
            // 
            this.animalFilterBox.Controls.Add(this.cmbKennel);
            this.animalFilterBox.Controls.Add(this.additionalInfoLabel);
            this.animalFilterBox.Controls.Add(this.descriptionLabel);
            this.animalFilterBox.Controls.Add(this.personalInfoLabel);
            this.animalFilterBox.Controls.Add(this.txtAnimlId);
            this.animalFilterBox.Controls.Add(this.lblAnimalID);
            this.animalFilterBox.Controls.Add(this.cmbDueOut);
            this.animalFilterBox.Controls.Add(this.cmbIntake);
            this.animalFilterBox.Controls.Add(this.cmbBirthdate);
            this.animalFilterBox.Controls.Add(this.cmbWeight);
            this.animalFilterBox.Controls.Add(this.dtpBirthdate);
            this.animalFilterBox.Controls.Add(this.lblBirthdate);
            this.animalFilterBox.Controls.Add(this.txtWeight);
            this.animalFilterBox.Controls.Add(this.lblWeight);
            this.animalFilterBox.Controls.Add(this.dtpDueOutDate);
            this.animalFilterBox.Controls.Add(this.lblDueOut);
            this.animalFilterBox.Controls.Add(this.dtpIntakeDate);
            this.animalFilterBox.Controls.Add(this.lblIntake);
            this.animalFilterBox.Controls.Add(this.lblKennel);
            this.animalFilterBox.Controls.Add(this.btnSearch);
            this.animalFilterBox.Controls.Add(this.txtMicrochipId);
            this.animalFilterBox.Controls.Add(this.lblMicrochipId);
            this.animalFilterBox.Controls.Add(this.lblColor);
            this.animalFilterBox.Controls.Add(this.lbxColor);
            this.animalFilterBox.Controls.Add(this.lblBreed);
            this.animalFilterBox.Controls.Add(this.lbxBreed);
            this.animalFilterBox.Controls.Add(this.lblSex);
            this.animalFilterBox.Controls.Add(this.cmbSex);
            this.animalFilterBox.Controls.Add(this.lblSpecies);
            this.animalFilterBox.Controls.Add(this.cmbSpecies);
            this.animalFilterBox.Location = new System.Drawing.Point(0, 0);
            this.animalFilterBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            this.animalFilterBox.Name = "animalFilterBox";
            this.animalFilterBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.animalFilterBox.Size = new System.Drawing.Size(1764, 596);
            this.animalFilterBox.TabIndex = 2;
            this.animalFilterBox.TabStop = false;
            this.animalFilterBox.Text = "Filter Animals";
            // 
            // additionalInfoLabel
            // 
            this.additionalInfoLabel.AutoSize = true;
            this.additionalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalInfoLabel.Location = new System.Drawing.Point(62, 363);
            this.additionalInfoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.additionalInfoLabel.Name = "additionalInfoLabel";
            this.additionalInfoLabel.Size = new System.Drawing.Size(369, 39);
            this.additionalInfoLabel.TabIndex = 34;
            this.additionalInfoLabel.Text = "Additional Information";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(597, 59);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(199, 39);
            this.descriptionLabel.TabIndex = 33;
            this.descriptionLabel.Text = "Description";
            // 
            // personalInfoLabel
            // 
            this.personalInfoLabel.AutoSize = true;
            this.personalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoLabel.Location = new System.Drawing.Point(62, 59);
            this.personalInfoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.personalInfoLabel.Name = "personalInfoLabel";
            this.personalInfoLabel.Size = new System.Drawing.Size(351, 39);
            this.personalInfoLabel.TabIndex = 32;
            this.personalInfoLabel.Text = "Personal Information";
            // 
            // txtAnimlId
            // 
            this.txtAnimlId.Location = new System.Drawing.Point(281, 124);
            this.txtAnimlId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnimlId.Name = "txtAnimlId";
            this.txtAnimlId.Size = new System.Drawing.Size(232, 38);
            this.txtAnimlId.TabIndex = 27;
            // 
            // lblAnimalID
            // 
            this.lblAnimalID.AutoSize = true;
            this.lblAnimalID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAnimalID.Location = new System.Drawing.Point(105, 124);
            this.lblAnimalID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimalID.Name = "lblAnimalID";
            this.lblAnimalID.Size = new System.Drawing.Size(137, 32);
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
            this.cmbDueOut.Location = new System.Drawing.Point(284, 540);
            this.cmbDueOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDueOut.Name = "cmbDueOut";
            this.cmbDueOut.Size = new System.Drawing.Size(75, 39);
            this.cmbDueOut.TabIndex = 25;
            // 
            // cmbIntake
            // 
            this.cmbIntake.FormattingEnabled = true;
            this.cmbIntake.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cmbIntake.Location = new System.Drawing.Point(284, 481);
            this.cmbIntake.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbIntake.Name = "cmbIntake";
            this.cmbIntake.Size = new System.Drawing.Size(75, 39);
            this.cmbIntake.TabIndex = 24;
            // 
            // cmbBirthdate
            // 
            this.cmbBirthdate.FormattingEnabled = true;
            this.cmbBirthdate.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cmbBirthdate.Location = new System.Drawing.Point(284, 419);
            this.cmbBirthdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbBirthdate.Name = "cmbBirthdate";
            this.cmbBirthdate.Size = new System.Drawing.Size(75, 39);
            this.cmbBirthdate.TabIndex = 23;
            // 
            // cmbWeight
            // 
            this.cmbWeight.FormattingEnabled = true;
            this.cmbWeight.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cmbWeight.Location = new System.Drawing.Point(788, 279);
            this.cmbWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbWeight.Name = "cmbWeight";
            this.cmbWeight.Size = new System.Drawing.Size(75, 39);
            this.cmbWeight.TabIndex = 22;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(366, 419);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(230, 38);
            this.dtpBirthdate.TabIndex = 21;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBirthdate.Location = new System.Drawing.Point(124, 419);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(130, 32);
            this.lblBirthdate.TabIndex = 20;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(869, 279);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(230, 38);
            this.txtWeight.TabIndex = 19;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWeight.Location = new System.Drawing.Point(592, 279);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(166, 32);
            this.lblWeight.TabIndex = 18;
            this.lblWeight.Text = "Weight (lbs)";
            // 
            // dtpDueOutDate
            // 
            this.dtpDueOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueOutDate.Location = new System.Drawing.Point(366, 540);
            this.dtpDueOutDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDueOutDate.Name = "dtpDueOutDate";
            this.dtpDueOutDate.Size = new System.Drawing.Size(230, 38);
            this.dtpDueOutDate.TabIndex = 17;
            // 
            // lblDueOut
            // 
            this.lblDueOut.AutoSize = true;
            this.lblDueOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDueOut.Location = new System.Drawing.Point(64, 540);
            this.lblDueOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueOut.Name = "lblDueOut";
            this.lblDueOut.Size = new System.Drawing.Size(187, 32);
            this.lblDueOut.TabIndex = 16;
            this.lblDueOut.Text = "Due Out Date";
            // 
            // dtpIntakeDate
            // 
            this.dtpIntakeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIntakeDate.Location = new System.Drawing.Point(366, 481);
            this.dtpIntakeDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpIntakeDate.Name = "dtpIntakeDate";
            this.dtpIntakeDate.Size = new System.Drawing.Size(230, 38);
            this.dtpIntakeDate.TabIndex = 15;
            // 
            // lblIntake
            // 
            this.lblIntake.AutoSize = true;
            this.lblIntake.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIntake.Location = new System.Drawing.Point(91, 481);
            this.lblIntake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntake.Name = "lblIntake";
            this.lblIntake.Size = new System.Drawing.Size(159, 32);
            this.lblIntake.TabIndex = 14;
            this.lblIntake.Text = "Intake Date";
            // 
            // lblKennel
            // 
            this.lblKennel.AutoSize = true;
            this.lblKennel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblKennel.Location = new System.Drawing.Point(149, 279);
            this.lblKennel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKennel.Name = "lblKennel";
            this.lblKennel.Size = new System.Drawing.Size(105, 32);
            this.lblKennel.TabIndex = 12;
            this.lblKennel.Text = "Kennel";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1289, 522);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(334, 70);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Filter";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMicrochipId
            // 
            this.txtMicrochipId.Location = new System.Drawing.Point(283, 198);
            this.txtMicrochipId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMicrochipId.Name = "txtMicrochipId";
            this.txtMicrochipId.Size = new System.Drawing.Size(230, 38);
            this.txtMicrochipId.TabIndex = 9;
            // 
            // lblMicrochipId
            // 
            this.lblMicrochipId.AutoSize = true;
            this.lblMicrochipId.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMicrochipId.Location = new System.Drawing.Point(76, 198);
            this.lblMicrochipId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMicrochipId.Name = "lblMicrochipId";
            this.lblMicrochipId.Size = new System.Drawing.Size(171, 32);
            this.lblMicrochipId.TabIndex = 8;
            this.lblMicrochipId.Text = "Microchip ID";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblColor.Location = new System.Drawing.Point(1177, 279);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(83, 32);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color";
            // 
            // lbxColor
            // 
            this.lbxColor.FormattingEnabled = true;
            this.lbxColor.ItemHeight = 31;
            this.lbxColor.Location = new System.Drawing.Point(1289, 279);
            this.lbxColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxColor.Name = "lbxColor";
            this.lbxColor.Size = new System.Drawing.Size(456, 128);
            this.lbxColor.TabIndex = 6;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBreed.Location = new System.Drawing.Point(1163, 124);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(91, 32);
            this.lblBreed.TabIndex = 5;
            this.lblBreed.Text = "Breed";
            // 
            // lbxBreed
            // 
            this.lbxBreed.FormattingEnabled = true;
            this.lbxBreed.ItemHeight = 31;
            this.lbxBreed.Location = new System.Drawing.Point(1289, 124);
            this.lbxBreed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxBreed.Name = "lbxBreed";
            this.lbxBreed.Size = new System.Drawing.Size(456, 128);
            this.lbxBreed.TabIndex = 4;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSex.Location = new System.Drawing.Point(690, 198);
            this.lblSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(64, 32);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "Sex";
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unknown"});
            this.cmbSex.Location = new System.Drawing.Point(788, 198);
            this.cmbSex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(232, 39);
            this.cmbSex.TabIndex = 3;
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSpecies.Location = new System.Drawing.Point(636, 124);
            this.lblSpecies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(117, 32);
            this.lblSpecies.TabIndex = 0;
            this.lblSpecies.Text = "Species";
            // 
            // gpAddTreatment
            // 
            this.gpAddTreatment.Controls.Add(this.btnAdminMeds);
            this.gpAddTreatment.Controls.Add(this.btnVaccine);
            this.gpAddTreatment.Controls.Add(this.btnPerscription);
            this.gpAddTreatment.Location = new System.Drawing.Point(1785, 12);
            this.gpAddTreatment.Name = "gpAddTreatment";
            this.gpAddTreatment.Size = new System.Drawing.Size(296, 584);
            this.gpAddTreatment.TabIndex = 3;
            this.gpAddTreatment.TabStop = false;
            this.gpAddTreatment.Text = "Add Treatment";
            // 
            // btnAdminMeds
            // 
            this.btnAdminMeds.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAdminMeds.ForeColor = System.Drawing.Color.White;
            this.btnAdminMeds.Location = new System.Drawing.Point(21, 235);
            this.btnAdminMeds.Name = "btnAdminMeds";
            this.btnAdminMeds.Size = new System.Drawing.Size(230, 100);
            this.btnAdminMeds.TabIndex = 2;
            this.btnAdminMeds.Text = "Existing Medication";
            this.btnAdminMeds.UseVisualStyleBackColor = false;
            this.btnAdminMeds.Click += new System.EventHandler(this.btnAdminMeds_Click);
            // 
            // btnVaccine
            // 
            this.btnVaccine.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVaccine.ForeColor = System.Drawing.Color.White;
            this.btnVaccine.Location = new System.Drawing.Point(21, 404);
            this.btnVaccine.Name = "btnVaccine";
            this.btnVaccine.Size = new System.Drawing.Size(230, 97);
            this.btnVaccine.TabIndex = 1;
            this.btnVaccine.Text = "Vaccine";
            this.btnVaccine.UseVisualStyleBackColor = false;
            this.btnVaccine.Click += new System.EventHandler(this.btnVaccine_Click);
            // 
            // btnPerscription
            // 
            this.btnPerscription.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPerscription.ForeColor = System.Drawing.Color.White;
            this.btnPerscription.Location = new System.Drawing.Point(21, 71);
            this.btnPerscription.Name = "btnPerscription";
            this.btnPerscription.Size = new System.Drawing.Size(230, 104);
            this.btnPerscription.TabIndex = 0;
            this.btnPerscription.Text = "New Medication";
            this.btnPerscription.UseVisualStyleBackColor = false;
            this.btnPerscription.Click += new System.EventHandler(this.btnPerscription_Click);
            // 
            // cmbKennel
            // 
            this.cmbKennel.FormattingEnabled = true;
            this.cmbKennel.Location = new System.Drawing.Point(281, 270);
            this.cmbKennel.Name = "cmbKennel";
            this.cmbKennel.Size = new System.Drawing.Size(232, 39);
            this.cmbKennel.TabIndex = 35;
            // 
            // ViewAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(2101, 1107);
            this.ControlBox = false;
            this.Controls.Add(this.gpAddTreatment);
            this.Controls.Add(this.animalFilterBox);
            this.Controls.Add(this.dgAnimalTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewAnimalForm";
            this.Text = "ViewAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimalTable)).EndInit();
            this.animalFilterBox.ResumeLayout(false);
            this.animalFilterBox.PerformLayout();
            this.gpAddTreatment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAnimalTable;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.GroupBox animalFilterBox;
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
        private System.Windows.Forms.GroupBox gpAddTreatment;
        private System.Windows.Forms.Button btnPerscription;
        private System.Windows.Forms.Button btnVaccine;
        private System.Windows.Forms.Button btnAdminMeds;
        private System.Windows.Forms.ComboBox cmbKennel;
    }
}