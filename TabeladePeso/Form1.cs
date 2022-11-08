using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabeladePeso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txb_altura.Text) != 0)
                {


                    double alt = double.Parse(txb_altura.Text.ToString());
                    double pes = double.Parse(txb_peso.Text.ToString());
                    double rest = pes / (alt * alt);
                    rest = Math.Round(rest, 2);
                    txb_resultado.Text = rest.ToString();

                    if (rest < 18.5)
                    {
                        lbl_resultado.Text = "Abaixo do peso ideal ";
                        lbl_resultado.ForeColor = Color.Yellow;
                    }
                    else if (rest < 24.9)
                    {
                        lbl_resultado.Text = "Saudável ";
                        lbl_resultado.ForeColor = Color.Green;
                    }
                    else if (rest < 29.9)
                    {
                        lbl_resultado.Text = "Levemente acima do peso ";
                        lbl_resultado.ForeColor = Color.Orange;

                    }
                    else if (rest < 34.9)
                    {
                        lbl_resultado.Text = "Obesidade 1° ";
                        lbl_resultado.ForeColor = Color.DarkOrange;

                    }
                    else if (rest < 39.9)
                    {
                        lbl_resultado.Text = "Obesidade 2° (severa) ";
                        lbl_resultado.ForeColor = Color.Red;
                    }
                    else if (rest > 40)
                    {
                        lbl_resultado.Text = "Obesidade 3° (Mórbida) ";
                        lbl_resultado.ForeColor = Color.DarkRed;
                    }
                }
                else
                {
                    lbl_resultado.Text = "Não foi possivel calcular com numero 0 ";
                    lbl_resultado.ForeColor = Color.DarkBlue;
                }
            }
            catch (Exception ex)
            {
                lbl_resultado.Text = "Erro em calcular o IMC";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
