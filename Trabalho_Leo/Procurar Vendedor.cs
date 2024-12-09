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
    public partial class Procurar_Vendedor : Form
    {
        public Procurar_Vendedor()
        {
            InitializeComponent();
        }

        private void txt_idProcurar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idProcurar.Text))
            {
                MessageBox.Show("Por favor, insira o ID do vendedor para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Atribui o valor digitado à propriedade compartilhada
            Conexão.VendedorBusca = txt_idProcurar.Text.Trim();
            this.Close();
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // Reseta a variável compartilhada de busca
            Conexão.VendedorBusca = null;
        }

        private void Procurar_Vendedor_Load(object sender, EventArgs e)
        {

        }

        private void Procurar_Vendedor_Load_1(object sender, EventArgs e)
        {

        }

        private void Procurar_Vendedor_Load_2(object sender, EventArgs e)
        {

        }

        private void Procurar_Vendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Se o usuário não confirmou uma busca, reseta o valor da busca
            if (string.IsNullOrEmpty(Conexão.VendedorBusca))
            {
                Conexão.VendedorBusca = null;
            }
        }

    }
}
