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
    public partial class FrmCometa : Form
    {
        float anchoCometa = 0;
        float altoCometa = 0;
        bool dibujar = false;

        Figuras figuras = new Figuras();

        Movimiento movimiento = new Movimiento();
        public FrmCometa()
        {
            InitializeComponent();
            this.KeyPreview = true;

            this.KeyDown += FrmCometa_KeyDown;

            trackBar1.TabStop = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCometa_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;
            Graphics g = e.Graphics;

            movimiento.AplicarTransformaciones(g, 350, 150);
            figuras.DibujarCometa(e.Graphics, anchoCometa, altoCometa);
            g.ResetTransform();

        }

        private void txtAncho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCruce_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            // Solo validamos Ancho y Alto
            if (Validador.Validar<float>(txtAncho.Text) &&
                Validador.Validar<float>(txtAlto.Text))
            {
                anchoCometa = float.Parse(txtAncho.Text);
                altoCometa = float.Parse(txtAlto.Text);

                dibujar = true;
                this.Invalidate();
            }
        }

        private void FrmCometa_Load(object sender, EventArgs e)
        {

        }

        private void FrmCometa_KeyDown(object sender, KeyEventArgs e)
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
