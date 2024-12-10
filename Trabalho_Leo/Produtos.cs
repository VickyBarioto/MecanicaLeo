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
        private void ExecutarComandoNoBanco(Action<MySqlCommand> configuracaoComando, string query)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=trabalho;uid=root;pwd=;port=3306;"))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        configuracaoComando(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao executar comando: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_sairproduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inserirproduto_Click(object sender, EventArgs e)
        {
            // Habilita apenas os botões de salvar e cancelar
            HabilitarBotoesParaInsercao();

            // Limpa os campos, exceto o txt_id
            LimparCampos();

            // Define o próximo ID disponível no campo txt_id
            DefinirProximoID();
        }

        private void btn_salvarProduto_Click(object sender, EventArgs e)
        {
            // Validações básicas de entrada
            if (string.IsNullOrWhiteSpace(txt_nomeProduto.Text))
            {
                MessageBox.Show("Por favor, preencha o nome do produto antes de salvar.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_fornecedorProduto.Text))
            {
                MessageBox.Show("Por favor, preencha o nome do fornecedor antes de salvar.");
                return;
            }

            if (!int.TryParse(txt_anoProduto.Text, out int ano))
            {
                MessageBox.Show("O campo 'Ano' deve conter um valor numérico inteiro.");
                return;
            }

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

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=trabalho;uid=root;pwd=;port=3306;"))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO produtos (nome, marca, modelo, ano, preco_compra, preco_revenda, fornecedor) " +
                                   "VALUES (@nome, @marca, @modelo, @ano, @preco_compra, @preco_revenda, @fornecedor)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txt_nomeProduto.Text.Trim());
                        cmd.Parameters.AddWithValue("@marca", txt_marcaProduto.Text.Trim());
                        cmd.Parameters.AddWithValue("@modelo", txt_modeloProduto.Text.Trim());
                        cmd.Parameters.AddWithValue("@ano", ano);
                        cmd.Parameters.AddWithValue("@preco_compra", Math.Round(precoCompra, 2));
                        cmd.Parameters.AddWithValue("@preco_revenda", Math.Round(precoRevenda, 2));
                        cmd.Parameters.AddWithValue("@fornecedor", txt_fornecedorProduto.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto inserido com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao inserir o produto: {ex.Message}");
                }
            }

            LimparCampos();
            HabilitarBotoesPadrao();
        }

        private void btn_cancelarProduto_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarBotoesPadrao();
        }

        private void btn_procurarproduto_Click(object sender, EventArgs e)
        {
            // Abre o formulário Procurar_Produto
            Procurar_Produto procurarProduto = new Procurar_Produto();
            procurarProduto.ShowDialog();

            // Verifica se um ID foi selecionado no formulário Procurar_Produto
            if (!string.IsNullOrEmpty(Conexão.ProdutoBusca))
            {
                // Query para selecionar os dados do produto
                string query = "SELECT * FROM produtos WHERE id = @id";

                using (MySqlConnection conn = Conexão.FazerConexao())
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", Conexão.ProdutoBusca);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    Console.WriteLine(reader);
                                    // Preenche os campos de texto com os valores do banco de dados
                                    txt_id.Text = reader["id"].ToString();
                                    txt_nomeProduto.Text = reader["nome"].ToString();
                                    txt_marcaProduto.Text = reader["marca"].ToString();
                                    txt_modeloProduto.Text = reader["modelo"].ToString();
                                    txt_anoProduto.Text = reader["ano"].ToString();
                                    txt_precoCompraProduto.Text = reader["preco_compra"].ToString();
                                    txt_precoRevendaProduto.Text = reader["preco_revenda"].ToString();
                                    txt_fornecedorProduto.Text = reader["fornecedor"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao procurar Produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool ValidarCamposObrigatorios(params TextBox[] campos)
        {
            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo.Text))
                {
                    MessageBox.Show($"O campo {campo.Name} é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }


        private void btn_atualizarproduto_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObrigatorios(txt_id, txt_nomeProduto, txt_precoRevendaProduto, txt_precoCompraProduto, txt_fornecedorProduto, txt_marcaProduto, txt_anoProduto))
                return;

            string query = "UPDATE produtos SET nome = @nome, marca = @marca, modelo = @modelo, ano = @ano, preco_compra = @precoCompra, preco_revenda = @precoRevenda, fornecedor = @fornecedor WHERE id = @id";

            ExecutarComandoNoBanco(cmd =>
            {
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@nome", txt_nomeProduto.Text);
                cmd.Parameters.AddWithValue("@marca", txt_marcaProduto.Text);
                cmd.Parameters.AddWithValue("@modelo", txt_modeloProduto.Text);
                cmd.Parameters.AddWithValue("@ano", txt_anoProduto.Text);
                cmd.Parameters.AddWithValue("@precoCompra", txt_precoCompraProduto.Text);
                cmd.Parameters.AddWithValue("@precoRevenda", txt_precoRevendaProduto.Text);
                cmd.Parameters.AddWithValue("@fornecedor", txt_fornecedorProduto.Text);
            }, query);

            MessageBox.Show("Produto atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_deletarproduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_id.Text))
            {
                MessageBox.Show("Por favor, insira o ID do produto para deletar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                string query = "DELETE FROM produtos WHERE id = @id";
                ExecutarComandoNoBanco(cmd => cmd.Parameters.AddWithValue("@id", txt_id.Text), query);
                MessageBox.Show("Produto excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimparCampos();
        }

        /// <summary>
        /// Função para habilitar/desabilitar os botões no estado inicial (padrão).
        /// </summary>
        private void HabilitarBotoesPadrao()
        {
            btn_inserirproduto.Enabled = true;
            btn_procurarproduto.Enabled = true;
            btn_deletarproduto.Enabled = true;
            btn_sairproduto.Enabled = true;
            btn_atualizarproduto.Enabled = true;

            // Esconde os botões de salvar e cancelar
            btn_salvarProduto.Visible = false;
            btn_cancelarProduto.Visible = false;
        }

        /// <summary>
        /// Função para habilitar/desabilitar os botões quando o usuário clicar em inserir.
        /// </summary>
        private void HabilitarBotoesParaInsercao()
        {
            btn_inserirproduto.Enabled = false;
            btn_procurarproduto.Enabled = false;
            btn_deletarproduto.Enabled = false;
            btn_sairproduto.Enabled = false;
            btn_atualizarproduto.Enabled = false;

            // Mostra os botões de salvar e cancelar
            btn_salvarProduto.Visible = true;
            btn_cancelarProduto.Visible = true;
        }

        /// <summary>
        /// Função para limpar todos os campos de texto no formulário, exceto o campo txt_id.
        /// </summary>
        private void LimparCampos()
        {
            txt_nomeProduto.Text = string.Empty;
            txt_marcaProduto.Text = string.Empty;
            txt_modeloProduto.Text = string.Empty;
            txt_anoProduto.Text = string.Empty;
            txt_precoCompraProduto.Text = string.Empty;
            txt_precoRevendaProduto.Text = string.Empty;
            txt_fornecedorProduto.Text = string.Empty;
        }

        /// <summary>
        /// Função para obter e definir o próximo ID disponível no campo txt_id.
        /// </summary>
        private void DefinirProximoID()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=trabalho;uid=root;pwd=;port=3306;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MAX(id) + 1 FROM produtos";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object resultado = cmd.ExecuteScalar();
                        txt_id.Text = resultado != DBNull.Value ? resultado.ToString() : "1";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao definir o próximo ID: {ex.Message}");
                }
            }
        }
    }
}
