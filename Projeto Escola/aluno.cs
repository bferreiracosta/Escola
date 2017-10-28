using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Escola
{
    public class Aluno
    {
        private string nome;
        private string sobrenome;
        private double telefone;
        private double datanascimento;
        private string estado;
        private string endereco;
        private double CPF;
        private Turma turma;
        private Escola escola;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }

            set
            {
                sobrenome = value;
            }
        }

        public double Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public double Datanascimento
        {
            get
            {
                return datanascimento;
            }

            set
            {
                datanascimento = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public double CPF1
        {
            get
            {
                return CPF;
            }

            set
            {
                CPF = value;
            }
        }

        public Turma Turma
        {
            get
            {
                return turma;
            }

            set
            {
                turma = value;
            }
        }

        public Escola Escola
        {
            get
            {
                return escola;
            }

            set
            {
                escola = value;
            }
        }
    }
}
