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
    public partial class TelaInicial : Form
    {
        //usuario global
        Model.Usuario usuario;
        public TelaInicial(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario; 
            lblUsuario.Text = $"Olá, {usuario.Name}";
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txbNome.Text.Length < 3)
            {
                MessageBox.Show("O nome é obrigatório!", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Instanciar um objeto do tipo contato:
                Model.Contato contato = new Model.Contato();
                contato.name = txbNome.Text;
                contato.email = txbEmail.Text;
                contato.endereco = txbEndereco.Text;    
                contato.telefone = txbTelefone.Text;
                contato.IdResponsavel = usuario.Id;

                if(contato.Cadastrar() == 1)
                {
                    MessageBox.Show("Contato cadastrado!", "Sucesso!",
                    MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar contato!", "Erro!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
