using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipo_de_triangulo
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLado1_TextChanged(object sender, EventArgs e)
        {
            if (txtLado1.TextLength != 0 && txtLado2.TextLength != 0 && txtLado3.TextLength != 0)
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }

        private void txtLado2_TextChanged(object sender, EventArgs e)
        {
            if (txtLado1.TextLength != 0 && txtLado2.TextLength != 0 && txtLado3.TextLength != 0)
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }

        private void txtLado3_TextChanged(object sender, EventArgs e)
        {
            if (txtLado1.TextLength != 0 && txtLado2.TextLength != 0 && txtLado3.TextLength != 0)
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }

        private void btnOK_Enter(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int lado1, lado2, lado3;

            lado1 = int.Parse(txtLado1.Text);
            lado2 = int.Parse(txtLado2.Text);
            lado3 = int.Parse(txtLado3.Text);

            if (lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2)
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    pbxTriangulo.Image = Properties.Resources.equilatero;
                    pbxAngulo.Image = Properties.Resources.acutangulo;
                }
                else
                {
                    if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                        pbxTriangulo.Image = Properties.Resources.isosceles;
                    else
                        pbxTriangulo.Image = Properties.Resources.escaleno;

                    Angulo(lado1, lado2, lado3);
                }
            }
            else
            {
                pbxTriangulo.Image = Properties.Resources.impossivel;
                pbxAngulo.Image = Properties.Resources.inexistente;
            }
        }

        private void txtLado1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtLado2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtLado3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        void Angulo(int l1, int l2, int l3)
        {
            int lado1 = l1, lado2 = l2, lado3 = l3;
            double cosA, cosB, cosC;

            cosA = (Math.Pow(lado1, 2) - Math.Pow(lado2, 2) - Math.Pow(lado3, 2)) / (2 * lado2 * lado3);
            cosB = (Math.Pow(lado2, 2) - Math.Pow(lado1, 2) - Math.Pow(lado3, 2)) / (2 * lado1 * lado3);
            cosC = (Math.Pow(lado3, 2) - Math.Pow(lado1, 2) - Math.Pow(lado2, 2)) / (2 * lado1 * lado2);

            if (cosA == 0 || cosB == 0 || cosC == 0)
                pbxAngulo.Image = Properties.Resources.retangulo;
            else
            {
                if (cosA < 0 || cosB < 0 || cosC < 0)
                    pbxAngulo.Image = Properties.Resources.obtusangulo;
                else
                    pbxAngulo.Image = Properties.Resources.acutangulo;
            }
        }
    }
}