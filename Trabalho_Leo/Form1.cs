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
            Vendedor vendedorForm = new Vendedor(); // Instancia o formulário Vendedor
            vendedorForm.Show(); // Exibe o formulário Vendedor

        }



        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos produtosForm = new Produtos(); // Instancia o formulário Produtos
            produtosForm.Show(); // Exibe o formulário Produtos
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientesForm = new Clientes(); // Instancia o formulário Clientes
            clientesForm.Show(); // Exibe o formulário Clientes
        }
    }
}
