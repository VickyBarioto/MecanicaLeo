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



        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos produtosForm = new Produtos(); // Instancia o formul�rio Produtos
            produtosForm.Show(); // Exibe o formul�rio Produtos
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientesForm = new Clientes(); // Instancia o formul�rio Clientes
            clientesForm.Show(); // Exibe o formul�rio Clientes
        }
    }
}
