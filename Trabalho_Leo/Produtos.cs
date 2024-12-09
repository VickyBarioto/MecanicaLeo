using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Trabalho_Leo
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void btn_sairproduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inserirproduto_Click(object sender, EventArgs e)
        {
            // Desabilita os outros botões ao iniciar a inserção
            //HabilitarBotoes(true, false, false, false);

            // Validações básicas de entrada
            if (string.IsNullOrWhiteSpace(txt_nomeProduto.Text))
            {
                MessageBox.Show("Por favor, preencha o nome do produto antes de inserir.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_fornecedorProduto.Text))
            {
                MessageBox.Show("Por favor, preencha o nome do fornecedor antes de inserir.");
                return;
            }

            // Validação de ano (inteiro)
            if (!int.TryParse(txt_anoProduto.Text, out int ano))
            {
                MessageBox.Show("O campo 'Ano' deve conter um valor numérico inteiro.");
                return;
            }

            // Validação de preços (decimais)
            if (!decimal.TryParse(txt_precoCompraProduto.Text, out decimal precoCompra))
            {
                MessageBox.Show("O campo 'Preço de Compra' deve conter um valor numérico válido.");
                return;
            }

            if (!decimal.TryParse(txt_precoRevendaProduto.Text, out decimal precoRevenda))
            {
                MessageBox.Show("O campo 'Preço de Revenda' deve conter um valor numérico válido.");
                return;
            }

            // Conexão com o banco de dados
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=trabalho;uid=root;pwd=;port=3306;"))
            {
                try
                {
                    conn.Open();

                    // Consulta SQL corrigida (parêntese final adicionado)
                    string query = "INSERT INTO produtos (nome, marca, modelo, ano, preco_compra, preco_revenda, fornecedor) " +
                                   "VALUES (@nome, @marca, @modelo, @ano, @preco_compra, @preco_revenda, @fornecedor)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Parâmetros corretamente associados aos campos correspondentes
                        cmd.Parameters.AddWithValue("@nome", txt_nomeProduto.Text.Trim());
                        cmd.Parameters.AddWithValue("@marca", txt_marcaProduto.Text.Trim());
                        cmd.Parameters.AddWithValue("@modelo", txt_modeloProduto.Text.Trim());
                        cmd.Parameters.AddWithValue("@ano", ano); // agora é um inteiro
                        cmd.Parameters.AddWithValue("@preco_compra", Math.Round(precoCompra, 2)); // Arredonda para 2 casas decimais
                        cmd.Parameters.AddWithValue("@preco_revenda", Math.Round(precoRevenda, 2)); // Arredonda para 2 casas decimais
                        cmd.Parameters.AddWithValue("@fornecedor", txt_fornecedorProduto.Text.Trim());

                        // Executa o comando de inserção
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto inserido com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    // Exibe o erro
                    MessageBox.Show($"Erro ao inserir o produto: {ex.Message}");
                }
            }

            // Habilita os botões novamente após a operação
            //HabilitarBotoes(true, true, true, true);
        }

    }
}
