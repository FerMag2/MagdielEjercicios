namespace Practica_2
{
    partial class Ventana
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
            this.Contenedor = new System.Windows.Forms.Panel();
            this.Yellow = new System.Windows.Forms.Button();
            this.Orange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Blue = new Practica_2.BotonCircular();
            this.botonCircular = new Practica_2.BotonCircular();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.AllowDrop = true;
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Contenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Contenedor.Location = new System.Drawing.Point(11, 99);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(276, 311);
            this.Contenedor.TabIndex = 1;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Lime;
            this.Yellow.FlatAppearance.BorderSize = 5;
            this.Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Yellow.Location = new System.Drawing.Point(418, 214);
            this.Yellow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(57, 43);
            this.Yellow.TabIndex = 7;
            this.Yellow.Text = "Verde";
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Yellow_MouseDown);
            this.Yellow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Yellow_MouseMove);
            this.Yellow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Yellow_MouseUp);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.Red;
            this.Orange.FlatAppearance.BorderSize = 5;
            this.Orange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Orange.Location = new System.Drawing.Point(479, 214);
            this.Orange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(98, 43);
            this.Orange.TabIndex = 9;
            this.Orange.Text = "Rojo";
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Orange_MouseDown);
            this.Orange.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Orange_MouseMove);
            this.Orange.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Orange_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fernando Magdiel Chi Canul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mis Componentes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ISC 4A Practica2";
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Blue.Location = new System.Drawing.Point(462, 261);
            this.Blue.Margin = new System.Windows.Forms.Padding(2);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(68, 66);
            this.Blue.TabIndex = 8;
            this.Blue.Text = "Negro";
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Blue_MouseDown);
            this.Blue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Blue_MouseMove);
            this.Blue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Blue_MouseUp);
            // 
            // botonCircular
            // 
            this.botonCircular.BackColor = System.Drawing.Color.Magenta;
            this.botonCircular.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonCircular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonCircular.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCircular.ForeColor = System.Drawing.Color.White;
            this.botonCircular.Location = new System.Drawing.Point(286, 11);
            this.botonCircular.Margin = new System.Windows.Forms.Padding(2);
            this.botonCircular.Name = "botonCircular";
            this.botonCircular.Size = new System.Drawing.Size(92, 88);
            this.botonCircular.TabIndex = 2;
            this.botonCircular.Text = "Botoncito";
            this.botonCircular.UseVisualStyleBackColor = false;
            this.botonCircular.Click += new System.EventHandler(this.botonCircular_Click);
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(644, 421);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.botonCircular);
            this.Controls.Add(this.Contenedor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ventana";
            this.Text = "Practica 2";
            this.Load += new System.EventHandler(this.Ventana_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Ventana_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ventana_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Contenedor;
        private BotonCircular botonCircular;
        private System.Windows.Forms.Button Yellow;
        private BotonCircular Blue;
        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

