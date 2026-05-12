using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shappes_2d
{
    public partial class FrmCruz : Form
    {
        float grosorCruz = 0;
        bool dibujar = false;
        Figuras figuras = new Figuras();

        Movimiento movimiento = new Movimiento();
        public FrmCruz()
        {
            InitializeComponent();
            this.KeyPreview = true;

            this.KeyDown += FrmCruz_KeyDown;

            trackBar1.TabStop = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmCruz_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;
            Graphics g = e.Graphics;
            movimiento.AplicarTransformaciones(g, 350, 150);
            figuras.DibujarCruz(e.Graphics, grosorCruz);
            g.ResetTransform();

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<float>(txtGrosor.Text))
            {
                grosorCruz = float.Parse(txtGrosor.Text);
                dibujar = true;
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido para el tamaño.");
            }

        }

        private void txtGrosor_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCruz_Load(object sender, EventArgs e)
        {

        }

        private void FrmCruz_KeyDown(object sender, KeyEventArgs e)
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
