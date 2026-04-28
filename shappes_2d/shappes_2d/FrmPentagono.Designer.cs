namespace shappes_2d
{
    partial class FrmPentagono
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
            this.lblLado = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // pctGrafico
            // 
            this.pctGrafico.Location = new System.Drawing.Point(146, 12);
            this.pctGrafico.Name = "pctGrafico";
            this.pctGrafico.Size = new System.Drawing.Size(642, 351);
            this.pctGrafico.TabIndex = 0;
            this.pctGrafico.TabStop = false;
            this.pctGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pctGrafico_Paint);
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Location = new System.Drawing.Point(13, 22);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(45, 13);
            this.lblIngresar.TabIndex = 1;
            this.lblIngresar.Text = "Ingresar";
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(13, 48);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(31, 13);
            this.lblLado.TabIndex = 2;
            this.lblLado.Text = "Lado";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(51, 48);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(79, 20);
            this.txtLado.TabIndex = 3;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(13, 188);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(36, 13);
            this.lblSalida.TabIndex = 4;
            this.lblSalida.Text = "Salida";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(13, 214);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area: ";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(12, 239);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(57, 13);
            this.lblPerimetro.TabIndex = 6;
            this.lblPerimetro.Text = "Perimetro: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(13, 86);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(12, 115);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 8;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 144);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPentagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.pctGrafico);
            this.Name = "FrmPentagono";
            this.Text = "Pentagono";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmPentagono_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pctGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctGrafico;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnSalir;
    }
}