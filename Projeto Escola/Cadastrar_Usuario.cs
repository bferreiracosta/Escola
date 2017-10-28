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
    public partial class Cadastrar_Usuario : Form
    {
        Usuario usuario = new Usuario();

        public Cadastrar_Usuario()
        {
            InitializeComponent();
        }

       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            usuario.Usuario1 = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            usuario.Senha = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            usuario.Senha = textBox5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Banco.Listausuarios.Add(usuario);
        }

       
    }
}
