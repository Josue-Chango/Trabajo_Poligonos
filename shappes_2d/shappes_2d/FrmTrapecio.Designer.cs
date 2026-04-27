namespace shappes_2d
{
    partial class FrmTrapecio
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
            this.lblBaseMayor = new System.Windows.Forms.Label();
            this.lblBaseMenor = new System.Windows.Forms.Label();
            this.lblLadoIzquierdo = new System.Windows.Forms.Label();
            this.lblLadoDerecho = new System.Windows.Forms.Label();
            this.txtBaseMayor = new System.Windows.Forms.TextBox();
            this.txtBaseMenor = new System.Windows.Forms.TextBox();
            this.txtLadoIzquierdo = new System.Windows.Forms.TextBox();
            this.txtLadoDerecho = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar";
            // 
            // lblBaseMayor
            // 
            this.lblBaseMayor.AutoSize = true;
            this.lblBaseMayor.Location = new System.Drawing.Point(16, 39);
            this.lblBaseMayor.Name = "lblBaseMayor";
            this.lblBaseMayor.Size = new System.Drawing.Size(63, 13);
            this.lblBaseMayor.TabIndex = 1;
            this.lblBaseMayor.Text = "Base Mayor";
            // 
            // lblBaseMenor
            // 
            this.lblBaseMenor.AutoSize = true;
            this.lblBaseMenor.Location = new System.Drawing.Point(16, 61);
            this.lblBaseMenor.Name = "lblBaseMenor";
            this.lblBaseMenor.Size = new System.Drawing.Size(64, 13);
            this.lblBaseMenor.TabIndex = 2;
            this.lblBaseMenor.Text = "Base Menor";
            // 
            // lblLadoIzquierdo
            // 
            this.lblLadoIzquierdo.AutoSize = true;
            this.lblLadoIzquierdo.Location = new System.Drawing.Point(16, 84);
            this.lblLadoIzquierdo.Name = "lblLadoIzquierdo";
            this.lblLadoIzquierdo.Size = new System.Drawing.Size(77, 13);
            this.lblLadoIzquierdo.TabIndex = 3;
            this.lblLadoIzquierdo.Text = "Lado Izquierdo";
            // 
            // lblLadoDerecho
            // 
            this.lblLadoDerecho.AutoSize = true;
            this.lblLadoDerecho.Location = new System.Drawing.Point(16, 106);
            this.lblLadoDerecho.Name = "lblLadoDerecho";
            this.lblLadoDerecho.Size = new System.Drawing.Size(75, 13);
            this.lblLadoDerecho.TabIndex = 4;
            this.lblLadoDerecho.Text = "Lado Derecho";
            // 
            // txtBaseMayor
            // 
            this.txtBaseMayor.Location = new System.Drawing.Point(104, 39);
            this.txtBaseMayor.Name = "txtBaseMayor";
            this.txtBaseMayor.Size = new System.Drawing.Size(100, 20);
            this.txtBaseMayor.TabIndex = 5;
            // 
            // txtBaseMenor
            // 
            this.txtBaseMenor.Location = new System.Drawing.Point(104, 61);
            this.txtBaseMenor.Name = "txtBaseMenor";
            this.txtBaseMenor.Size = new System.Drawing.Size(100, 20);
            this.txtBaseMenor.TabIndex = 6;
            // 
            // txtLadoIzquierdo
            // 
            this.txtLadoIzquierdo.Location = new System.Drawing.Point(104, 84);
            this.txtLadoIzquierdo.Name = "txtLadoIzquierdo";
            this.txtLadoIzquierdo.Size = new System.Drawing.Size(100, 20);
            this.txtLadoIzquierdo.TabIndex = 7;
            // 
            // txtLadoDerecho
            // 
            this.txtLadoDerecho.Location = new System.Drawing.Point(104, 106);
            this.txtLadoDerecho.Name = "txtLadoDerecho";
            this.txtLadoDerecho.Size = new System.Drawing.Size(100, 20);
            this.txtLadoDerecho.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(19, 141);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(104, 140);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 10;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(185, 141);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(19, 171);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(36, 13);
            this.lblSalida.TabIndex = 12;
            this.lblSalida.Text = "Salida";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(22, 201);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 13;
            this.lblArea.Text = "Area: ";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(22, 229);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(57, 13);
            this.lblPerimetro.TabIndex = 14;
            this.lblPerimetro.Text = "Perimetro: ";
            // 
            // FrmTrapecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLadoDerecho);
            this.Controls.Add(this.txtLadoIzquierdo);
            this.Controls.Add(this.txtBaseMenor);
            this.Controls.Add(this.txtBaseMayor);
            this.Controls.Add(this.lblLadoDerecho);
            this.Controls.Add(this.lblLadoIzquierdo);
            this.Controls.Add(this.lblBaseMenor);
            this.Controls.Add(this.lblBaseMayor);
            this.Controls.Add(this.label1);
            this.Name = "FrmTrapecio";
            this.Text = "Trapecio";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmTrapecio_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBaseMayor;
        private System.Windows.Forms.Label lblBaseMenor;
        private System.Windows.Forms.Label lblLadoIzquierdo;
        private System.Windows.Forms.Label lblLadoDerecho;
        private System.Windows.Forms.TextBox txtBaseMayor;
        private System.Windows.Forms.TextBox txtBaseMenor;
        private System.Windows.Forms.TextBox txtLadoIzquierdo;
        private System.Windows.Forms.TextBox txtLadoDerecho;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
    }
}