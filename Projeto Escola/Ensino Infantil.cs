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
    public partial class Ensino_Infantil : Form
    {
        private List<EnsinoInfantil> listaensinoinfantil = new List<EnsinoInfantil>();

        private EnsinoInfantil ensinoinfantil;
        private Cadastro_Escola escola;

        public List<EnsinoInfantil> Listaensinoinfantil
        {
            get
            {
                return listaensinoinfantil;
            }

            set
            {
                listaensinoinfantil = value;
            }
        }

        public Ensino_Infantil(Cadastro_Escola esc)
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
           
            if (checkBox1.Checked)
            {
                ensinoinfantil = new EnsinoInfantil();

                ensinoinfantil.Anoi= checkBox1.Text;
                ensinoinfantil.Niveli = label1.Text;
                ensinoinfantil.Qtdi = int.Parse(textBox12.Text);

                Listaensinoinfantil.Add(ensinoinfantil);

             }

            if (checkBox2.Checked)
            {
                ensinoinfantil = new EnsinoInfantil();

                ensinoinfantil.Anoi = checkBox2.Text;
                ensinoinfantil.Niveli = label1.Text;
                ensinoinfantil.Qtdi = int.Parse(textBox15.Text);

                Listaensinoinfantil.Add(ensinoinfantil);

            }

            if (checkBox3.Checked)
            {
                ensinoinfantil = new EnsinoInfantil();

                ensinoinfantil.Anoi = checkBox3.Text;
                ensinoinfantil.Niveli = label1.Text;
                ensinoinfantil.Qtdi = int.Parse(textBox13.Text);
                Listaensinoinfantil.Add(ensinoinfantil);
            }

            if (checkBox4.Checked)
            {
                ensinoinfantil = new EnsinoInfantil();

                ensinoinfantil.Anoi = checkBox1.Text;
                ensinoinfantil.Niveli = label1.Text;
                ensinoinfantil.Qtdi = int.Parse(textBox14.Text);
                Listaensinoinfantil.Add(ensinoinfantil);

            }

            if (checkBox5.Checked)
            {
                ensinoinfantil = new EnsinoInfantil();

                ensinoinfantil.Anoi = checkBox1.Text;
                ensinoinfantil.Niveli = label1.Text;
                ensinoinfantil.Qtdi = int.Parse(textBox16.Text);
                Listaensinoinfantil.Add(ensinoinfantil);

            }

            if (checkBox6.Checked)
            {
                ensinoinfantil = new EnsinoInfantil();

                ensinoinfantil.Anoi = checkBox1.Text;
                ensinoinfantil.Niveli = label1.Text;
                ensinoinfantil.Qtdi = int.Parse(textBox17.Text);
                Listaensinoinfantil.Add(ensinoinfantil);

            }


            
            this.Close();
            Banco.Listainfantil = Listaensinoinfantil;
            escola.setDataSource(Listaensinoinfantil);
            escola.Show();
        }

        

        private void Ensino_Infantil_Load(object sender, EventArgs e)
        {

        }
    }
}
