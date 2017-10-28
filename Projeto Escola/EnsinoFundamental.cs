using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Escola
{
    public class EnsinoFundamental
    {
        private string nivelf;
        private string anof;
        private int qtdf;

        public string Nivelf
        {
            get
            {
                return nivelf;
            }

            set
            {
                nivelf = value;
            }
        }

        public string Anof
        {
            get
            {
                return anof;
            }

            set
            {
                anof = value;
            }
        }

        public int Qtdf
        {
            get
            {
                return qtdf;
            }

            set
            {
                qtdf = value;
            }
        }

        public override string ToString()
        {
            return this.Nivelf + " - " + this.Anof;
        }
    }
}
