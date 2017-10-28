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
    public partial class formprincipal : Form
    {
        List<Escola> listaescola = new List<Escola>();
        List<Aluno> listaaluno = new List<Aluno>();
        List<EnsinoInfantil> listainfantil = new List<EnsinoInfantil>();
        List<Ensinomedio> listamedio = new List<Ensinomedio>();
        List<EnsinoFundamental> listafundamental = new List<EnsinoFundamental>();

        public formprincipal()
        {
            InitializeComponent();
        }

        private void cadastroEscolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Cadastro_Escola escola = new Cadastro_Escola();
            escola.enumEscola = Enum.novo;
            escola.MdiParent = this;
            escola.Show();
        }

        private void editarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Escola escola = new Cadastro_Escola();
            escola.enumEscola = Enum.editar;
            escola.MdiParent = this;
            listaescola = Banco.ListaEscola;
            escola.escola = listaescola[0];
            listainfantil = Banco.Listainfantil;
            escola.infantil = listainfantil[0];
            listafundamental = Banco.Listafundamental;
            escola.fundamental = listafundamental[0];
            listamedio = Banco.Listamedio;
            escola.medio = listamedio[0];
            escola.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Aluno aluno = new Cadastro_Aluno();
            aluno.EnumAluno = Enum.novo;
            aluno.MdiParent = this;
            aluno.Show(); 
        }

        private void editarCadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cadastro_Aluno alunos = new Cadastro_Aluno();    
            alunos.EnumAluno = Enum.editar;
            alunos.MdiParent = this;
            listaaluno = Banco.Listaaluno;
            alunos.alunoobj = listaaluno[0];
            alunos.Show();

        }

        private void formprincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
