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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void miExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExample frmExample = new FrmExample();
            frmExample.MdiParent = this;
            frmExample.Show();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void rectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangulo frmRectangulo = new FrmRectangulo();
            frmRectangulo.MdiParent = this;
            frmRectangulo.Show();
        }

        private void miTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangulo frmTriangulo = new FrmTriangulo();
            frmTriangulo.MdiParent = this;
            frmTriangulo.Show();
        }

        private void miHexagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHexagono frmHexagono = new FrmHexagono();
            frmHexagono.MdiParent = this;
            frmHexagono.Show();
        }

        private void paralelogramoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paralelogramoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmParalelogramo frmParalelogramo = new FrmParalelogramo();
            frmParalelogramo.MdiParent = this;
            frmParalelogramo.Show();

        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRombo frmRombo = new FrmRombo();
            frmRombo.MdiParent = this;
            frmRombo.Show();
        }

        private void cometaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCometa frmCometa = new FrmCometa();
            frmCometa.MdiParent = this;
            frmCometa.Show();

        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrianguloE frmTrianguloE = new FrmTrianguloE();
            frmTrianguloE.MdiParent = this;
            frmTrianguloE.Show();

        }

        private void trianguloRectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrianguloR frmTrianguloR = new FrmTrianguloR();
            frmTrianguloR.MdiParent = this;
            frmTrianguloR.Show();
        }

        private void trianguloEscalenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrianguloEs frmTrianguloEs = new FrmTrianguloEs();
            frmTrianguloEs.MdiParent = this;
            frmTrianguloEs.Show();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCirculo frmCirculo = new FrmCirculo();
            frmCirculo.MdiParent = this;
            frmCirculo.Show();
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmElipse frmElipse = new FrmElipse();
            frmElipse.MdiParent = this;
            frmElipse.Show();
        }

        private void ovaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOvalo frmOvalo = new FrmOvalo();
            frmOvalo.MdiParent = this;
            frmOvalo.Show();
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangulo frmRectangulo = new FrmRectangulo();
            frmRectangulo.MdiParent = this;
            frmRectangulo.Show();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmCuadrado frmCuadrado = new FrmCuadrado();
            frmCuadrado.MdiParent = this;
            frmCuadrado.Show();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecio frmTrapecio = new FrmTrapecio();
            frmTrapecio.MdiParent = this;
            frmTrapecio.Show();
        }
    }
}
