namespace Pmetodos
{
    partial class frmExercicio2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnIguais = new System.Windows.Forms.Button();
            this.btnInserirTexto = new System.Windows.Forms.Button();
            this.btnInserirAsteriscos = new System.Windows.Forms.Button();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(218, 52);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(136, 20);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(218, 93);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(136, 20);
            this.txtPalavra2.TabIndex = 1;
            // 
            // btnIguais
            // 
            this.btnIguais.Location = new System.Drawing.Point(43, 171);
            this.btnIguais.Name = "btnIguais";
            this.btnIguais.Size = new System.Drawing.Size(106, 62);
            this.btnIguais.TabIndex = 2;
            this.btnIguais.Text = "Testar iguais";
            this.btnIguais.UseVisualStyleBackColor = true;
            this.btnIguais.Click += new System.EventHandler(this.btnIguais_Click);
            // 
            // btnInserirTexto
            // 
            this.btnInserirTexto.Location = new System.Drawing.Point(174, 171);
            this.btnInserirTexto.Name = "btnInserirTexto";
            this.btnInserirTexto.Size = new System.Drawing.Size(106, 62);
            this.btnInserirTexto.TabIndex = 3;
            this.btnInserirTexto.Text = "Inserir texto 1 no texto 2";
            this.btnInserirTexto.UseVisualStyleBackColor = true;
            this.btnInserirTexto.Click += new System.EventHandler(this.btnInserirTexto_Click);
            // 
            // btnInserirAsteriscos
            // 
            this.btnInserirAsteriscos.Location = new System.Drawing.Point(305, 171);
            this.btnInserirAsteriscos.Name = "btnInserirAsteriscos";
            this.btnInserirAsteriscos.Size = new System.Drawing.Size(106, 62);
            this.btnInserirAsteriscos.TabIndex = 4;
            this.btnInserirAsteriscos.Text = "Inserir asteriscos no texto 1";
            this.btnInserirAsteriscos.UseVisualStyleBackColor = true;
            this.btnInserirAsteriscos.Click += new System.EventHandler(this.btnInserirAsteriscos_Click);
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(114, 55);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 5;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(114, 96);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 6;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 284);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.btnInserirAsteriscos);
            this.Controls.Add(this.btnInserirTexto);
            this.Controls.Add(this.btnIguais);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "Exercício 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnIguais;
        private System.Windows.Forms.Button btnInserirTexto;
        private System.Windows.Forms.Button btnInserirAsteriscos;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
    }
}