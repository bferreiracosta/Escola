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
    public partial class Ensino_Fundamental : Form
    {
        private EnsinoFundamental ensinofundamental;
        public List<EnsinoFundamental> listaensinofundamental = new List<EnsinoFundamental>();
        private Cadastro_Escola escola;

        public EnsinoFundamental Ensinofundamental
        {
            get
            {
                return ensinofundamental;
            }

            set
            {
                ensinofundamental = value;
            }
        }

        public Ensino_Fundamental(Cadastro_Escola esc)
        {
            InitializeComponent();
            escola = esc;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                Ensinofundamental = new EnsinoFundamental();

                Ensinofundamental.Anof = checkBox7.Text;
                Ensinofundamental.Nivelf = label1.Text;
                Ensinofundamental.Qtdf = int.Parse(textBox1.Text);

                listaensinofundamental.Add(Ensinofundamental);

            }

            if (checkBox11.Checked)
            {
                Ensinofundamental = new EnsinoFundamental();

                Ensinofundamental.Anof = checkBox11.Text;
                Ensinofundamental.Nivelf = label1.Text;
                Ensinofundamental.Qtdf = int.Parse(textBox2.Text);

                listaensinofundamental.Add(Ensinofundamental);


            }

            if (checkBox13.Checked)
            {
                Ensinofundamental = new EnsinoFundamental();

                Ensinofundamental.Anof = checkBox13.Text;
                Ensinofundamental.Nivelf = label1.Text;
                Ensinofundamental.Qtdf = int.Parse(textBox3.Text);

                listaensinofundamental.Add(Ensinofundamental);

            }

            if (checkBox8.Checked)
            {
                Ensinofundamental = new EnsinoFundamental();

                Ensinofundamental.Anof = checkBox8.Text;
                Ensinofundamental.Nivelf = label1.Text;
                Ensinofundamental.Qtdf = int.Parse(textBox5.Text);

                listaensinofundamental.Add(Ensinofundamental);


            }

            if (checkBox12.Checked)
            {
                Ensinofundamental = new EnsinoFundamental();

                Ensinofundamental.Anof = checkBox12.Text;
                Ensinofundamental.Nivelf = label1.Text;
                Ensinofundamental.Qtdf = int.Parse(textBox6.Text);

                listaensinofundamental.Add(Ensinofundamental);


            }

            if (checkBox9.Checked)
            {
                Ensinofundamental = new EnsinoFundamental();

                Ensinofundamental.Anof = checkBox9.Text;
                Ensinofundamental.Nivelf = label1.Text;
                Ensinofundamental.Qtdf = int.Parse(textBox8.Text);

                listaensinofundamental.Add(Ensinofundamental);

            }

            if (checkBox15.Checked)
            {
                Ensinofundamental = new EnsinoFundamental();

                Ensinofundamental.Anof = checkBox15.Text;
                Ensinofundamental.Nivelf = label1.Text;
                Ensinofundamental.Qtdf = int.Parse(textBox9.Text);

                listaensinofundamental.Add(Ensinofundamental);


            }

            if (checkBox10.Checked)
            {
                Ensinofundamental = new EnsinoFundamental();

                Ensinofundamental.Anof = checkBox10.Text;
                Ensinofundamental.Nivelf = label1.Text;
                Ensinofundamental.Qtdf = int.Parse(textBox4.Text);

                listaensinofundamental.Add(Ensinofundamental);

            }

            if (checkBox14.Checked)
            {
                Ensinofundamental = new EnsinoFundamental();

                Ensinofundamental.Anof = checkBox14.Text;
                Ensinofundamental.Nivelf = label1.Text;
                Ensinofundamental.Qtdf = int.Parse(textBox7.Text);

                listaensinofundamental.Add(Ensinofundamental);


            }
                       
            
            Banco.Listafundamental = listaensinofundamental;
            escola.setDataSourcef(listaensinofundamental);
            this.Close();
            escola.Show();
        }

        private void Ensino_Fundamental_Load(object sender, EventArgs e)
        {

        }
    }


}

