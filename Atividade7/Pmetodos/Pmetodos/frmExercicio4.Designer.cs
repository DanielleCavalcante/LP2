namespace Pmetodos
{
    partial class frmExercicio4
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
            this.btnCaracterAlfabetico = new System.Windows.Forms.Button();
            this.btnCaracterBranco = new System.Windows.Forms.Button();
            this.btnCaracterNum = new System.Windows.Forms.Button();
            this.rchtxrbxTexto = new System.Windows.Forms.RichTextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCaracterAlfabetico
            // 
            this.btnCaracterAlfabetico.Location = new System.Drawing.Point(342, 180);
            this.btnCaracterAlfabetico.Name = "btnCaracterAlfabetico";
            this.btnCaracterAlfabetico.Size = new System.Drawing.Size(106, 62);
            this.btnCaracterAlfabetico.TabIndex = 11;
            this.btnCaracterAlfabetico.Text = "Quantidade caracter alfabéticos";
            this.btnCaracterAlfabetico.UseVisualStyleBackColor = true;
            this.btnCaracterAlfabetico.Click += new System.EventHandler(this.btnCaracterAlfabetico_Click);
            // 
            // btnCaracterBranco
            // 
            this.btnCaracterBranco.Location = new System.Drawing.Point(211, 180);
            this.btnCaracterBranco.Name = "btnCaracterBranco";
            this.btnCaracterBranco.Size = new System.Drawing.Size(106, 62);
            this.btnCaracterBranco.TabIndex = 10;
            this.btnCaracterBranco.Text = "Primeiro caracter branco";
            this.btnCaracterBranco.UseVisualStyleBackColor = true;
            this.btnCaracterBranco.Click += new System.EventHandler(this.btnCaracterBranco_Click);
            // 
            // btnCaracterNum
            // 
            this.btnCaracterNum.Location = new System.Drawing.Point(80, 180);
            this.btnCaracterNum.Name = "btnCaracterNum";
            this.btnCaracterNum.Size = new System.Drawing.Size(106, 62);
            this.btnCaracterNum.TabIndex = 9;
            this.btnCaracterNum.Text = "Quantidade de caracteres numérico";
            this.btnCaracterNum.UseVisualStyleBackColor = true;
            this.btnCaracterNum.Click += new System.EventHandler(this.btnCaracterNum_Click);
            // 
            // rchtxrbxTexto
            // 
            this.rchtxrbxTexto.Location = new System.Drawing.Point(158, 73);
            this.rchtxrbxTexto.Name = "rchtxrbxTexto";
            this.rchtxrbxTexto.Size = new System.Drawing.Size(206, 36);
            this.rchtxrbxTexto.TabIndex = 14;
            this.rchtxrbxTexto.Text = "";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(155, 57);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(80, 13);
            this.lblTexto.TabIndex = 15;
            this.lblTexto.Text = "Digite seu texto";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 302);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.rchtxrbxTexto);
            this.Controls.Add(this.btnCaracterAlfabetico);
            this.Controls.Add(this.btnCaracterBranco);
            this.Controls.Add(this.btnCaracterNum);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCaracterAlfabetico;
        private System.Windows.Forms.Button btnCaracterBranco;
        private System.Windows.Forms.Button btnCaracterNum;
        private System.Windows.Forms.RichTextBox rchtxrbxTexto;
        private System.Windows.Forms.Label lblTexto;
    }
}