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
    public partial class FrmPentagono : Form
    {
        int lado =0;
        bool dibujar = false;
        public FrmPentagono()
        {
            InitializeComponent();
        }

        private void pctGrafico_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (!dibujar) return;

            Figuras figuras = new Figuras();
            figuras.DibujarPentagono(g, lado);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<int>(txtLado.Text))
            {
                lado = int.Parse(txtLado.Text);
                Calculos calculos = new Calculos();
                dibujar = true;
                lblArea.Text = "Area: " + calculos.CalcularAreaPentagono(lado);
                lblPerimetro.Text = "Perimetro: " + calculos.CalcularPerimetroPentagono(lado);
                Invalidate();
                pctGrafico.Invalidate();
            }
            else
            {
                MessageBox.Show("Campo no valido, el campo debe llenarse con numeros positivos o debe existir el trapecio");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            lado = 0;
            dibujar = false;
            lblArea.Text = "Area: ";
            lblPerimetro.Text = "Perimetro: ";
            txtLado.Text = "";
            Invalidate();
            pctGrafico.Invalidate();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPentagono_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (!dibujar) return;

            Figuras figuras = new Figuras();
            figuras.DibujarPentagono(g, lado);
        }
    }
}
