namespace FrontEndAnimalShelter
{
    partial class ViewEmployees
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
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmployees
            // 
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEmployees.Location = new System.Drawing.Point(0, 0);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.RowHeadersWidth = 102;
            this.dgEmployees.RowTemplate.Height = 40;
            this.dgEmployees.Size = new System.Drawing.Size(1815, 780);
            this.dgEmployees.TabIndex = 1;
            // 
            // ViewEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 780);
            this.Controls.Add(this.dgEmployees);
            this.Name = "ViewEmployeesForm";
            this.Text = "ViewEmployeesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmployees;
    }
}