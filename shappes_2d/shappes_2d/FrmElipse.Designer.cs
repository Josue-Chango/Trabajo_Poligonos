namespace shappes_2d
{
    partial class FrmElipse
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
            this.lblIngresar = new System.Windows.Forms.Label();
            this.lblSemiejeMayor = new System.Windows.Forms.Label();
            this.lblSemiejeMenor = new System.Windows.Forms.Label();
            this.txtSMayor = new System.Windows.Forms.TextBox();
            this.txtSMenor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Location = new System.Drawing.Point(13, 13);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(45, 13);
            this.lblIngresar.TabIndex = 0;
            this.lblIngresar.Text = "Ingresar";
            // 
            // lblSemiejeMayor
            // 
            this.lblSemiejeMayor.AutoSize = true;
            this.lblSemiejeMayor.Location = new System.Drawing.Point(16, 39);
            this.lblSemiejeMayor.Name = "lblSemiejeMayor";
            this.lblSemiejeMayor.Size = new System.Drawing.Size(79, 13);
            this.lblSemiejeMayor.TabIndex = 1;
            this.lblSemiejeMayor.Text = "Semi-eje Mayor";
            // 
            // lblSemiejeMenor
            // 
            this.lblSemiejeMenor.AutoSize = true;
            this.lblSemiejeMenor.Location = new System.Drawing.Point(16, 69);
            this.lblSemiejeMenor.Name = "lblSemiejeMenor";
            this.lblSemiejeMenor.Size = new System.Drawing.Size(80, 13);
            this.lblSemiejeMenor.TabIndex = 2;
            this.lblSemiejeMenor.Text = "Semi-eje Menor";
            // 
            // txtSMayor
            // 
            this.txtSMayor.Location = new System.Drawing.Point(106, 32);
            this.txtSMayor.Name = "txtSMayor";
            this.txtSMayor.Size = new System.Drawing.Size(100, 20);
            this.txtSMayor.TabIndex = 3;
            // 
            // txtSMenor
            // 
            this.txtSMenor.Location = new System.Drawing.Point(106, 66);
            this.txtSMenor.Name = "txtSMenor";
            this.txtSMenor.Size = new System.Drawing.Size(100, 20);
            this.txtSMenor.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(19, 107);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(106, 106);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 6;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(187, 107);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(19, 154);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area: ";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(19, 182);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(57, 13);
            this.lblPerimetro.TabIndex = 9;
            this.lblPerimetro.Text = "Perimetro: ";
            // 
            // FrmElipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSMenor);
            this.Controls.Add(this.txtSMayor);
            this.Controls.Add(this.lblSemiejeMenor);
            this.Controls.Add(this.lblSemiejeMayor);
            this.Controls.Add(this.lblIngresar);
            this.Name = "FrmElipse";
            this.Text = "Elipse";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmElipse_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Label lblSemiejeMayor;
        private System.Windows.Forms.Label lblSemiejeMenor;
        private System.Windows.Forms.TextBox txtSMayor;
        private System.Windows.Forms.TextBox txtSMenor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
    }
}