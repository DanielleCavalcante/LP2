namespace PLacos
{
    partial class Exercicio3
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
            this.txtTextoP = new System.Windows.Forms.TextBox();
            this.btnPalindromo = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTextoP
            // 
            this.txtTextoP.Location = new System.Drawing.Point(315, 119);
            this.txtTextoP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTextoP.MaxLength = 50;
            this.txtTextoP.Name = "txtTextoP";
            this.txtTextoP.Size = new System.Drawing.Size(347, 30);
            this.txtTextoP.TabIndex = 0;
            // 
            // btnPalindromo
            // 
            this.btnPalindromo.Location = new System.Drawing.Point(315, 211);
            this.btnPalindromo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPalindromo.Name = "btnPalindromo";
            this.btnPalindromo.Size = new System.Drawing.Size(347, 79);
            this.btnPalindromo.TabIndex = 1;
            this.btnPalindromo.Text = "Testar Palindromo";
            this.btnPalindromo.UseVisualStyleBackColor = true;
            this.btnPalindromo.Click += new System.EventHandler(this.btnPalindromo_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.AutoSize = true;
            this.txtTexto.Location = new System.Drawing.Point(225, 122);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(62, 25);
            this.txtTexto.TabIndex = 2;
            this.txtTexto.Text = "Texto";
            // 
            // Exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 447);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnPalindromo);
            this.Controls.Add(this.txtTextoP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercicio3";
            this.Text = "Exercicio3";
            this.Load += new System.EventHandler(this.Exercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoP;
        private System.Windows.Forms.Button btnPalindromo;
        private System.Windows.Forms.Label txtTexto;
    }
}