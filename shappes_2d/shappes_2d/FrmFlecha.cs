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
    public partial class FrmFlecha : Form
    {
        int base_cuerpo = 0, base_cabeza = 0, altura_cuerpo = 0, altura_cabeza = 0;
        bool dibujar = false;
        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (!dibujar) return;

            Figuras figuras = new Figuras();
            figuras.DibujarFlecha(g, base_cuerpo, altura_cuerpo, base_cabeza, altura_cabeza);
        }

        private void pctGrafico_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Validador.Validar<int>(txtBaseCuerpo.Text) && Validador.Validar<int>(txtBaseCabeza.Text) && Validador.Validar<int>(txtAlturaCuerpo.Text) && Validador.Validar<int>(txtAlturaCabeza.Text) && (int.Parse(txtAlturaCuerpo.Text) < int.Parse(txtBaseCuerpo.Text)) && (int.Parse(txtAlturaCabeza.Text) > int.Parse(txtBaseCabeza.Text)) && (int.Parse(txtAlturaCuerpo.Text) < int.Parse(txtBaseCabeza.Text)))
            {
                base_cuerpo = int.Parse(txtBaseCuerpo.Text);
                base_cabeza = int.Parse(txtBaseCabeza.Text);
                altura_cuerpo = int.Parse(txtAlturaCuerpo.Text);
                altura_cabeza = int.Parse(txtAlturaCabeza.Text);
                Calculos calculos = new Calculos();
                dibujar = true;
                lblArea.Text = "Area: " + calculos.CalcularAreaFlecha(base_cuerpo, altura_cuerpo, base_cabeza, altura_cabeza);
                lblPerimetro.Text = "Perimetro: " + calculos.CalcularPerimetroFlecha(base_cuerpo, altura_cuerpo, base_cabeza, altura_cabeza);
                Invalidate();
                pctGrafico.Invalidate();
            }
            else if (int.Parse(txtAlturaCuerpo.Text) >= int.Parse(txtBaseCuerpo.Text) )
            {
                MessageBox.Show("Campo no valido, La altura del cuerpo debe ser menor que la base del cuerpo");
            }
            else if (int.Parse(txtAlturaCabeza.Text) <= int.Parse(txtBaseCabeza.Text))
            {
                MessageBox.Show("Campo no valido, la altura de la cabeza debe ser mayor que la base de la cabeza");
            }
            else if (int.Parse(txtAlturaCuerpo.Text) >= int.Parse(txtBaseCabeza.Text))
            {
                MessageBox.Show("Campo no valido, la base de la Cabeza debe ser mayor que la altura de la Cabeza");
            }
        }

        public FrmFlecha()
        {
            InitializeComponent();
        }

        private void txtBaseCuerpo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
