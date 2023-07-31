
namespace LaboratorioDeFisica
{
    partial class Mru
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
            this.pictureBoxcar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnMru = new System.Windows.Forms.Button();
            this.BtnsgtDinamica = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxtiempo = new System.Windows.Forms.TextBox();
            this.txtBoxvelocidad = new System.Windows.Forms.TextBox();
            this.txtBoxdistancia = new System.Windows.Forms.TextBox();
            this.textBoxrpta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxcar
            // 
            this.pictureBoxcar.Image = global::LaboratorioDeFisica.Properties.Resources.AUTO_MRU;
            this.pictureBoxcar.Location = new System.Drawing.Point(0, 235);
            this.pictureBoxcar.Name = "pictureBoxcar";
            this.pictureBoxcar.Size = new System.Drawing.Size(178, 56);
            this.pictureBoxcar.TabIndex = 0;
            this.pictureBoxcar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " A ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " B ";
            // 
            // BtnMru
            // 
            this.BtnMru.Location = new System.Drawing.Point(706, 54);
            this.BtnMru.Name = "BtnMru";
            this.BtnMru.Size = new System.Drawing.Size(81, 25);
            this.BtnMru.TabIndex = 3;
            this.BtnMru.Text = "EJECUTAR";
            this.BtnMru.UseVisualStyleBackColor = true;
            this.BtnMru.Click += new System.EventHandler(this.BtnMru_Click);
            // 
            // BtnsgtDinamica
            // 
            this.BtnsgtDinamica.Location = new System.Drawing.Point(707, 95);
            this.BtnsgtDinamica.Name = "BtnsgtDinamica";
            this.BtnsgtDinamica.Size = new System.Drawing.Size(81, 25);
            this.BtnsgtDinamica.TabIndex = 5;
            this.BtnsgtDinamica.Text = "SIGUIENTE";
            this.BtnsgtDinamica.UseVisualStyleBackColor = true;
            this.BtnsgtDinamica.Click += new System.EventHandler(this.BtnsgtDinamica_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 10;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 10);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "s.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "vm/s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "m.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rpta";
            // 
            // txtBoxtiempo
            // 
            this.txtBoxtiempo.Location = new System.Drawing.Point(6, 352);
            this.txtBoxtiempo.Name = "txtBoxtiempo";
            this.txtBoxtiempo.Size = new System.Drawing.Size(62, 20);
            this.txtBoxtiempo.TabIndex = 11;
            // 
            // txtBoxvelocidad
            // 
            this.txtBoxvelocidad.Location = new System.Drawing.Point(139, 352);
            this.txtBoxvelocidad.Name = "txtBoxvelocidad";
            this.txtBoxvelocidad.Size = new System.Drawing.Size(62, 20);
            this.txtBoxvelocidad.TabIndex = 12;
            // 
            // txtBoxdistancia
            // 
            this.txtBoxdistancia.Location = new System.Drawing.Point(280, 352);
            this.txtBoxdistancia.Name = "txtBoxdistancia";
            this.txtBoxdistancia.Size = new System.Drawing.Size(62, 20);
            this.txtBoxdistancia.TabIndex = 13;
            // 
            // textBoxrpta
            // 
            this.textBoxrpta.Location = new System.Drawing.Point(433, 352);
            this.textBoxrpta.Name = "textBoxrpta";
            this.textBoxrpta.Size = new System.Drawing.Size(62, 20);
            this.textBoxrpta.TabIndex = 14;
            // 
            // Mru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxrpta);
            this.Controls.Add(this.txtBoxdistancia);
            this.Controls.Add(this.txtBoxvelocidad);
            this.Controls.Add(this.txtBoxtiempo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnsgtDinamica);
            this.Controls.Add(this.BtnMru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxcar);
            this.Name = "Mru";
            this.Text = "Mru";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxcar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnMru;
        private System.Windows.Forms.Button BtnsgtDinamica;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxtiempo;
        private System.Windows.Forms.TextBox txtBoxvelocidad;
        private System.Windows.Forms.TextBox txtBoxdistancia;
        private System.Windows.Forms.TextBox textBoxrpta;
    }
}