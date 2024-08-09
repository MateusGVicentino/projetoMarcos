namespace ProjetoMarcos.MGV
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
            menuStrip1 = new MenuStrip();
            telasDeFormularioToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            colaboradoresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { telasDeFormularioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // telasDeFormularioToolStripMenuItem
            // 
            telasDeFormularioToolStripMenuItem.BackColor = Color.Gold;
            telasDeFormularioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, fornecedoresToolStripMenuItem, clienteToolStripMenuItem, produtosToolStripMenuItem, colaboradoresToolStripMenuItem });
            telasDeFormularioToolStripMenuItem.Name = "telasDeFormularioToolStripMenuItem";
            telasDeFormularioToolStripMenuItem.Size = new Size(121, 20);
            telasDeFormularioToolStripMenuItem.Text = "Telas de Formulario";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(180, 22);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            cadastrosToolStripMenuItem.Click += cadastrosToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(180, 22);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            fornecedoresToolStripMenuItem.Click += fornecedoresToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(180, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(180, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click_1;
            // 
            // colaboradoresToolStripMenuItem
            // 
            colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            colaboradoresToolStripMenuItem.Size = new Size(180, 22);
            colaboradoresToolStripMenuItem.Text = "Colaboradores";
            colaboradoresToolStripMenuItem.Click += colaboradoresToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem telasDeFormularioToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem colaboradoresToolStripMenuItem;
    }
}
