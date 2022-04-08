namespace FrontEndAnimalShelter
{
    partial class ViewAnimal
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
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimalTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAnimalTable
            // 
            this.dgAnimalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnimalTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgAnimalTable.Location = new System.Drawing.Point(0, 259);
            this.dgAnimalTable.Name = "dgAnimalTable";
            this.dgAnimalTable.RowHeadersWidth = 102;
            this.dgAnimalTable.RowTemplate.Height = 40;
            this.dgAnimalTable.Size = new System.Drawing.Size(2114, 896);
            this.dgAnimalTable.TabIndex = 0;
            // 
            // ViewAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2114, 1155);
            this.ControlBox = false;
            this.Controls.Add(this.dgAnimalTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAnimal";
            this.Text = "ViewAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimalTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAnimalTable;
    }
}