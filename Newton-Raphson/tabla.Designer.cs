namespace Newton_Raphson
{
    partial class Tabla
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
            this.paneltabla = new System.Windows.Forms.Panel();
            this.dataGridNewton = new System.Windows.Forms.DataGridView();
            this.paneltabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNewton)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltabla
            // 
            this.paneltabla.Controls.Add(this.dataGridNewton);
            this.paneltabla.Location = new System.Drawing.Point(13, 13);
            this.paneltabla.Name = "paneltabla";
            this.paneltabla.Size = new System.Drawing.Size(753, 306);
            this.paneltabla.TabIndex = 0;
            // 
            // dataGridNewton
            // 
            this.dataGridNewton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNewton.Location = new System.Drawing.Point(12, 13);
            this.dataGridNewton.Name = "dataGridNewton";
            this.dataGridNewton.RowHeadersWidth = 51;
            this.dataGridNewton.RowTemplate.Height = 24;
            this.dataGridNewton.Size = new System.Drawing.Size(722, 272);
            this.dataGridNewton.TabIndex = 0;
            this.dataGridNewton.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNewton_CellContentClick);
            // 
            // Tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paneltabla);
            this.Name = "Tabla";
            this.Text = "tabla";
            this.paneltabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNewton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltabla;
        private System.Windows.Forms.DataGridView dataGridNewton;
    }
}