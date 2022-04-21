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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMedication = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccineToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerDate
            // 
            this.headerDate.AutoSize = true;
            this.headerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerDate.Location = new System.Drawing.Point(916, 87);
            this.headerDate.Name = "headerDate";
            this.headerDate.Size = new System.Drawing.Size(252, 78);
            this.headerDate.TabIndex = 0;
            this.headerDate.Text = "header";
            // 
            // lblVaccine
            // 
            this.lblVaccine.AutoSize = true;
            this.lblVaccine.Location = new System.Drawing.Point(51, 271);
            this.lblVaccine.Name = "lblVaccine";
            this.lblVaccine.Size = new System.Drawing.Size(131, 32);
            this.lblVaccine.TabIndex = 1;
            this.lblVaccine.Text = "Vaccines";
            // 
            // dgVaccineToDo
            // 
            this.dgVaccineToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccineToDo.Location = new System.Drawing.Point(57, 307);
            this.dgVaccineToDo.Name = "dgVaccineToDo";
            this.dgVaccineToDo.RowHeadersWidth = 102;
            this.dgVaccineToDo.RowTemplate.Height = 40;
            this.dgVaccineToDo.Size = new System.Drawing.Size(1561, 355);
            this.dgVaccineToDo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 770);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1561, 355);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblMedication
            // 
            this.lblMedication.AutoSize = true;
            this.lblMedication.Location = new System.Drawing.Point(51, 734);
            this.lblMedication.Name = "lblMedication";
            this.lblMedication.Size = new System.Drawing.Size(168, 32);
            this.lblMedication.TabIndex = 3;
            this.lblMedication.Text = "Medications";
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1282);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblMedication);
            this.Controls.Add(this.dgVaccineToDo);
            this.Controls.Add(this.lblVaccine);
            this.Controls.Add(this.headerDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToDoForm";
            this.Text = "ToDoForm";
            this.Load += new System.EventHandler(this.ToDoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccineToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerDate;
        private System.Windows.Forms.Label lblVaccine;
        private System.Windows.Forms.DataGridView dgVaccineToDo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMedication;
    }
}