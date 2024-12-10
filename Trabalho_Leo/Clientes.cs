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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            HabilitarBotoes(true, true, true, true);
            OcultarBotoes(false, false);
            LimparCampos();
        }

        private void LimparCampos()
        {
            txt_idCliente.Text = string.Empty;
            txt_nomeCliente.Text = string.Empty;
            txt_cpfCliente.Text = string.Empty;
            txt_emailCliente.Text = string.Empty;
        }

        private void HabilitarBotoes(bool inserir, bool procurar, bool atualizar, bool deletar)
        {
            btn_inserirCliente.Enabled = inserir;
            btn_procurarCliente.Enabled = procurar;
            btn_atualizarCliente.Enabled = atualizar;
            btn_deletarCliente.Enabled = deletar;
        }

        private void OcultarBotoes(bool salvar, bool cancelar)
        {
            btn_salvarCliente.Visible = salvar;
            btn_cancelarCliente.Visible = cancelar;
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

        private void ObterProximoIdDisponivel()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=trabalho;uid=root;pwd=;port=3306;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IFNULL(MAX(id), 0) + 1 FROM clientes";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object resultado = cmd.ExecuteScalar();
                        txt_idCliente.Text = resultado != null ? resultado.ToString() : "1";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao obter próximo ID: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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







        private void btn_cancelarCliente_Click(object sender, EventArgs e)
        {
            HabilitarBotoes(true, true, true, true);
            OcultarBotoes(false, false);
        }

        private void btn_salvarCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObrigatorios(txt_nomeCliente, txt_cpfCliente, txt_emailCliente))
                return;

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=trabalho;uid=root;pwd=;port=3306;"))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO clientes (nome, cpf, email) VALUES (@nome, @cpf, @email)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txt_nomeCliente.Text);
                        cmd.Parameters.AddWithValue("@cpf", txt_cpfCliente.Text);
                        cmd.Parameters.AddWithValue("@email", txt_emailCliente.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao inserir cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            HabilitarBotoes(true, true, true, true);
            OcultarBotoes(false, false);
            LimparCampos();
        }

        private void btn_inserirCliente_Click_1(object sender, EventArgs e)
        {
            HabilitarBotoes(false, false, false, false);
            OcultarBotoes(true, true);
            LimparCampos();
            ObterProximoIdDisponivel();
        }

        private void btn_procurarCliente_Click_1(object sender, EventArgs e)
        {
            Procurar_Cliente procurarCliente = new Procurar_Cliente();
            procurarCliente.ShowDialog();

            if (!string.IsNullOrEmpty(Conexão.ClienteBusca))
            {
                string query = "SELECT * FROM clientes WHERE id = @id";
                using (MySqlConnection conn = Conexão.FazerConexao())
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", Conexão.ClienteBusca);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txt_idCliente.Text = reader["id"].ToString();
                                    txt_nomeCliente.Text = reader["nome"].ToString();
                                    txt_cpfCliente.Text = reader["cpf"].ToString();
                                    txt_emailCliente.Text = reader["email"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao procurar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_deletarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idCliente.Text))
            {
                MessageBox.Show("Por favor, insira o ID do cliente para deletar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimparCampos();
                return;
            }

            var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                string query = "DELETE FROM clientes WHERE id = @id";
                ExecutarComandoNoBanco(cmd => cmd.Parameters.AddWithValue("@id", txt_idCliente.Text), query);
                MessageBox.Show("Cadastro excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_atualizarCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObrigatorios(txt_idCliente, txt_nomeCliente, txt_cpfCliente, txt_emailCliente))
                return;

            string query = "UPDATE clientes SET nome = @nome, cpf = @cpf, email = @email WHERE id = @id";
            ExecutarComandoNoBanco(cmd =>
            {
                cmd.Parameters.AddWithValue("@id", txt_idCliente.Text);
                cmd.Parameters.AddWithValue("@nome", txt_nomeCliente.Text);
                cmd.Parameters.AddWithValue("@cpf", txt_cpfCliente.Text);
                cmd.Parameters.AddWithValue("@email", txt_emailCliente.Text);
            }, query);

            MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }

        private void btn_sairCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}