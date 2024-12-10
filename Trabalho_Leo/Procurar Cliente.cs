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
    public partial class Procurar_Cliente : Form
    {
        public Procurar_Cliente()
        {
            InitializeComponent();
        }

        private void btn_confirmarBuscaCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idProcurarCliente.Text))
            {
                MessageBox.Show("Por favor, insira o ID do Cliente para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Atribui o valor digitado à propriedade compartilhada
            Conexão.ClienteBusca = txt_idProcurarCliente.Text.Trim();
            this.Close();
        }

        private void btn_cancelarBuscaCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
