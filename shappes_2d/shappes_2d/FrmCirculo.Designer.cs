namespace shappes_2d
{
    partial class FrmCirculo
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
            this.lablIngresar = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lablIngresar
            // 
            this.lablIngresar.AutoSize = true;
            this.lablIngresar.Location = new System.Drawing.Point(33, 28);
            this.lablIngresar.Name = "lablIngresar";
            this.lablIngresar.Size = new System.Drawing.Size(51, 13);
            this.lablIngresar.TabIndex = 0;
            this.lablIngresar.Text = "Ingresar: ";
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(36, 45);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(35, 13);
            this.lblRadio.TabIndex = 1;
            this.lblRadio.Text = "Radio";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(78, 45);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 77);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(93, 77);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 4;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(174, 77);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(36, 121);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Area: ";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(36, 148);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(57, 13);
            this.lblPerimetro.TabIndex = 7;
            this.lblPerimetro.Text = "Perimetro: ";
            // 
            // FrmCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.lablIngresar);
            this.Name = "FrmCirculo";
            this.Text = "Circulo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmCirculo_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablIngresar;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
    }
}