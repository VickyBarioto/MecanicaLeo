namespace Trabalho_Leo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendedor vendedorForm = new Vendedor(); // Instancia o formul�rio Vendedor
            vendedorForm.Show(); // Exibe o formul�rio Vendedor

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente clienteForm = new Cliente(); // Instancia o formul�rio Clientes
            clienteForm.Show(); // Exibe o formul�rio Clientes
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos produtosForm = new Produtos(); // Instancia o formul�rio Produtos
            produtosForm.Show(); // Exibe o formul�rio Produtos
        }
    }
}
