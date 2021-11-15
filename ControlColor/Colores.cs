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

    public partial class Colores : UserControl
    {
        public event EventHandler cambio;
        private tipoEstado estado; 


        public tipoEstado Estado {
            get
            {
                return estado;
            }
            set{

                estado = value;

                //No se valida
                if (value==tipoEstado.SinValidar)
                {
                    txtCajita.BackColor = Color.White;
                    txtCajita.ForeColor = Color.Black;
                }
                //No valido
                else if (value==tipoEstado.Invalido)
                {
                    txtCajita.BackColor = Color.OrangeRed;
                    txtCajita.ForeColor = Color.Red;
                }
                //valido
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
            //Cambio manual del estado a valido
            //cambia aqui el estado
            Estado = tipoEstado.Valido;

            cambio?.Invoke(this, null);
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }

   
}
