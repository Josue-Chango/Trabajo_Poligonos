namespace shappes_2d
{
    partial class FrmHexagono
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
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(10, 27);
            this.lblRadio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(41, 13);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Radio: ";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(52, 27);
            this.txtRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(76, 20);
            this.txtRadio.TabIndex = 1;
            this.txtRadio.TextChanged += new System.EventHandler(this.txtRadio_TextChanged);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(20, 78);
            this.btnDibujar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(56, 19);
            this.btnDibujar.TabIndex = 2;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Location = new System.Drawing.Point(232, 11);
            this.warning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(10, 13);
            this.warning.TabIndex = 3;
            this.warning.Text = " ";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(20, 124);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area: ";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(22, 149);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(57, 13);
            this.lblPerimetro.TabIndex = 5;
            this.lblPerimetro.Text = "Perimetro: ";
            // 
            // FrmHexagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHexagono";
            this.Text = "Hexagono";
            this.Load += new System.EventHandler(this.FrmHexagono_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmHexagono_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
    }
}