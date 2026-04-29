namespace shappes_2d
{
    partial class FrmFlecha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctGrafico = new System.Windows.Forms.PictureBox();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.lblbCuerpo = new System.Windows.Forms.Label();
            this.lblBaseCuerpo = new System.Windows.Forms.Label();
            this.lblAlturaCuerpo = new System.Windows.Forms.Label();
            this.txtBaseCuerpo = new System.Windows.Forms.TextBox();
            this.txtAlturaCuerpo = new System.Windows.Forms.TextBox();
            this.lblCabeza = new System.Windows.Forms.Label();
            this.lblBaseCabeza = new System.Windows.Forms.Label();
            this.txtBaseCabeza = new System.Windows.Forms.TextBox();
            this.lblAlturaCabeza = new System.Windows.Forms.Label();
            this.txtAlturaCabeza = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // pctGrafico
            // 
            this.pctGrafico.Location = new System.Drawing.Point(167, 13);
            this.pctGrafico.Name = "pctGrafico";
            this.pctGrafico.Size = new System.Drawing.Size(895, 533);
            this.pctGrafico.TabIndex = 0;
            this.pctGrafico.TabStop = false;
            this.pctGrafico.Click += new System.EventHandler(this.pctGrafico_Click);
            this.pctGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Location = new System.Drawing.Point(13, 13);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(56, 16);
            this.lblIngresar.TabIndex = 1;
            this.lblIngresar.Text = "Ingresar";
            // 
            // lblbCuerpo
            // 
            this.lblbCuerpo.AutoSize = true;
            this.lblbCuerpo.Location = new System.Drawing.Point(13, 44);
            this.lblbCuerpo.Name = "lblbCuerpo";
            this.lblbCuerpo.Size = new System.Drawing.Size(123, 16);
            this.lblbCuerpo.TabIndex = 2;
            this.lblbCuerpo.Text = "Cuerpo de la flecha";
            // 
            // lblBaseCuerpo
            // 
            this.lblBaseCuerpo.AutoSize = true;
            this.lblBaseCuerpo.Location = new System.Drawing.Point(16, 73);
            this.lblBaseCuerpo.Name = "lblBaseCuerpo";
            this.lblBaseCuerpo.Size = new System.Drawing.Size(39, 16);
            this.lblBaseCuerpo.TabIndex = 3;
            this.lblBaseCuerpo.Text = "Base";
            // 
            // lblAlturaCuerpo
            // 
            this.lblAlturaCuerpo.AutoSize = true;
            this.lblAlturaCuerpo.Location = new System.Drawing.Point(16, 112);
            this.lblAlturaCuerpo.Name = "lblAlturaCuerpo";
            this.lblAlturaCuerpo.Size = new System.Drawing.Size(41, 16);
            this.lblAlturaCuerpo.TabIndex = 4;
            this.lblAlturaCuerpo.Text = "Altura";
            // 
            // txtBaseCuerpo
            // 
            this.txtBaseCuerpo.Location = new System.Drawing.Point(61, 70);
            this.txtBaseCuerpo.Name = "txtBaseCuerpo";
            this.txtBaseCuerpo.Size = new System.Drawing.Size(100, 22);
            this.txtBaseCuerpo.TabIndex = 5;
            this.txtBaseCuerpo.TextChanged += new System.EventHandler(this.txtBaseCuerpo_TextChanged);
            // 
            // txtAlturaCuerpo
            // 
            this.txtAlturaCuerpo.Location = new System.Drawing.Point(61, 109);
            this.txtAlturaCuerpo.Name = "txtAlturaCuerpo";
            this.txtAlturaCuerpo.Size = new System.Drawing.Size(100, 22);
            this.txtAlturaCuerpo.TabIndex = 6;
            this.txtAlturaCuerpo.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // lblCabeza
            // 
            this.lblCabeza.AutoSize = true;
            this.lblCabeza.Location = new System.Drawing.Point(16, 154);
            this.lblCabeza.Name = "lblCabeza";
            this.lblCabeza.Size = new System.Drawing.Size(131, 16);
            this.lblCabeza.TabIndex = 7;
            this.lblCabeza.Text = "Cabeza de la Flecha";
            // 
            // lblBaseCabeza
            // 
            this.lblBaseCabeza.AutoSize = true;
            this.lblBaseCabeza.Location = new System.Drawing.Point(20, 195);
            this.lblBaseCabeza.Name = "lblBaseCabeza";
            this.lblBaseCabeza.Size = new System.Drawing.Size(39, 16);
            this.lblBaseCabeza.TabIndex = 8;
            this.lblBaseCabeza.Text = "Base";
            // 
            // txtBaseCabeza
            // 
            this.txtBaseCabeza.Location = new System.Drawing.Point(61, 192);
            this.txtBaseCabeza.Name = "txtBaseCabeza";
            this.txtBaseCabeza.Size = new System.Drawing.Size(100, 22);
            this.txtBaseCabeza.TabIndex = 9;
            // 
            // lblAlturaCabeza
            // 
            this.lblAlturaCabeza.AutoSize = true;
            this.lblAlturaCabeza.Location = new System.Drawing.Point(16, 227);
            this.lblAlturaCabeza.Name = "lblAlturaCabeza";
            this.lblAlturaCabeza.Size = new System.Drawing.Size(41, 16);
            this.lblAlturaCabeza.TabIndex = 10;
            this.lblAlturaCabeza.Text = "Altura";
            // 
            // txtAlturaCabeza
            // 
            this.txtAlturaCabeza.Location = new System.Drawing.Point(61, 227);
            this.txtAlturaCabeza.Name = "txtAlturaCabeza";
            this.txtAlturaCabeza.Size = new System.Drawing.Size(100, 22);
            this.txtAlturaCabeza.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(40, 274);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(40, 313);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 13;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(40, 351);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(13, 400);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 16);
            this.lblArea.TabIndex = 15;
            this.lblArea.Text = "Area: ";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(11, 426);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(71, 16);
            this.lblPerimetro.TabIndex = 16;
            this.lblPerimetro.Text = "Perimetro: ";
            // 
            // FrmFlecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 558);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAlturaCabeza);
            this.Controls.Add(this.lblAlturaCabeza);
            this.Controls.Add(this.txtBaseCabeza);
            this.Controls.Add(this.lblBaseCabeza);
            this.Controls.Add(this.lblCabeza);
            this.Controls.Add(this.txtAlturaCuerpo);
            this.Controls.Add(this.txtBaseCuerpo);
            this.Controls.Add(this.lblAlturaCuerpo);
            this.Controls.Add(this.lblBaseCuerpo);
            this.Controls.Add(this.lblbCuerpo);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.pctGrafico);
            this.Name = "FrmFlecha";
            this.Text = "Flecha Horizontal";
            ((System.ComponentModel.ISupportInitialize)(this.pctGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctGrafico;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Label lblbCuerpo;
        private System.Windows.Forms.Label lblBaseCuerpo;
        private System.Windows.Forms.Label lblAlturaCuerpo;
        private System.Windows.Forms.TextBox txtBaseCuerpo;
        private System.Windows.Forms.TextBox txtAlturaCuerpo;
        private System.Windows.Forms.Label lblCabeza;
        private System.Windows.Forms.Label lblBaseCabeza;
        private System.Windows.Forms.TextBox txtBaseCabeza;
        private System.Windows.Forms.Label lblAlturaCabeza;
        private System.Windows.Forms.TextBox txtAlturaCabeza;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
    }
}