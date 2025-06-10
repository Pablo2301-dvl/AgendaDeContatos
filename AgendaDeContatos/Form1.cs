using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaDeContatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Instanciar um objeto do tipo usuário:
            Model.Usuario usuario = new Model.Usuario();
            //Verificar se os campos estão vazios:
            if (txbEmail.Text.Length < 6)
            {
                MessageBox.Show("Email inválido!", "Erro!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length == 0)
            {
                MessageBox.Show("O campo de senha não pode estar vazio!", "Erro!",
                 MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                usuario.Email = txbEmail.Text;
                usuario.Senha = txbSenha.Text;
                //Tabela para receber o resultadoda consulta de login:
                DataTable resultado = usuario.Logar();
                //MessageBox.Show(resultado.Rows[0]["nome"].ToString());

                //Verificar se a consulta teve resultado:
                if (resultado.Rows.Count == 1)
                {
                    MessageBox.Show($"Olá {resultado.Rows[0]["nome"]}!");
                    //Atribuir no objto as informações vindas do bd:
                    usuario.Name = resultado.Rows[0]["nome"].ToString();
                    usuario.Id = int.Parse(resultado.Rows[0]["id"].ToString());
                
                    //Abrir a novas janela:
                    TelaInicial telaInicial = new TelaInicial(usuario);    
                    this.Hide(); //esconder janela atual
                    telaInicial.ShowDialog(); // mostrar a nova janela
                    this.Show(); //mostrar a janela atual após a nova sere fechada
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!",
                        "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
