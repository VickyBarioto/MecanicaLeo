using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Leo
{
    public partial class Procurar_Produto : Form
    {
        public Procurar_Produto()
        {
            InitializeComponent();
        }

        private void Procurar_Produto_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirmarBuscaProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idProcurarProduto.Text))
            {
                MessageBox.Show("Por favor, insira o ID do produto para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Atribui o valor digitado à propriedade compartilhada
            Conexão.ProdutoBusca = txt_idProcurarProduto.Text.Trim();
            this.Close();
        }

        private void btn_cancelarBuscaProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
