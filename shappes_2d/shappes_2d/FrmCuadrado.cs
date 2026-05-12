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
        Figuras figuras = new Figuras();

        Movimiento movimiento = new Movimiento();
        public FrmCuadrado()
        {
            InitializeComponent();
            this.KeyPreview = true;

            this.KeyDown += FrmCuadrado_KeyDown;

            trackBar1.TabStop = false;
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
            movimiento.AplicarTransformaciones(g, 350, 150);
            figuras.DibujarCuadrado(g, lado);
            g.ResetTransform();
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

        private void FrmCuadrado_KeyDown(object sender, KeyEventArgs e)
        {
            movimiento.ControlTeclado(e);

            Invalidate();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float escala = trackBar1.Value / 10.0f;

            movimiento.CambiarEscala(escala);

            Invalidate();
        }
    }
}
