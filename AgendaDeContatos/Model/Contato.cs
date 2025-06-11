using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContatos.Model
{
    internal class Contato
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }
        public int IdResponsavel { get; set; }

        public int Cadastrar()
        {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            banco.Conectar();
            var cmd = banco.conexao.CreateCommand();
            cmd.CommandText = "INSERT INTO contatos (nome, email, telefone," +
            "id_responsavel, endereco) VALUES (@nome, @email, @telefone, " +
            "@id_responsavel, @endereco)";
           

            // Adicionar valores aos parâmetros:
            cmd.Parameters.AddWithValue("@nome", this.name);
            cmd.Parameters.AddWithValue("email", this.email);
            cmd.Parameters.AddWithValue("telefone", this.telefone);
            cmd.Parameters.AddWithValue("id_responsavel", this.IdResponsavel);
            cmd.Parameters.AddWithValue("endereco", this.endereco);


            // Executar e capturar a quantidade de linhas inseridas/removidas:
            int linhasAfetadas = cmd.ExecuteNonQuery();

            // Desconectar
            banco.Desconectar();

            // Retornar a quantidade de linhas inseridas
            return linhasAfetadas;
        }

        public DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            Banco banco = new Banco();
            banco.Conectar();
            var cmd = banco.conexao.CreateCommand();
            cmd.CommandText = "SELECT * FROM contatos";
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(tabela);
            banco.Desconectar();
            return tabela;
        }

        public int Apagar()
        {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            banco.Conectar();
            var cmd = banco.conexao.CreateCommand();
            cmd.CommandText = "DELETE FROM contatos WHERE id=@id";


            // Adicionar valores aos parâmetros:
            cmd.Parameters.AddWithValue("@id", this.id);


            // Executar e capturar a quantidade de linhas inseridas/removidas:
            int linhasAfetadas = cmd.ExecuteNonQuery();

            // Desconectar
            banco.Desconectar();

            // Retornar a quantidade de linhas inseridas
            return linhasAfetadas;
        }
    }
}
