using System;
using MySql.Data.MySqlClient;
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
    /// <summary>
    /// Classe do formulário responsável pela gestão de vendedores.
    /// Contém funcionalidades para inserir, procurar, atualizar e deletar registros de vendedores.
    /// </summary>
    public partial class Vendedor : Form
    {
        public Vendedor()
        {
            InitializeComponent();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento acionado quando o formulário é carregado.
        /// Inicializa os botões como habilitados.
        /// </summary>
        private void Vendedor_Load(object sender, EventArgs e)
        {
            // Inicialmente, todos os botões estão habilitados
            HabilitarBotoes(true, true, true, true);
        }
        /// <summary>
        /// Habilita ou desabilita os botões do formulário.
        /// </summary>
        /// <param name="inserir">Estado do botão de inserir.</param>
        /// <param name="procurar">Estado do botão de procurar.</param>
        /// <param name="atualizar">Estado do botão de atualizar.</param>
        /// <param name="deletar">Estado do botão de deletar.</param>
        private void HabilitarBotoes(bool inserir, bool procurar, bool atualizar, bool deletar)
        {
            btn_inserirvendedor.Enabled = inserir;
            btn_procurarvendedor.Enabled = procurar;
            btn_atualizarvendedor.Enabled = atualizar;
            btn_deletarvendedor.Enabled = deletar;
        }
        /// <summary>
        /// Valida se os campos obrigatórios estão preenchidos.
        /// </summary>
        /// <param name="campos">Lista de campos a validar.</param>
        /// <returns>True se todos os campos estiverem preenchidos, false caso contrário.</returns>
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
        /// <summary>
        /// Executa um comando no banco de dados com base na query e configuração fornecidas.
        /// </summary>
        /// <param name="configuracaoComando">Ação que configura os parâmetros do comando.</param>
        /// <param name="query">A query SQL a ser executada.</param>
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
        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_nomevendedor_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_enderecovendedor_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_numeroendereco_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_bairrovendedor_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_cepvendedor_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_cidadevendedor_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_estadovendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefonevendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_admissaovendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cargovendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_afastamentovendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_emailvendedor_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Insere um novo vendedor no banco de dados.
        /// </summary>
        private void btn_inserirvendedor_Click(object sender, EventArgs e)
        {
            // Desabilita os outros botões ao inserir
            HabilitarBotoes(true, false, false, false);

            // Validação dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(txt_nomevendedor.Text))
            {
                MessageBox.Show("Por favor, preencha o nome do vendedor antes de inserir.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_cpfvendedor.Text))
            {
                MessageBox.Show("Por favor, preencha o CPF do vendedor antes de inserir.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_emailvendedor.Text))
            {
                MessageBox.Show("Por favor, preencha o Email do vendedor antes de inserir.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=trabalho;uid=root;pwd=;port=3306;"))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO vendedores (nome, endereco, cpf, email) VALUES (@nome, @endereco, @cpf, @email)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txt_nomevendedor.Text);
                        cmd.Parameters.AddWithValue("@endereco", txt_enderecovendedor.Text);
                        cmd.Parameters.AddWithValue("@cpf", txt_cpfvendedor.Text);
                        cmd.Parameters.AddWithValue("@email", txt_emailvendedor.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vendedor inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao inserir vendedor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Habilita os botões novamente após a operação
            HabilitarBotoes(true, true, true, true);
        }

        /// <summary>
        /// Abre o formulário de busca e exibe os dados do vendedor selecionado.
        /// </summary>
        private void btn_procurarvendedor_Click(object sender, EventArgs e)
        {
            // Abre o formulário Procurar_Vendedor
            Procurar_Vendedor procurarVendedor = new Procurar_Vendedor();
            procurarVendedor.ShowDialog();

            // Verifica se um ID foi selecionado no formulário Procurar_Vendedor
            if (!string.IsNullOrEmpty(Conexão.VendedorBusca))
            {
                string query = "SELECT * FROM vendedores WHERE id = @id";
                using (MySqlConnection conn = Conexão.FazerConexao())
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", Conexão.VendedorBusca);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txt_id.Text = reader["id"].ToString();
                                    txt_nomevendedor.Text = reader["nome"].ToString();
                                    txt_enderecovendedor.Text = reader["endereco"].ToString();
                                    txt_telefonevendedor.Text = reader["telefone"].ToString();
                                    txt_emailvendedor.Text = reader["email"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Vendedor não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao procurar vendedor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        /// <summary>
        /// Atualiza os dados de um vendedor existente.
        /// </summary>
        private void btn_atualizarvendedor_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObrigatorios(txt_id, txt_nomevendedor))
                return;

            string query = "UPDATE vendedores SET nome = @nome, endereco = @endereco, telefone = @telefone, email = @email WHERE id = @id";
            ExecutarComandoNoBanco(cmd =>
            {
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@nome", txt_nomevendedor.Text);
                cmd.Parameters.AddWithValue("@endereco", txt_enderecovendedor.Text);
                cmd.Parameters.AddWithValue("@telefone", txt_telefonevendedor.Text);
                cmd.Parameters.AddWithValue("@email", txt_emailvendedor.Text);
            }, query);

            MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Deleta o registro de um vendedor com base no ID informado.
        /// </summary>
        private void btn_deletarvendedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_id.Text))
            {
                MessageBox.Show("Por favor, insira o ID do vendedor para deletar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este vendedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                string query = "DELETE FROM vendedores WHERE id = @id";
                ExecutarComandoNoBanco(cmd => cmd.Parameters.AddWithValue("@id", txt_id.Text), query);
                MessageBox.Show("Cadastro excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_SairTelaInicio_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha somente a tela atual
        }

        private void cbb_nivelvendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
