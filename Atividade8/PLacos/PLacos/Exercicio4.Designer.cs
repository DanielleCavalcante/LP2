namespace PLacos
{
    partial class Exercicio4
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lbProducao = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblGratificacao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtProducao = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtGratificacao = new System.Windows.Forms.TextBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(81, 63);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(81, 149);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(66, 25);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(490, 63);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(91, 25);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lbProducao
            // 
            this.lbProducao.AutoSize = true;
            this.lbProducao.Location = new System.Drawing.Point(490, 149);
            this.lbProducao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProducao.Name = "lbProducao";
            this.lbProducao.Size = new System.Drawing.Size(96, 25);
            this.lbProducao.TabIndex = 3;
            this.lbProducao.Text = "Produção";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(81, 251);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(73, 25);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salário";
            // 
            // lblGratificacao
            // 
            this.lblGratificacao.AutoSize = true;
            this.lblGratificacao.Location = new System.Drawing.Point(490, 251);
            this.lblGratificacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGratificacao.Name = "lblGratificacao";
            this.lblGratificacao.Size = new System.Drawing.Size(115, 25);
            this.lblGratificacao.TabIndex = 5;
            this.lblGratificacao.Text = "Gratificação";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(217, 52);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 30);
            this.txtNome.TabIndex = 6;
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(217, 139);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(213, 30);
            this.txtCargo.TabIndex = 7;
            // 
            // txtProducao
            // 
            this.txtProducao.Location = new System.Drawing.Point(627, 139);
            this.txtProducao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(213, 30);
            this.txtProducao.TabIndex = 8;
            this.txtProducao.Validated += new System.EventHandler(this.txtProducao_Validated);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(627, 52);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(213, 30);
            this.txtMatricula.TabIndex = 9;
            this.txtMatricula.Validated += new System.EventHandler(this.txtMatricula_Validated);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(217, 240);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(213, 30);
            this.txtSalario.TabIndex = 10;
            this.txtSalario.Validated += new System.EventHandler(this.txtSalario_Validated);
            // 
            // txtGratificacao
            // 
            this.txtGratificacao.Location = new System.Drawing.Point(627, 240);
            this.txtGratificacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGratificacao.Name = "txtGratificacao";
            this.txtGratificacao.Size = new System.Drawing.Size(213, 30);
            this.txtGratificacao.TabIndex = 11;
            this.txtGratificacao.Validated += new System.EventHandler(this.txtGratificacao_Validated);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(310, 343);
            this.txtSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(148, 30);
            this.txtSalarioBruto.TabIndex = 12;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(156, 349);
            this.lblSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(124, 25);
            this.lblSalarioBruto.TabIndex = 13;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(545, 335);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(211, 48);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Exercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 444);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.txtGratificacao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtProducao);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblGratificacao);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lbProducao);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exercicio4";
            this.Text = "Exercicio4";
            this.Load += new System.EventHandler(this.Exercicio4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lbProducao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblGratificacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtProducao;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtGratificacao;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Button btnCalcular;
    }
}