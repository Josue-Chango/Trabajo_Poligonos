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
        public FrmCirculo()
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
            Figuras figuras = new Figuras();
            figuras.DibujarCirculo(g, radio);
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
    }
}
