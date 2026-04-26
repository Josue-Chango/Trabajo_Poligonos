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
    public partial class FrmTrianguloEs : Form
    {
        float lA = 0, lB = 0, lC = 0;
        bool dibujar = false;
        public FrmTrianguloEs()
        {
            InitializeComponent();
        }

        private void txtLado1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLado2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLado3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTrianguloEs_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Graphics g = e.Graphics;
            Figuras figuras = new Figuras();
            figuras.DibujarTrianguloEscaleno(g, lA, lB, lC);
        }

        private void FrmTrianguloEs_Load(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<float>(txtLado1.Text) &&
            Validador.Validar<float>(txtLado2.Text) &&
            Validador.Validar<float>(txtLado3.Text))
            {
                lA = float.Parse(txtLado1.Text);
                lB = float.Parse(txtLado2.Text);
                lC = float.Parse(txtLado3.Text);

                // Verificación rápida de existencia de triángulo
                if (lA + lB > lC && lA + lC > lB && lB + lC > lA)
                {
                    float s = (lA + lB + lC) / 2; // Semiperímetro
                    double area = Math.Sqrt(s * (s - lA) * (s - lB) * (s - lC));
                    txtArea.Text = area.ToString("F2");
                    dibujar = true;
                    this.Invalidate();
                }
                else
                {
                    MessageBox.Show("La suma de dos lados debe ser mayor al tercero.");
                }

            }
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
