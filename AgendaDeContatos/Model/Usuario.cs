using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContatos.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }
        public string Senha{ get; set; }   

        public DataTable Logar()
        {
            // Definir o objeto de "tabela" que será preenchido com a consulta:
            DataTable tabela = new DataTable();
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            banco.Conectar();
            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();
            // Definir qual comando DQL será executado:
            cmd.CommandText = "SELECT * FROM usuarios WHERE email=@email AND senha=@senha";
            cmd.Parameters.AddWithValue("@email", this.Email);
            cmd.Parameters.AddWithValue("@senha", this.Senha);
            // Executar e "atribuir" o resultado em um objeto SQLiteDA
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            // Definir qual "tabela" será preenchida com o resultado da consulta:
            da.Fill(tabela);
            // Desconectar:
            banco.Desconectar();
            //Devolver a tabela preenchida para quem chmar o método logar:
            return tabela;


        }

        public bool Cadastrar()
        {
            return true;
            //corrigir depois
        }
    }
}
