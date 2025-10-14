namespace Newton_Raphson
{
    partial class Datos_extra
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
            this.btninsertarxo = new System.Windows.Forms.Button();
            this.btnerror = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.Xo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.paneldatosextra = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btninsertarxo
            // 
            this.btninsertarxo.Location = new System.Drawing.Point(79, 139);
            this.btninsertarxo.Name = "btninsertarxo";
            this.btninsertarxo.Size = new System.Drawing.Size(75, 23);
            this.btninsertarxo.TabIndex = 0;
            this.btninsertarxo.Text = "Insertar";
            this.btninsertarxo.UseVisualStyleBackColor = true;
            this.btninsertarxo.Click += new System.EventHandler(this.btninsertarxo_Click);
            // 
            // btnerror
            // 
            this.btnerror.Location = new System.Drawing.Point(276, 140);
            this.btnerror.Name = "btnerror";
            this.btnerror.Size = new System.Drawing.Size(75, 23);
            this.btnerror.TabIndex = 1;
            this.btnerror.Text = "Borrar";
            this.btnerror.UseVisualStyleBackColor = true;
            this.btnerror.Click += new System.EventHandler(this.btnerror_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(163, 397);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(117, 41);
            this.btneditar.TabIndex = 2;
            this.btneditar.Text = "Editar valores";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Regresar";
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(90, 92);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(100, 22);
            this.txtXi.TabIndex = 4;
            this.txtXi.TextChanged += new System.EventHandler(this.txtXi_TextChanged);
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(286, 92);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(100, 22);
            this.txtError.TabIndex = 5;
            this.txtError.TextChanged += new System.EventHandler(this.txtError_TextChanged);
            // 
            // Xo
            // 
            this.Xo.AutoSize = true;
            this.Xo.Location = new System.Drawing.Point(58, 95);
            this.Xo.Name = "Xo";
            this.Xo.Size = new System.Drawing.Size(26, 16);
            this.Xo.TabIndex = 6;
            this.Xo.Text = "Xo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Error:";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(428, 139);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // paneldatosextra
            // 
            this.paneldatosextra.Location = new System.Drawing.Point(80, 206);
            this.paneldatosextra.Name = "paneldatosextra";
            this.paneldatosextra.Size = new System.Drawing.Size(270, 79);
            this.paneldatosextra.TabIndex = 9;
            this.paneldatosextra.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldatosextra_Paint);
            // 
            // Datos_extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paneldatosextra);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Xo);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnerror);
            this.Controls.Add(this.btninsertarxo);
            this.Name = "Datos_extra";
            this.Text = "Datos_extra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninsertarxo;
        private System.Windows.Forms.Button btnerror;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label Xo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel paneldatosextra;
    }
}