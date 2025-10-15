namespace Newton_Raphson
{
    partial class Datos_extra
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnInsertarX0 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.lblX0 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.panelDatosExtra = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnInsertarX0
            // 
            this.btnInsertarX0.Location = new System.Drawing.Point(60, 140);
            this.btnInsertarX0.Name = "btnInsertarX0";
            this.btnInsertarX0.Size = new System.Drawing.Size(90, 30);
            this.btnInsertarX0.TabIndex = 0;
            this.btnInsertarX0.Text = "Insertar";
            this.btnInsertarX0.UseVisualStyleBackColor = true;
            this.btnInsertarX0.Click += new System.EventHandler(this.btninsertarxo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(270, 140);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(90, 30);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnerror_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(160, 400);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 35);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar valores";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(20, 400);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 35);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(90, 90);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(100, 22);
            this.txtX0.TabIndex = 4;
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(290, 90);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(100, 22);
            this.txtError.TabIndex = 5;
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Location = new System.Drawing.Point(55, 93);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(29, 16);
            this.lblX0.TabIndex = 6;
            this.lblX0.Text = "X₀:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(240, 93);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(44, 16);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "Error:";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(420, 140);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(90, 30);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // panelDatosExtra
            // 
            this.panelDatosExtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatosExtra.Location = new System.Drawing.Point(60, 200);
            this.panelDatosExtra.Name = "panelDatosExtra";
            this.panelDatosExtra.Size = new System.Drawing.Size(350, 100);
            this.panelDatosExtra.TabIndex = 9;
            // 
            // Datos_extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 470);
            this.Controls.Add(this.panelDatosExtra);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblX0);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnInsertarX0);
            this.Name = "Datos_extra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Iniciales - Newton-Raphson";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnInsertarX0;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel panelDatosExtra;
    }
}
