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
using static System.Windows.Forms.DataFormats;

namespace Trabalho_Leo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_SairLogin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Tem certeza de que deseja sair?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_UsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_EntrarLogin_Click(object sender, EventArgs e)
        {
            string id = txt_UsuarioLogin.Text.Trim();
            string senha = txt_SenhaLogin.Text.Trim();

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=trabalho;uid=root;pwd=;port=3306;"))
            {
                try
                {
                    conn.Open();
                    string verificaIdQuery = "SELECT COUNT(*) FROM vendedores WHERE id = @Id";
                    using (MySqlCommand cmdVerificaId = new MySqlCommand(verificaIdQuery, conn))
                    {
                        cmdVerificaId.Parameters.AddWithValue("@Id", id);

                        int idExistente = Convert.ToInt32(cmdVerificaId.ExecuteScalar());

                        if (idExistente == 0)
                        {
                            MessageBox.Show("Usuário inválido. Verifique o ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    string query = "SELECT * FROM vendedores WHERE id = @Id AND senha = @Senha";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Senha", senha);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Menu menuForm = new Menu();
                                menuForm.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar ao banco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
