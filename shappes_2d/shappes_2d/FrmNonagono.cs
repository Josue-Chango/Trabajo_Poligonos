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
    public partial class FrmNonagono : Form
    {

        int radio = 0;
        bool dibujar = false;
        
        public FrmNonagono()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<int>(txtRadio.Text))
            {
                radio = int.Parse(txtRadio.Text);
                Calculos calculos = new Calculos();
                dibujar = true;
                lblArea.Text = "Area: " + calculos.CalcularAreaNonagono(radio);
                lblPerimetro.Text = "Perimetro: " + calculos.CalcularPerimetroNonagono(radio);
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
            radio =0;
            lblArea.Text = "Area: ";
            lblPerimetro.Text = "Perimetro: ";
            txtRadio.Text = "";
            Invalidate();
            pctGrafico.Invalidate();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctGrafico_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (!dibujar) return;

            Figuras figuras = new Figuras();
            figuras.DibujarNonagono(g, radio);
        }
    }
}
