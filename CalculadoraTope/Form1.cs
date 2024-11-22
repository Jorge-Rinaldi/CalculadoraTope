using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTope
{
    public partial class CALCULADORA : Form
    {
        public CALCULADORA()
        {
            InitializeComponent();
        }

            Numero n1 = new Numero();
            Numero n2 = new Numero();
                        

        private void btn_Suma_Click(object sender, EventArgs e)
        {
            try
            {
            n1.Numeros = int.Parse(txt_Numero.Text);
            n2.Numeros += n1.Numeros;
            txt_Numero.Text = n2.Numeros.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número");
            }            
            
        }

        private void btn_Resta_Click(object sender, EventArgs e)
        {
            try
            {
                n1.Numeros = int.Parse(txt_Numero.Text);

                if(n1.Resultado == null) 
                {
                n1.Resultado = n1.Numeros;
                txt_Numero.Text = n1.Resultado.ToString();
                }
                else
                {
                    n1.Resultado -= n1.Numeros;
                    txt_Numero.Text = n1.Resultado.ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número");
            }
        }


        private void btn_Multiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                n1.Numeros = int.Parse(txt_Numero.Text);

                if(n1.Resultado == 0)
                {
                    n1.Resultado = n1.Numeros;
                }
                else
                {
                    n1.Resultado = n1.Numeros * n1.Resultado;
                }

                txt_Numero.Text = n1.Resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número");
            }
        }
        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            n1.Numeros = 0;
            n1.Resultado = null;
            txt_Numero.Text = "0";
        }

        private void btn_Division_Click(object sender, EventArgs e)
        {
            n1.Numeros = int.Parse(txt_Numero.Text);
            if(n1.Resultado == null)
            {
            n1.Resultado = n1.Numeros;
            txt_Numero.Text = n1.Resultado.ToString();
            }
            else
            {
               txt_Numero.Text = (n1.Resultado / n1.Numeros).ToString();
            }


        }
    }
}
