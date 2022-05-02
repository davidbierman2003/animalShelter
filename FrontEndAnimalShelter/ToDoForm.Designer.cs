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
            this.dgVaccineToDo = new System.Windows.Forms.DataGridView();
            this.dgPrescriptions = new System.Windows.Forms.DataGridView();
            this.personalInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccineToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // headerDate
            // 
            this.headerDate.AutoSize = true;
            this.headerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerDate.Location = new System.Drawing.Point(279, 23);
            this.headerDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.headerDate.Name = "headerDate";
            this.headerDate.Size = new System.Drawing.Size(85, 25);
            this.headerDate.TabIndex = 0;
            this.headerDate.Text = "header";
            // 
            // dgVaccineToDo
            // 
            this.dgVaccineToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccineToDo.Location = new System.Drawing.Point(32, 89);
            this.dgVaccineToDo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgVaccineToDo.Name = "dgVaccineToDo";
            this.dgVaccineToDo.RowHeadersWidth = 102;
            this.dgVaccineToDo.RowTemplate.Height = 40;
            this.dgVaccineToDo.Size = new System.Drawing.Size(585, 149);
            this.dgVaccineToDo.TabIndex = 2;
            // 
            // dgPrescriptions
            // 
            this.dgPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrescriptions.Location = new System.Drawing.Point(32, 287);
            this.dgPrescriptions.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgPrescriptions.Name = "dgPrescriptions";
            this.dgPrescriptions.RowHeadersWidth = 102;
            this.dgPrescriptions.RowTemplate.Height = 40;
            this.dgPrescriptions.Size = new System.Drawing.Size(585, 149);
            this.dgPrescriptions.TabIndex = 4;
            // 
            // personalInfoLabel
            // 
            this.personalInfoLabel.AutoSize = true;
            this.personalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoLabel.Location = new System.Drawing.Point(30, 71);
            this.personalInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.personalInfoLabel.Name = "personalInfoLabel";
            this.personalInfoLabel.Size = new System.Drawing.Size(100, 17);
            this.personalInfoLabel.TabIndex = 29;
            this.personalInfoLabel.Text = "Vaccinations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Medications";
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personalInfoLabel);
            this.Controls.Add(this.dgPrescriptions);
            this.Controls.Add(this.dgVaccineToDo);
            this.Controls.Add(this.headerDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
        private System.Windows.Forms.DataGridView dgVaccineToDo;
        private System.Windows.Forms.DataGridView dgPrescriptions;
        private System.Windows.Forms.Label personalInfoLabel;
        private System.Windows.Forms.Label label1;
    }
}