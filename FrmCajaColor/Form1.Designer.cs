
namespace FrmCajaColor
{
    partial class Form1
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
            this.colores1 = new ControlColor.Colores();
            this.SuspendLayout();
            // 
            // colores1
            // 
            this.colores1.Colore = ControlColor.tipoEstado.SinValidar;
            this.colores1.Location = new System.Drawing.Point(77, 44);
            this.colores1.Name = "colores1";
            this.colores1.Size = new System.Drawing.Size(325, 192);
            this.colores1.TabIndex = 0;
            this.colores1.Load += new System.EventHandler(this.colores1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 307);
            this.Controls.Add(this.colores1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlColor.Colores colores1;
    }
}