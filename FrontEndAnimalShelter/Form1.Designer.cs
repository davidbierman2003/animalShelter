
namespace FrontEndAnimalShelter
{
    partial class Form1
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
            this.btnEquals = new System.Windows.Forms.Button();
            this.cmbBox1 = new System.Windows.Forms.ComboBox();
            this.cmbBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.animal_medicalDataSet = new FrontEndAnimalShelter.animal_medicalDataSet();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new FrontEndAnimalShelter.animal_medicalDataSetTableAdapters.animalTableAdapter();
            this.animalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.microshipidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueoutdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intakedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kennelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal_medicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEquals.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEquals.Location = new System.Drawing.Point(924, 144);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(5);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(156, 60);
            this.btnEquals.TabIndex = 0;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // cmbBox1
            // 
            this.cmbBox1.FormattingEnabled = true;
            this.cmbBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbBox1.Location = new System.Drawing.Point(199, 161);
            this.cmbBox1.Margin = new System.Windows.Forms.Padding(5);
            this.cmbBox1.Name = "cmbBox1";
            this.cmbBox1.Size = new System.Drawing.Size(212, 39);
            this.cmbBox1.TabIndex = 1;
            // 
            // cmbBox2
            // 
            this.cmbBox2.FormattingEnabled = true;
            this.cmbBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbBox2.Location = new System.Drawing.Point(601, 161);
            this.cmbBox2.Margin = new System.Windows.Forms.Padding(5);
            this.cmbBox2.Name = "cmbBox2";
            this.cmbBox2.Size = new System.Drawing.Size(212, 39);
            this.cmbBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hello World";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.microshipidDataGridViewTextBoxColumn,
            this.dueoutdateDataGridViewTextBoxColumn,
            this.intakedateDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.kennelDataGridViewTextBoxColumn,
            this.speciesidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.animalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 392);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1323, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // animal_medicalDataSet
            // 
            this.animal_medicalDataSet.DataSetName = "animal_medicalDataSet";
            this.animal_medicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.animal_medicalDataSet;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // animalidDataGridViewTextBoxColumn
            // 
            this.animalidDataGridViewTextBoxColumn.DataPropertyName = "animal_id";
            this.animalidDataGridViewTextBoxColumn.HeaderText = "animal_id";
            this.animalidDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.animalidDataGridViewTextBoxColumn.Name = "animalidDataGridViewTextBoxColumn";
            this.animalidDataGridViewTextBoxColumn.Width = 250;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 250;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.Width = 250;
            // 
            // microshipidDataGridViewTextBoxColumn
            // 
            this.microshipidDataGridViewTextBoxColumn.DataPropertyName = "microship_id";
            this.microshipidDataGridViewTextBoxColumn.HeaderText = "microship_id";
            this.microshipidDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.microshipidDataGridViewTextBoxColumn.Name = "microshipidDataGridViewTextBoxColumn";
            this.microshipidDataGridViewTextBoxColumn.Width = 250;
            // 
            // dueoutdateDataGridViewTextBoxColumn
            // 
            this.dueoutdateDataGridViewTextBoxColumn.DataPropertyName = "due_out_date";
            this.dueoutdateDataGridViewTextBoxColumn.HeaderText = "due_out_date";
            this.dueoutdateDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.dueoutdateDataGridViewTextBoxColumn.Name = "dueoutdateDataGridViewTextBoxColumn";
            this.dueoutdateDataGridViewTextBoxColumn.Width = 250;
            // 
            // intakedateDataGridViewTextBoxColumn
            // 
            this.intakedateDataGridViewTextBoxColumn.DataPropertyName = "intake_date";
            this.intakedateDataGridViewTextBoxColumn.HeaderText = "intake_date";
            this.intakedateDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.intakedateDataGridViewTextBoxColumn.Name = "intakedateDataGridViewTextBoxColumn";
            this.intakedateDataGridViewTextBoxColumn.Width = 250;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 250;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 250;
            // 
            // kennelDataGridViewTextBoxColumn
            // 
            this.kennelDataGridViewTextBoxColumn.DataPropertyName = "kennel";
            this.kennelDataGridViewTextBoxColumn.HeaderText = "kennel";
            this.kennelDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.kennelDataGridViewTextBoxColumn.Name = "kennelDataGridViewTextBoxColumn";
            this.kennelDataGridViewTextBoxColumn.Width = 250;
            // 
            // speciesidDataGridViewTextBoxColumn
            // 
            this.speciesidDataGridViewTextBoxColumn.DataPropertyName = "species_id";
            this.speciesidDataGridViewTextBoxColumn.HeaderText = "species_id";
            this.speciesidDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.speciesidDataGridViewTextBoxColumn.Name = "speciesidDataGridViewTextBoxColumn";
            this.speciesidDataGridViewTextBoxColumn.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 697);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBox2);
            this.Controls.Add(this.cmbBox1);
            this.Controls.Add(this.btnEquals);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal_medicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.ComboBox cmbBox1;
        private System.Windows.Forms.ComboBox cmbBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private animal_medicalDataSet animal_medicalDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private animal_medicalDataSetTableAdapters.animalTableAdapter animalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn microshipidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueoutdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intakedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kennelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesidDataGridViewTextBoxColumn;
    }
}

