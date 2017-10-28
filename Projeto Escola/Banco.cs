using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Escola
{
   public class Banco
    {
        private static List<Escola> listaEscola = new List<Escola>();
        private static List<EnsinoInfantil> listainfantil = new List<EnsinoInfantil>();
        private static List<Ensinomedio> listamedio = new List<Ensinomedio>();
        private static List<EnsinoFundamental> listafundamental = new List<EnsinoFundamental>();
        private static List<Aluno> listaaluno = new List<Aluno>();
        private static List<Turma> listaturmas = new List<Turma>();
        private static List<Vaga> listavagas = new List<Vaga>();
        private static List<Usuario> listausuarios = new List<Usuario>();

        public static List<Escola> ListaEscola
        {
            get
            {
                return listaEscola;
            }

            set
            {
                listaEscola = value;
            }
        }

        public static List<EnsinoInfantil> Listainfantil
        {
            get
            {
                return listainfantil;
            }

            set
            {
                listainfantil = value;
            }
        }

        public static List<Ensinomedio> Listamedio
        {
            get
            {
                return listamedio;
            }

            set
            {
                listamedio = value;
            }
        }

        public static List<EnsinoFundamental> Listafundamental
        {
            get
            {
                return listafundamental;
            }

            set
            {
                listafundamental = value;
            }
        }

        public static List<Aluno> Listaaluno
        {
            get
            {
                return listaaluno;
            }

            set
            {
                listaaluno = value;
            }
        }

        public static List<Turma> Listaturmas
        {
            get
            {
                return listaturmas;
            }

            set
            {
                listaturmas = value;
            }
        }

        public static List<Vaga> Listavagas
        {
            get
            {
                return listavagas;
            }

            set
            {
                listavagas = value;
            }
        }

        public static List<Usuario> Listausuarios
        {
            get
            {
                return listausuarios;
            }

            set
            {
                listausuarios = value;
            }
        }
    }
}
