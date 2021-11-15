using System.Windows.Forms;

namespace ControlColor
{
    partial class Colores
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCajita = new TextBox();
            this.label1 = new Label();
            this.SuspendLayout();
            // 
            // txtCajita
            // 
            this.txtCajita.Location = new System.Drawing.Point(137, 137);
            this.txtCajita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCajita.Name = "txtCajita";
            this.txtCajita.Size = new System.Drawing.Size(132, 22);
            this.txtCajita.TabIndex = 0;
            this.txtCajita.TextChanged += new System.EventHandler(this.txtCajita_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(83, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estados De Validación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Colores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCajita);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Colores";
            this.Size = new System.Drawing.Size(433, 236);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCajita;
        private Label label1;
    }
}
