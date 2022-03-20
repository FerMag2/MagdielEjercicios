
namespace Ventanita
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txttexto = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(115, 49);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(251, 23);
            this.txttexto.TabIndex = 0;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(103, 110);
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(459, 188);
            this.Resultado.TabIndex = 1;
            this.Resultado.Text = "Resultado";
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(399, 48);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 2;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(480, 48);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(75, 23);
            this.igual.TabIndex = 3;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.txttexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttexto;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button igual;
    }
}

