using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Escola
{
    public class Escola
    {
        private string nomedaescola;
        private string nomeabreviado;
        private string endereco;
        private string estado;
        private double telefone;
        private double cnpj;

        public string Nomedaescola
        {
            get
            {
                return nomedaescola;
            }

            set
            {
                nomedaescola = value;
            }
        }

        public string Nomeabreviado
        {
            get
            {
                return nomeabreviado;
            }

            set
            {
                nomeabreviado = value;
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

        public double Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }
    }
}
