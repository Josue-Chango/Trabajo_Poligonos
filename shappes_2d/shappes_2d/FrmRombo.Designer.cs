namespace shappes_2d
{
    partial class FrmRombo
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
            this.txtLado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(95, 43);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.txtLado.TabIndex = 1;
            this.txtLado.TextChanged += new System.EventHandler(this.txtLado_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angulo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAngulo
            // 
            this.txtAngulo.Location = new System.Drawing.Point(95, 100);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(100, 20);
            this.txtAngulo.TabIndex = 3;
            this.txtAngulo.TextChanged += new System.EventHandler(this.txtAngulo_TextChanged);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(38, 169);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 4;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // FrmRombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.txtAngulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.label1);
            this.Name = "FrmRombo";
            this.Text = "FrmRombo";
            this.Load += new System.EventHandler(this.FrmRombo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmRombo_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.Button btnDibujar;
    }
}