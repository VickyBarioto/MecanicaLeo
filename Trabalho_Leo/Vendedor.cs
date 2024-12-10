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
            HabilitarBotoes(true, true, true, true);
            OcultarBotoes(false, false);
        }
        /// <summary>
        /// Habilita ou desabilita os botões do formulário.
        /// </summary>
        private void HabilitarBotoes(bool inserir, bool procurar, bool atualizar, bool deletar)
        {
            btn_inserirvendedor.Enabled = inserir;
            btn_procurarvendedor.Enabled = procurar;
            btn_atualizarvendedor.Enabled = atualizar;
            btn_deletarvendedor.Enabled = deletar;
        }

        /// <summary>
        /// Mostra ou oculta os botões de Salvar e Cancelar.
        /// </summary>
        private void OcultarBotoes(bool salvar, bool cancelar)
        {
            btn_salvarVendedor.Visible = salvar;
            btn_cancelarVendedor.Visible = cancelar;
        }
        /// <summary>
        /// Valida se os campos obrigatórios estão preenchidos.
        /// </summary>
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

        /// Obtém o próximo ID disponível no banco de dados e o exibe no campo de ID.
        /// </summary>
        private void ObterProximoIdDisponivel()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=trabalho;uid=root;pwd=;port=3306;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IFNULL(MAX(id), 0) + 1 FROM vendedores";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object resultado = cmd.ExecuteScalar();
                        txt_id.Text = resultado != null ? resultado.ToString() : "1";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao obter próximo ID: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Executa um comando no banco de dados.
        /// </summary>
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
            HabilitarBotoes(false, false, false, false);
            OcultarBotoes(true, true);
            ObterProximoIdDisponivel();
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
                                    txt_nomeVendedor.Text = reader["nome"].ToString();
                                    txt_enderecoVendedor.Text = reader["endereco"].ToString();
                                    txt_telefonevendedor.Text = reader["telefone"].ToString();
                                    txt_emailVendedor.Text = reader["email"].ToString();
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
            if (!ValidarCamposObrigatorios(txt_id, txt_nomeVendedor))
                return;

            string query = "UPDATE vendedores SET nome = @nome, endereco = @endereco, telefone = @telefone, email = @email WHERE id = @id";
            ExecutarComandoNoBanco(cmd =>
            {
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@nome", txt_nomeVendedor.Text);
                cmd.Parameters.AddWithValue("@endereco", txt_enderecoVendedor.Text);
                cmd.Parameters.AddWithValue("@telefone", txt_telefonevendedor.Text);
                cmd.Parameters.AddWithValue("@email", txt_emailVendedor.Text);
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

        private void btn_cancelarVendedor_Click(object sender, EventArgs e)
        {
            HabilitarBotoes(true, true, true, true);
            OcultarBotoes(false, false);
        }

        private void btn_salvarVendedor_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObrigatorios(txt_nomeVendedor, txt_cpfVendedor, txt_emailVendedor))
                return;

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=trabalho;uid=root;pwd=;port=3306;"))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO vendedores (nome, endereco, cpf, email) VALUES (@nome, @endereco, @cpf, @email)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txt_nomeVendedor.Text);
                        cmd.Parameters.AddWithValue("@endereco", txt_enderecoVendedor.Text);
                        cmd.Parameters.AddWithValue("@cpf", txt_cpfVendedor.Text);
                        cmd.Parameters.AddWithValue("@email", txt_emailVendedor.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vendedor inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao inserir vendedor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            HabilitarBotoes(true, true, true, true);
            OcultarBotoes(false, false);
        }
    }
}
