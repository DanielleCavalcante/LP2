namespace PLacos
{
    partial class Exercicio1
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnEspacoBranco = new System.Windows.Forms.Button();
            this.btnQtdeR = new System.Windows.Forms.Button();
            this.btnLetrasRepetidas = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(88, 71);
            this.rchtxtFrase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(754, 110);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnEspacoBranco
            // 
            this.btnEspacoBranco.Location = new System.Drawing.Point(548, 238);
            this.btnEspacoBranco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEspacoBranco.Name = "btnEspacoBranco";
            this.btnEspacoBranco.Size = new System.Drawing.Size(294, 57);
            this.btnEspacoBranco.TabIndex = 1;
            this.btnEspacoBranco.Text = "Número de espaços em branco";
            this.btnEspacoBranco.UseVisualStyleBackColor = true;
            this.btnEspacoBranco.Click += new System.EventHandler(this.btnEspacoBranco_Click);
            // 
            // btnQtdeR
            // 
            this.btnQtdeR.Location = new System.Drawing.Point(329, 238);
            this.btnQtdeR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQtdeR.Name = "btnQtdeR";
            this.btnQtdeR.Size = new System.Drawing.Size(216, 57);
            this.btnQtdeR.TabIndex = 2;
            this.btnQtdeR.Text = "Quantidade de \"R\'s\"";
            this.btnQtdeR.UseVisualStyleBackColor = true;
            this.btnQtdeR.Click += new System.EventHandler(this.btnQtdeR_Click);
            // 
            // btnLetrasRepetidas
            // 
            this.btnLetrasRepetidas.Location = new System.Drawing.Point(88, 238);
            this.btnLetrasRepetidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLetrasRepetidas.Name = "btnLetrasRepetidas";
            this.btnLetrasRepetidas.Size = new System.Drawing.Size(233, 57);
            this.btnLetrasRepetidas.TabIndex = 3;
            this.btnLetrasRepetidas.Text = "Par de letras repetidas";
            this.btnLetrasRepetidas.UseVisualStyleBackColor = true;
            this.btnLetrasRepetidas.Click += new System.EventHandler(this.btnLetrasRepetidas_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(642, 327);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(170, 30);
            this.txtResultado.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(536, 333);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(99, 25);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            // 
            // Exercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 442);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnLetrasRepetidas);
            this.Controls.Add(this.btnQtdeR);
            this.Controls.Add(this.btnEspacoBranco);
            this.Controls.Add(this.rchtxtFrase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercicio1";
            this.Text = "frmExercicio1";
            this.Load += new System.EventHandler(this.Exercicio1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnEspacoBranco;
        private System.Windows.Forms.Button btnQtdeR;
        private System.Windows.Forms.Button btnLetrasRepetidas;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}