namespace ProjetoMarcos.MGV
{
    partial class Clientes
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
            groupBox1 = new GroupBox();
            lblId = new Label();
            txtId = new TextBox();
            txtCelular = new TextBox();
            txtCpf = new TextBox();
            txtSobrenome = new TextBox();
            txtNome = new TextBox();
            lblNome = new Label();
            lblSobrenome = new Label();
            lblCpf = new Label();
            lblCelular = new Label();
            btnIncluir = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFechar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(btnIncluir);
            groupBox1.Controls.Add(lblCelular);
            groupBox1.Controls.Add(lblCpf);
            groupBox1.Controls.Add(lblSobrenome);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtSobrenome);
            groupBox1.Controls.Add(txtCpf);
            groupBox1.Controls.Add(txtCelular);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblId);
            groupBox1.Location = new Point(17, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 267);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(40, 50);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(92, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(57, 23);
            txtId.TabIndex = 1;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(92, 160);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(84, 23);
            txtCelular.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(92, 131);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(126, 23);
            txtCpf.TabIndex = 3;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(92, 102);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(126, 23);
            txtSobrenome.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(92, 73);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(84, 23);
            txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(40, 76);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(18, 105);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(68, 15);
            lblSobrenome.TabIndex = 7;
            lblSobrenome.Text = "Sobrenome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(40, 134);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 8;
            lblCpf.Text = "CPF";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(40, 163);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 9;
            lblCelular.Text = "Celular";
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(29, 212);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(82, 26);
            btnIncluir.TabIndex = 10;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(136, 212);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(82, 26);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(243, 212);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 26);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(343, 212);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(82, 26);
            btnFechar.TabIndex = 13;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Clientes";
            Text = "Clientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnFechar;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btnIncluir;
        private Label lblCelular;
        private Label lblCpf;
        private Label lblSobrenome;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private TextBox txtCpf;
        private TextBox txtCelular;
        private TextBox txtId;
        private Label lblId;
    }
}