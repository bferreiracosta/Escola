using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Escola
{
    public class Turma
    {
        private EnsinoFundamental turmaensinofundamental;
        private EnsinoInfantil turmaensinoinfantil;
        private Ensinomedio turmaensinomedio;

        
        public Turma()
        {

        }

        public EnsinoFundamental Turmaensinofundamental
        {
            get
            {
                return turmaensinofundamental;
            }

            set
            {
                turmaensinofundamental = value;
            }
        }

        public EnsinoInfantil Turmaensinoinfantil
        {
            get
            {
                return turmaensinoinfantil;
            }

            set
            {
                turmaensinoinfantil = value;
            }
        }

        public Ensinomedio Turmaensinomedio
        {
            get
            {
                return turmaensinomedio;
            }

            set
            {
                turmaensinomedio = value;
            }
        }
    }
}
