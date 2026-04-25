namespace shappes_2d
{
    partial class FrmTrianguloR
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHipotenusa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura:";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(92, 45);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 2;
            this.txtBase.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(92, 104);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(44, 168);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 4;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hipotenusa:";
            // 
            // txtHipotenusa
            // 
            this.txtHipotenusa.Location = new System.Drawing.Point(111, 238);
            this.txtHipotenusa.Name = "txtHipotenusa";
            this.txtHipotenusa.Size = new System.Drawing.Size(100, 20);
            this.txtHipotenusa.TabIndex = 6;
            this.txtHipotenusa.TextChanged += new System.EventHandler(this.txtHipotenusa_TextChanged);
            // 
            // FrmTrianguloR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHipotenusa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTrianguloR";
            this.Text = "Triangulo Rectangulo";
            this.Load += new System.EventHandler(this.FrmTrianguloR_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmTrianguloR_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHipotenusa;
    }
}