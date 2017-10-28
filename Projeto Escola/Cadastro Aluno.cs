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
    public partial class Cadastro_Aluno : Form
    {
        public Aluno alunoobj = new Aluno();
        Escola escola = new Escola();

        public Enum EnumAluno = new Enum();


        public Cadastro_Aluno()
        {
            InitializeComponent();

            comboBox1.ValueMember = "Cnpj";
            comboBox1.DisplayMember = "Nomedaescola";
            comboBox1.DataSource = Banco.ListaEscola;
           
            escolaBindingSource.DataSource = Banco.ListaEscola;
        }

        private void cadastroEscolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Cadastro_Escola Escola = new Cadastro_Escola();
            Escola.ShowDialog();
        }

        private void cadastroAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Cadastro_Aluno aluno = new Cadastro_Aluno();
            aluno.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            alunoobj.Nome = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            alunoobj.Sobrenome = textBox3.Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            alunoobj.Telefone = double.Parse(maskedTextBox1.Text);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            alunoobj.Datanascimento = double.Parse(maskedTextBox2.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            alunoobj.Estado = listBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            alunoobj.Endereco = textBox2.Text;
        }

       
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            alunoobj.CPF1 = double.Parse(maskedTextBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alunoobj.Escola = (Escola)comboBox1.SelectedItem;
            
            Banco.Listaaluno.Add(alunoobj);
            
            
        }

        


        private void Cadastro_Aluno_Load(object sender, EventArgs e)
        {
            //enumEscola = Enum.editar;
            if (EnumAluno == Enum.novo)
            {
                

            }
            else
            {
                textBox1.Text = alunoobj.Nome;
                textBox3.Text = alunoobj.Sobrenome;
                textBox2.Text = alunoobj.Endereco;
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                maskedTextBox1.Text = Convert.ToString(alunoobj.Telefone);
                maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                maskedTextBox2.Text = Convert.ToString(alunoobj.Datanascimento);
                maskedTextBox3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                maskedTextBox3.Text = Convert.ToString(alunoobj.CPF1);
                listBox1.Text = alunoobj.Estado;
                comboBox1.Text = alunoobj.Escola.Nomedaescola;
                
                
                

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataManager.GetEscolas();

        }
    }
}
