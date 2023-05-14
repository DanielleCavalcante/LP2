namespace PLacos
{
    partial class Exercicio2
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
            this.lblNumeroH = new System.Windows.Forms.Label();
            this.lblNumeroN = new System.Windows.Forms.Label();
            this.txtNumeroH = new System.Windows.Forms.TextBox();
            this.txtNumeroN = new System.Windows.Forms.TextBox();
            this.btnGerarH = new System.Windows.Forms.Button();
            this.btnTestarN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroH
            // 
            this.lblNumeroH.AutoSize = true;
            this.lblNumeroH.Location = new System.Drawing.Point(105, 134);
            this.lblNumeroH.Name = "lblNumeroH";
            this.lblNumeroH.Size = new System.Drawing.Size(100, 25);
            this.lblNumeroH.TabIndex = 0;
            this.lblNumeroH.Text = "Número H";
            // 
            // lblNumeroN
            // 
            this.lblNumeroN.AutoSize = true;
            this.lblNumeroN.Location = new System.Drawing.Point(467, 131);
            this.lblNumeroN.Name = "lblNumeroN";
            this.lblNumeroN.Size = new System.Drawing.Size(100, 25);
            this.lblNumeroN.TabIndex = 1;
            this.lblNumeroN.Text = "Número N";
            // 
            // txtNumeroH
            // 
            this.txtNumeroH.Enabled = false;
            this.txtNumeroH.Location = new System.Drawing.Point(238, 131);
            this.txtNumeroH.Name = "txtNumeroH";
            this.txtNumeroH.ReadOnly = true;
            this.txtNumeroH.Size = new System.Drawing.Size(207, 30);
            this.txtNumeroH.TabIndex = 2;
            // 
            // txtNumeroN
            // 
            this.txtNumeroN.Location = new System.Drawing.Point(591, 128);
            this.txtNumeroN.Name = "txtNumeroN";
            this.txtNumeroN.Size = new System.Drawing.Size(207, 30);
            this.txtNumeroN.TabIndex = 3;
            // 
            // btnGerarH
            // 
            this.btnGerarH.Location = new System.Drawing.Point(214, 223);
            this.btnGerarH.Name = "btnGerarH";
            this.btnGerarH.Size = new System.Drawing.Size(239, 66);
            this.btnGerarH.TabIndex = 4;
            this.btnGerarH.Text = "Gerar Número H";
            this.btnGerarH.UseVisualStyleBackColor = true;
            this.btnGerarH.Click += new System.EventHandler(this.btnGerarH_Click);
            // 
            // btnTestarN
            // 
            this.btnTestarN.Location = new System.Drawing.Point(499, 223);
            this.btnTestarN.Name = "btnTestarN";
            this.btnTestarN.Size = new System.Drawing.Size(239, 66);
            this.btnTestarN.TabIndex = 5;
            this.btnTestarN.Text = "Testar Número N";
            this.btnTestarN.UseVisualStyleBackColor = true;
            this.btnTestarN.Click += new System.EventHandler(this.btnTestarN_Click);
            // 
            // Exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 441);
            this.Controls.Add(this.btnTestarN);
            this.Controls.Add(this.btnGerarH);
            this.Controls.Add(this.txtNumeroN);
            this.Controls.Add(this.txtNumeroH);
            this.Controls.Add(this.lblNumeroN);
            this.Controls.Add(this.lblNumeroH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercicio2";
            this.Text = "Exercicio2";
            this.Load += new System.EventHandler(this.Exercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroH;
        private System.Windows.Forms.Label lblNumeroN;
        private System.Windows.Forms.TextBox txtNumeroH;
        private System.Windows.Forms.TextBox txtNumeroN;
        private System.Windows.Forms.Button btnGerarH;
        private System.Windows.Forms.Button btnTestarN;
    }
}