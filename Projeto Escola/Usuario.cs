using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Escola
{
    public class Usuario
    {
        private string nomeUsuario;
        private string emailusuario;
        private string usuario;
        private string senha;

       
public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public string NomeUsuario
        {
            get
            {
                return nomeUsuario;
            }

            set
            {
                nomeUsuario = value;
            }
        }

        public string Emailusuario
        {
            get
            {
                return emailusuario;
            }

            set
            {
                emailusuario = value;
            }
        }

        public string Usuario1
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
