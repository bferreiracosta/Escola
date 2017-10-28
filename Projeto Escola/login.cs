using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Escola
{
    public partial class login : Form
    {
        Usuario usuario = new Usuario();

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //Vincular Enter ao btnLogin
            this.AcceptButton =bt_entrar;
            //Vincular ESC ao btnSair
            this.CancelButton = button1;
            // Seta o Foco no Text Box Usuario.
            this.ActiveControl = tx_usuario;
            // Esconde a Label De Alertas.
            lb_alerta.Hide();
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            //TODO: Teste de conexao com o banco de dados;
            DataManager.TestConnection(this);
            ValidaLogin();
        }

        private void ValidaLogin()
        {
            try
            {

                string usuarioadmin = "admin";
                string senhaadmin = "123";
                usuario.Usuario1 = tx_usuario.Text;
                usuario.Senha = tx_senha.Text;


                // Valida se os campos estao vazios.
                if (tx_usuario.Text.Length == 0 && tx_senha.Text.Length == 0 || tx_usuario.Text.Length == 0 || tx_senha.Text.Length == 0)
                {
                    lb_alerta.Text = "Dados Inválidos !";
                    lb_alerta.Show();
                    tx_senha.Clear();
                }
                else {

                        if(usuarioLogado(Banco.Listausuarios))
                        {
                            formprincipal homeForm = new formprincipal();
                            this.Visible = false;
                            this.Close();

                        }



                        else 
                        {
                            if (usuario.Usuario1 == usuarioadmin && usuario.Senha == senhaadmin)
                            {
                                formprincipal homeForm = new formprincipal();
                                this.Visible = false;
                                this.Close();
                             }

                            else
                            {
                            lb_alerta.Text = "Dados Inválidos !";
                            lb_alerta.Show();
                            tx_senha.Clear();
                            }
                        }

                    }

                }

            
            catch (Exception)
            {
                lb_alerta.Text = "Há algo de errado que não está certo !";
                lb_alerta.Show();
                tx_senha.Clear();
            }

        }
        // Compara se o usuario digitado esta no banco
        private bool usuarioLogado(List<Usuario> lista)
        {
            foreach (Usuario item in lista)
            {
                

                if (item.Usuario1 == this.usuario.Usuario1 && item.Senha == this.usuario.Senha)
                {
                    return true;
                }
                
            }
            return false;
        }

        private void tx_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas letras do alfabeto no campo usuario.
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastrar_Usuario cadastro_usuario = new Cadastrar_Usuario();
            cadastro_usuario.Show();
        }
    }

}

