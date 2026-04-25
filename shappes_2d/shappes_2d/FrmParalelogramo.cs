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
    public partial class FrmParalelogramo : Form
    {
        int ladoA = 0;
        int ladoB = 0;
        double angulo = 0;
        bool dibujar = false;
        public FrmParalelogramo()
        {
            InitializeComponent();
        }

        private void FrmParalelogramo_Paint(object sender, PaintEventArgs e)
        {
            // Solo dibuja si el botón fue presionado con éxito
            if (!dibujar) return;

            Graphics g = e.Graphics;
            Figuras figuras = new Figuras();

            // Llama al método de dibujo (asegúrate que esté en tu clase Figuras)
            figuras.DibujarParalelogramo(g, ladoA, ladoB, angulo);

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAngulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Validamos solo los campos de entrada
            if (Validador.Validar<int>(txtA.Text) &&
                Validador.Validar<int>(txtB.Text) &&
                Validador.Validar<double>(txtAngulo.Text))
            {
                ladoA = int.Parse(txtA.Text);
                ladoB = int.Parse(txtB.Text);
                angulo = double.Parse(txtAngulo.Text);

                // Activamos la bandera y refrescamos el Form
                dibujar = true;
                this.Invalidate();
            }
            else
            {
                // Si aún te da error 'warning', asegúrate de que el Label 
                // de error en tu diseño se llame exactamente así.
                MessageBox.Show("Datos inválidos. Por favor ingresa números válidos.");
            }
        }


        private void FrmParalelogramo_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
