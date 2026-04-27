using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shappes_2d
{
    public partial class FrmCuadrado : Form
    {
        int lado = 0;
        bool dibujar = false;
        public FrmCuadrado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<int>(txtLado.Text))
            {
                lado = int.Parse(txtLado.Text);
                Calculos calculos = new Calculos();
                dibujar = true;
                lblArea.Text = "Area: " + calculos.CalcularAreaCuadrado(lado);
                lblPerimetro.Text = "Perimetro: " + calculos.CalcularPerimetroCuadrado(lado);
                Invalidate();




            }
            else
            {
                MessageBox.Show("Campo no valido, el campo debe llenarse con numeros positivos");
            }
        }

        private void FrmCuadrado_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (!dibujar) return;

            Figuras figuras = new Figuras();
            figuras.DibujarCuadrado(g, lado);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            lado = 0;
            txtLado.Text = "";
            lblArea.Text = "Area: ";
            lblPerimetro.Text = "Perimetro: ";
            this.Invalidate();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
