namespace PTesteClasse
{
    partial class frmHorista
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
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.btnInstanciarHorista = new System.Windows.Forms.Button();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblSalarioHora = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtNumeroHora = new System.Windows.Forms.TextBox();
            this.lblNumeroHora = new System.Windows.Forms.Label();
            this.txtDiasFalta = new System.Windows.Forms.TextBox();
            this.lblDiasFalta = new System.Windows.Forms.Label();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHome
            // 
            this.gbxHome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbxHome.Controls.Add(this.rbtnSim);
            this.gbxHome.Controls.Add(this.rbtnNao);
            this.gbxHome.Location = new System.Drawing.Point(436, 78);
            this.gbxHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxHome.Size = new System.Drawing.Size(214, 125);
            this.gbxHome.TabIndex = 23;
            this.gbxHome.TabStop = false;
            this.gbxHome.Text = "Trabalha em Home Office";
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Checked = true;
            this.rbtnSim.Location = new System.Drawing.Point(26, 42);
            this.rbtnSim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(56, 24);
            this.rbtnSim.TabIndex = 10;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "SIM";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(26, 75);
            this.rbtnNao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(61, 24);
            this.rbtnNao.TabIndex = 11;
            this.rbtnNao.Text = "NÃO";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // btnInstanciarHorista
            // 
            this.btnInstanciarHorista.Location = new System.Drawing.Point(436, 267);
            this.btnInstanciarHorista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInstanciarHorista.Name = "btnInstanciarHorista";
            this.btnInstanciarHorista.Size = new System.Drawing.Size(214, 68);
            this.btnInstanciarHorista.TabIndex = 21;
            this.btnInstanciarHorista.Text = "Instanciar Horista";
            this.btnInstanciarHorista.UseVisualStyleBackColor = true;
            this.btnInstanciarHorista.Click += new System.EventHandler(this.btnInstanciarHorista_Click);
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(264, 258);
            this.txtDataEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(110, 26);
            this.txtDataEntrada.TabIndex = 20;
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.Location = new System.Drawing.Point(202, 156);
            this.txtSalarioHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(172, 26);
            this.txtSalarioHora.TabIndex = 19;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(148, 106);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 26);
            this.txtNome.TabIndex = 18;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(148, 55);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(226, 26);
            this.txtMatricula.TabIndex = 17;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(62, 264);
            this.lblDataEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(195, 20);
            this.lblDataEntrada.TabIndex = 16;
            this.lblDataEntrada.Text = "Data Entrada na Empresa";
            // 
            // lblSalarioHora
            // 
            this.lblSalarioHora.AutoSize = true;
            this.lblSalarioHora.Location = new System.Drawing.Point(62, 162);
            this.lblSalarioHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioHora.Name = "lblSalarioHora";
            this.lblSalarioHora.Size = new System.Drawing.Size(124, 20);
            this.lblSalarioHora.TabIndex = 15;
            this.lblSalarioHora.Text = "Salário por Hora";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(62, 112);
            this.lblnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(51, 20);
            this.lblnome.TabIndex = 14;
            this.lblnome.Text = "Nome";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(62, 61);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(73, 20);
            this.lblMatricula.TabIndex = 13;
            this.lblMatricula.Text = "Matrícula";
            // 
            // txtNumeroHora
            // 
            this.txtNumeroHora.Location = new System.Drawing.Point(206, 207);
            this.txtNumeroHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroHora.Name = "txtNumeroHora";
            this.txtNumeroHora.Size = new System.Drawing.Size(169, 26);
            this.txtNumeroHora.TabIndex = 25;
            // 
            // lblNumeroHora
            // 
            this.lblNumeroHora.AutoSize = true;
            this.lblNumeroHora.Location = new System.Drawing.Point(62, 213);
            this.lblNumeroHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroHora.Name = "lblNumeroHora";
            this.lblNumeroHora.Size = new System.Drawing.Size(134, 20);
            this.lblNumeroHora.TabIndex = 24;
            this.lblNumeroHora.Text = "Número de Horas";
            // 
            // txtDiasFalta
            // 
            this.txtDiasFalta.Location = new System.Drawing.Point(202, 308);
            this.txtDiasFalta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiasFalta.Name = "txtDiasFalta";
            this.txtDiasFalta.Size = new System.Drawing.Size(172, 26);
            this.txtDiasFalta.TabIndex = 27;
            // 
            // lblDiasFalta
            // 
            this.lblDiasFalta.AutoSize = true;
            this.lblDiasFalta.Location = new System.Drawing.Point(62, 315);
            this.lblDiasFalta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiasFalta.Name = "lblDiasFalta";
            this.lblDiasFalta.Size = new System.Drawing.Size(111, 20);
            this.lblDiasFalta.TabIndex = 26;
            this.lblDiasFalta.Text = "Dias de Faltas";
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 400);
            this.Controls.Add(this.txtDiasFalta);
            this.Controls.Add(this.lblDiasFalta);
            this.Controls.Add(this.txtNumeroHora);
            this.Controls.Add(this.lblNumeroHora);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.btnInstanciarHorista);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.txtSalarioHora);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblSalarioHora);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblMatricula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHorista";
            this.Text = "Horista";
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.Button btnInstanciarHorista;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.TextBox txtSalarioHora;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblSalarioHora;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtNumeroHora;
        private System.Windows.Forms.Label lblNumeroHora;
        private System.Windows.Forms.TextBox txtDiasFalta;
        private System.Windows.Forms.Label lblDiasFalta;
    }
}