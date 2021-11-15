using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlColor
{
    public enum tipoEstado
    {
        SinValidar,
        Valido,
        Invalido    
    }

    public partial class Colores : UserControl
    {
        public event EventHandler cambio;
        private tipoEstado colore;
        private String coloree;


        public String Coloree
        {
            get
            {
                return coloree;
            }
            set
            {
                coloree = value;
            }
        }
        public tipoEstado Colore {
            get
            {
                return colore;
            }
            set{

                colore = value;

                if (value==tipoEstado.SinValidar)
                {
                    txtCajita.BackColor = Color.Black;
                    txtCajita.ForeColor = Color.White;
                }
                else if (value==tipoEstado.SinValidar)
                {
                    txtCajita.BackColor = Color.OrangeRed;
                    txtCajita.ForeColor = Color.Red;
                }
                else
                {
                    txtCajita.BackColor = Color.GreenYellow;
                    txtCajita.ForeColor = Color.DarkGreen;
                }

                
            }
        }


        public Colores()
        {
            InitializeComponent();
        }


        private void txtCajita_TextChanged(object sender, EventArgs e)
        {
            coloree = txtCajita.Text;
            cambio?.Invoke(this, null);
        }
    }

   
}
