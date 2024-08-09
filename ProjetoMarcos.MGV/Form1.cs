namespace ProjetoMarcos.MGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros cadastros = new Cadastros();
            cadastros.Show();
        }



        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.Show();
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colaboradores colaboradores = new Colaboradores();
            colaboradores.Show();
        }
    }
}

