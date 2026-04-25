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
    public partial class FrmTrianguloE : Form
    {
        float ladoTriangulo = 0;
        bool dibujar = false;
        public FrmTrianguloE()
        {
            InitializeComponent();
        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<float>(txtLado.Text))
            {
                ladoTriangulo = float.Parse(txtLado.Text);
                double alturaCalculada = (Math.Sqrt(3) / 2) * ladoTriangulo;

                // Pasamos el resultado al TextBox redondeado a 2 decimales
                txtAltura.Text = alturaCalculada.ToString("F2");
                dibujar = true;
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido para el lado.");
            }

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTrianguloE_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmTrianguloE_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Graphics g = e.Graphics;
            Figuras figuras = new Figuras();
            figuras.DibujarTrianguloEquilatero(g, ladoTriangulo);

        }
    }
}
