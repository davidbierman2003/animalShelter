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
            this.dgPrescriptions = new System.Windows.Forms.DataGridView();
            this.lblMedication = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccineToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrescriptions)).BeginInit();
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
            this.lblVaccine.Location = new System.Drawing.Point(45, 114);
            this.lblVaccine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVaccine.Name = "lblVaccine";
            this.lblVaccine.Size = new System.Drawing.Size(74, 20);
            this.lblVaccine.TabIndex = 1;
            this.lblVaccine.Text = "Vaccines";
            // 
            // dgVaccineToDo
            // 
            this.dgVaccineToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccineToDo.Location = new System.Drawing.Point(48, 137);
            this.dgVaccineToDo.Margin = new System.Windows.Forms.Padding(2);
            this.dgVaccineToDo.Name = "dgVaccineToDo";
            this.dgVaccineToDo.RowHeadersWidth = 102;
            this.dgVaccineToDo.RowTemplate.Height = 40;
            this.dgVaccineToDo.Size = new System.Drawing.Size(878, 229);
            this.dgVaccineToDo.TabIndex = 2;
            // 
            // dgMedications
            // 
            this.dgPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrescriptions.Location = new System.Drawing.Point(48, 442);
            this.dgPrescriptions.Margin = new System.Windows.Forms.Padding(2);
            this.dgPrescriptions.Name = "dgMedications";
            this.dgPrescriptions.RowHeadersWidth = 102;
            this.dgPrescriptions.RowTemplate.Height = 40;
            this.dgPrescriptions.Size = new System.Drawing.Size(878, 229);
            this.dgPrescriptions.TabIndex = 4;
            // 
            // lblMedication
            // 
            this.lblMedication.AutoSize = true;
            this.lblMedication.Location = new System.Drawing.Point(45, 419);
            this.lblMedication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedication.Name = "lblMedication";
            this.lblMedication.Size = new System.Drawing.Size(94, 20);
            this.lblMedication.TabIndex = 3;
            this.lblMedication.Text = "Medications";
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 848);
            this.Controls.Add(this.dgPrescriptions);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerDate;
        private System.Windows.Forms.Label lblVaccine;
        private System.Windows.Forms.DataGridView dgVaccineToDo;
        private System.Windows.Forms.DataGridView dgPrescriptions;
        private System.Windows.Forms.Label lblMedication;
    }
}