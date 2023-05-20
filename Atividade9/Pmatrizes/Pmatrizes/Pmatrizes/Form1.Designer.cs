namespace Pmatrizes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInverterVetor = new Button();
            btnMercadoria = new Button();
            brnVerificarTotal = new Button();
            btnComprimento = new Button();
            btnMedia = new Button();
            btnListaAluno = new Button();
            SuspendLayout();
            // 
            // btnInverterVetor
            // 
            btnInverterVetor.Location = new Point(90, 101);
            btnInverterVetor.Margin = new Padding(4, 6, 4, 6);
            btnInverterVetor.Name = "btnInverterVetor";
            btnInverterVetor.Size = new Size(209, 122);
            btnInverterVetor.TabIndex = 0;
            btnInverterVetor.Text = "Carregar Vetor e Inverter";
            btnInverterVetor.UseVisualStyleBackColor = true;
            btnInverterVetor.Click += btnInverterVetor_Click;
            // 
            // btnMercadoria
            // 
            btnMercadoria.Location = new Point(349, 101);
            btnMercadoria.Margin = new Padding(4, 6, 4, 6);
            btnMercadoria.Name = "btnMercadoria";
            btnMercadoria.Size = new Size(209, 122);
            btnMercadoria.TabIndex = 1;
            btnMercadoria.Text = "Ler Dados de Mercadoria";
            btnMercadoria.UseVisualStyleBackColor = true;
            btnMercadoria.Click += btnMercadoria_Click;
            // 
            // brnVerificarTotal
            // 
            brnVerificarTotal.Location = new Point(609, 101);
            brnVerificarTotal.Margin = new Padding(4, 6, 4, 6);
            brnVerificarTotal.Name = "brnVerificarTotal";
            brnVerificarTotal.Size = new Size(209, 122);
            brnVerificarTotal.TabIndex = 2;
            brnVerificarTotal.Text = "Verificar Total";
            brnVerificarTotal.UseVisualStyleBackColor = true;
            brnVerificarTotal.Click += brnVerificarTotal_Click;
            // 
            // btnComprimento
            // 
            btnComprimento.Location = new Point(609, 294);
            btnComprimento.Margin = new Padding(4, 6, 4, 6);
            btnComprimento.Name = "btnComprimento";
            btnComprimento.Size = new Size(209, 122);
            btnComprimento.TabIndex = 5;
            btnComprimento.Text = "Comprimento do Nome";
            btnComprimento.UseVisualStyleBackColor = true;
            btnComprimento.Click += btnComprimento_Click;
            // 
            // btnMedia
            // 
            btnMedia.Location = new Point(349, 294);
            btnMedia.Margin = new Padding(4, 6, 4, 6);
            btnMedia.Name = "btnMedia";
            btnMedia.Size = new Size(209, 122);
            btnMedia.TabIndex = 4;
            btnMedia.Text = "Média Nota";
            btnMedia.UseVisualStyleBackColor = true;
            btnMedia.Click += btnMedia_Click;
            // 
            // btnListaAluno
            // 
            btnListaAluno.Location = new Point(90, 294);
            btnListaAluno.Margin = new Padding(4, 6, 4, 6);
            btnListaAluno.Name = "btnListaAluno";
            btnListaAluno.Size = new Size(209, 122);
            btnListaAluno.TabIndex = 3;
            btnListaAluno.Text = "Lista de Alunos";
            btnListaAluno.UseVisualStyleBackColor = true;
            btnListaAluno.Click += btnListaAluno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 512);
            Controls.Add(btnComprimento);
            Controls.Add(btnMedia);
            Controls.Add(btnListaAluno);
            Controls.Add(brnVerificarTotal);
            Controls.Add(btnMercadoria);
            Controls.Add(btnInverterVetor);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInverterVetor;
        private Button btnMercadoria;
        private Button brnVerificarTotal;
        private Button btnComprimento;
        private Button btnMedia;
        private Button btnListaAluno;
    }
}