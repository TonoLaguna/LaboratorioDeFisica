
namespace LaboratorioDeFisica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lbltitulo1 = new System.Windows.Forms.Label();
            this.lbltitulo2 = new System.Windows.Forms.Label();
            this.lbltitulo3 = new System.Windows.Forms.Label();
            this.lbltitulo5 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.Btningresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(164, 37);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(272, 45);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "LABORATORIO ";
            // 
            // lbltitulo1
            // 
            this.lbltitulo1.AutoSize = true;
            this.lbltitulo1.Location = new System.Drawing.Point(270, 99);
            this.lbltitulo1.Name = "lbltitulo1";
            this.lbltitulo1.Size = new System.Drawing.Size(134, 45);
            this.lbltitulo1.TabIndex = 1;
            this.lbltitulo1.Text = "FISICA";
            // 
            // lbltitulo2
            // 
            this.lbltitulo2.AutoSize = true;
            this.lbltitulo2.Location = new System.Drawing.Point(184, 99);
            this.lbltitulo2.Name = "lbltitulo2";
            this.lbltitulo2.Size = new System.Drawing.Size(71, 45);
            this.lbltitulo2.TabIndex = 2;
            this.lbltitulo2.Text = "DE";
            // 
            // lbltitulo3
            // 
            this.lbltitulo3.AutoSize = true;
            this.lbltitulo3.Location = new System.Drawing.Point(125, 168);
            this.lbltitulo3.Name = "lbltitulo3";
            this.lbltitulo3.Size = new System.Drawing.Size(161, 45);
            this.lbltitulo3.TabIndex = 3;
            this.lbltitulo3.Text = "MASTER";
            // 
            // lbltitulo5
            // 
            this.lbltitulo5.AutoSize = true;
            this.lbltitulo5.Location = new System.Drawing.Point(325, 168);
            this.lbltitulo5.Name = "lbltitulo5";
            this.lbltitulo5.Size = new System.Drawing.Size(133, 45);
            this.lbltitulo5.TabIndex = 4;
            this.lbltitulo5.Text = "GENIO";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(78, 300);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(97, 25);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "USUARIO";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontraseña.Location = new System.Drawing.Point(78, 395);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(140, 25);
            this.lblcontraseña.TabIndex = 6;
            this.lblcontraseña.Text = "CONTRASEÑA";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(251, 294);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(207, 38);
            this.txtusuario.TabIndex = 7;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontrasena.Location = new System.Drawing.Point(251, 388);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(207, 38);
            this.txtcontrasena.TabIndex = 8;
            // 
            // Btningresar
            // 
            this.Btningresar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btningresar.Location = new System.Drawing.Point(251, 476);
            this.Btningresar.Name = "Btningresar";
            this.Btningresar.Size = new System.Drawing.Size(207, 51);
            this.Btningresar.TabIndex = 9;
            this.Btningresar.Text = "INGRESAR";
            this.Btningresar.UseVisualStyleBackColor = true;
            this.Btningresar.Click += new System.EventHandler(this.Btningresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 555);
            this.Controls.Add(this.Btningresar);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lbltitulo5);
            this.Controls.Add(this.lbltitulo3);
            this.Controls.Add(this.lbltitulo2);
            this.Controls.Add(this.lbltitulo1);
            this.Controls.Add(this.lbltitulo);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Form1";
            this.Text = "Acceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lbltitulo1;
        private System.Windows.Forms.Label lbltitulo2;
        private System.Windows.Forms.Label lbltitulo3;
        private System.Windows.Forms.Label lbltitulo5;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Button Btningresar;
    }
}

