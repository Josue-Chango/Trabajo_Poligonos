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
    public partial class FrmCorazon : Form
    {
        float tamañoCorazon = 0;
        bool dibujar = false;

        Figuras figuras = new Figuras();

        Movimiento movimiento = new Movimiento();
        public FrmCorazon()
        {
            InitializeComponent();
            this.KeyPreview = true;

            this.KeyDown += FrmCorazon_KeyDown;

            trackBar1.TabStop = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCorazon_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Graphics g = e.Graphics;
            movimiento.AplicarTransformaciones(g, 350, 150);
            Figuras figuras = new Figuras();
            figuras.DibujarCorazon(g, tamañoCorazon);
            g.ResetTransform();
        }

        private void txtTamaño_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCorazon_Load(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<float>(txtTamaño.Text))
            {
                tamañoCorazon = float.Parse(txtTamaño.Text);
                dibujar = true;
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido para el tamaño.");
            }
        }

        private void FrmCorazon_KeyDown(object sender, KeyEventArgs e)
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
