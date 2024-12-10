using MySql.Data.MySqlClient;
using System;

namespace Trabalho_Leo
{
    /// <summary>
    /// Classe utilitária para gerenciar conexões com o banco de dados MySQL
    /// e armazenar dados compartilhados temporários.
    /// </summary>
    internal class Conexão
    {
        /// <summary>
        /// Propriedade estática para armazenar o ID do vendedor que está sendo pesquisado.
        /// </summary>
        public static string VendedorBusca { get; set; }
        public static string ProdutoBusca { get; set; }
        public static string ClienteBusca { get; set; }

        /// <summary>
        /// Cria e retorna uma nova conexão com o banco de dados MySQL usando os parâmetros fornecidos.
        /// </summary>
        /// <returns>Instância de <see cref="MySqlConnection"/> configurada para o banco de dados.</returns>
        public static MySqlConnection FazerConexao()
        {
            return new MySqlConnection("server=localhost;database=trabalho;uid=root;pwd=;port=3306;");
        }
    }
}
