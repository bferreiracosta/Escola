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
    public partial class Cadastro_Escola : Form
    {
        public Escola escola = new Escola();
        public Enum enumEscola = new Enum();
        public EnsinoInfantil infantil = new EnsinoInfantil();
        public Ensinomedio medio = new Ensinomedio();
        public EnsinoFundamental fundamental = new EnsinoFundamental();
        List<EnsinoInfantil> turmaensinoinfantil = new List<EnsinoInfantil>();
        List<Ensinomedio> turmaensinomedio = new List<Ensinomedio>();
        List<EnsinoFundamental> turmaensinofundamental = new List<EnsinoFundamental>();
        public DataManager dadosbanco = new DataManager();

        
              

        public Cadastro_Escola()
        {
            InitializeComponent();
        }

        private void Cadastro_Escola_Load(object sender, EventArgs e)
        {
            //enumEscola = Enum.editar;
            if (enumEscola == Enum.novo)
            {
                button6.Hide();
                
            }
            else
            {
                textBox1.Text = escola.Nomedaescola;
                textBox2.Text = escola.Nomeabreviado;
                textBox3.Text = escola.Endereco;
                listBox1.Text = escola.Estado;
                dataGridView1.DataSource = Banco.Listainfantil;
                dataGridView3.DataSource = Banco.Listafundamental;
                dataGridView2.DataSource = Banco.Listamedio;
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                maskedTextBox1.Text = Convert.ToString(escola.Telefone);
                maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                maskedTextBox2.Text = Convert.ToString(escola.Cnpj);
            }
        }      


        private void button1_Click(object sender, EventArgs e)
        {
            
            Ensino_Infantil Infantil = new Ensino_Infantil(this);
            Infantil.ShowDialog();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Ensino_Fundamental fundamental = new Ensino_Fundamental(this);
            fundamental.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            Ensino_medio medio = new Ensino_medio(this);
            medio.ShowDialog();
        }

        public void setDataSource(List<EnsinoInfantil> ensinoinfantil)
        {
            ensinoInfantilBindingSource2.DataSource = ensinoinfantil;
        }

        public void setDataSourcem(List<Ensinomedio> ensinomedio)
        {
            ensinomedioBindingSource2.DataSource = ensinomedio;
        }

        public void setDataSourcef(List<EnsinoFundamental> ensinofundamental)
        {
            ensinoFundamentalBindingSource.DataSource = ensinofundamental;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            escola.Nomedaescola = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            escola.Nomeabreviado = textBox2.Text;
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            escola.Endereco = textBox3.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            escola.Estado = listBox1.Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            escola.Telefone = double.Parse(maskedTextBox1.Text);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            escola.Cnpj = double.Parse(maskedTextBox2.Text);
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Banco.ListaEscola.Add(escola);
            Banco.Listainfantil.Add(infantil);
            Banco.Listafundamental.Add(fundamental);
            Banco.Listamedio.Add(medio);

            DataManager.InsertEscola(escola.Nomedaescola, escola.Telefone, escola.Endereco, escola.Cnpj);
            
            MessageBox.Show("Escola Cadastrada");
            
        }

     
    }
}
