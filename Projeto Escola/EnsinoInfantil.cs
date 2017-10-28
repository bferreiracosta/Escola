using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Escola
{
    public class EnsinoInfantil
    {
        private string niveli;
        private string anoi;
        private int qtdi;

        public string Niveli
        {
            get
            {
                return niveli;
            }

            set
            {
                niveli = value;
            }
        }

        public string Anoi
        {
            get
            {
                return anoi;
            }

            set
            {
                anoi = value;
            }
        }

        public int Qtdi
        {
            get
            {
                return qtdi;
            }

            set
            {
                qtdi = value;
            }
        }

        public override string ToString()
        {
            return this.Niveli + " - " + this.Anoi;
        }
    }
}
