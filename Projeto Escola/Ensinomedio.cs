using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Escola
{
   public class Ensinomedio
    {
        private string nivelm;
        private string anom;
        private int qtdm;

        public string Nivelm
        {
            get
            {
                return nivelm;
            }

            set
            {
                nivelm = value;
            }
        }

        public string Anom
        {
            get
            {
                return anom;
            }

            set
            {
                anom = value;
            }
        }

        public int Qtdm
        {
            get
            {
                return qtdm;
            }

            set
            {
                qtdm = value;
            }
        }

        public override string ToString()
        {
            return this.Nivelm + " - " + this.Anom;
        }
    }
}
