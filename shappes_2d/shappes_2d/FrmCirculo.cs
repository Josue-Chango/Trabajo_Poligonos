using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace shappes_2d
{
    public partial class FrmCirculo : Form
    {
        float radio=0;
        bool dibujar = false;
        Figuras figuras = new Figuras();

        Movimiento movimiento = new Movimiento();
        public FrmCirculo()
        {
            InitializeComponent();
            this.KeyPreview = true;

            this.KeyDown += FrmCirculo_KeyDown;

            trackBar1.TabStop = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<int>(txtRadio.Text))
            {
                radio = int.Parse(txtRadio.Text);
                Calculos calculos = new Calculos();
                dibujar = true;
                lblArea.Text = "Area: " + calculos.CalcularAreaCirculo(radio);
                lblPerimetro.Text = "Perimetro: " + calculos.CalcularPerimetroCirculo(radio);
                Invalidate();




            }
            else
            {
                MessageBox.Show("Campo no valido, el campo debe llenarse con numeros positivos");
            }
        }

        private void FrmCirculo_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Graphics g = e.Graphics;
            movimiento.AplicarTransformaciones(g, 350, 150);
         
            figuras.DibujarCirculo(g, radio);

            g.ResetTransform();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {

            txtRadio.Text = "";
            lblArea.Text = "Area: ";
            lblPerimetro.Text = "Perimetro: ";
            radio = 0;
            this.Invalidate();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float escala = trackBar1.Value / 10.0f;

            movimiento.CambiarEscala(escala);

            Invalidate();
        }

        private void trackBar1_KeyDown(object sender, KeyEventArgs e)
        {
            movimiento.ControlTeclado(e);

            Invalidate();
        }

        private void FrmCirculo_KeyDown(object sender, KeyEventArgs e)
        {
            movimiento.ControlTeclado(e);

            Invalidate();
        }
    }
}
