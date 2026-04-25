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
    public partial class FrmRombo : Form
    {
        float lado = 0;
        double angulo = 0;
        bool dibujar = false;
        public FrmRombo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmRombo_Load(object sender, EventArgs e)
        {

        }

        private void txtDibujar_Click(object sender, EventArgs e)
        {

        }

        private void txtAngulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRombo_Paint(object sender, PaintEventArgs e)
        {
            // Solo dibujamos si se presionó el botón con éxito
            if (!dibujar) return;

            Graphics g = e.Graphics;
            // Opcional: mejora la calidad de las líneas
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Figuras figuras = new Figuras();
            figuras.DibujarRombo(g, lado, angulo);
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            // Validamos que los TextBox tengan datos correctos
            if (Validador.Validar<float>(txtLado.Text) &&
                Validador.Validar<double>(txtAngulo.Text))
            {
                lado = float.Parse(txtLado.Text);
                angulo = double.Parse(txtAngulo.Text);

                dibujar = true;

                // Forzamos al formulario a redibujarse
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.");
            }
        }
    }
}
