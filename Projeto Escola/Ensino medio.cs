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
    public partial class Ensino_medio : Form
    {
        private List<Ensinomedio> listaensinomedio = new List<Ensinomedio>();

        private Ensinomedio ensinomedio;
        private Cadastro_Escola escola;

        public List<Ensinomedio> Listaensinomedio
        {
            get
            {
                return listaensinomedio;
            }

            set
            {
                listaensinomedio = value;
            }
        }

        public Ensinomedio Ensinomedio
        {
            get
            {
                return ensinomedio;
            }

            set
            {
                ensinomedio = value;
            }
        }

        public Ensino_medio(Cadastro_Escola esc)
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
            
            if (checkBox16.Checked)
            {
                ensinomedio = new Ensinomedio();

                ensinomedio.Anom = checkBox16.Text;
                Ensinomedio.Nivelm = label6.Text;
                Ensinomedio.Qtdm = int.Parse(textBox18.Text);

                Listaensinomedio.Add(Ensinomedio);

            }

            if (checkBox17.Checked)
            {
                Ensinomedio = new Ensinomedio();

                Ensinomedio.Anom = checkBox17.Text;
                Ensinomedio.Nivelm = label6.Text;
                Ensinomedio.Qtdm = int.Parse(textBox19.Text);

                Listaensinomedio.Add(Ensinomedio);

            }

            if (checkBox18.Checked)
            {
                Ensinomedio = new Ensinomedio();

                Ensinomedio.Anom = checkBox18.Text;
                Ensinomedio.Nivelm = label6.Text;
                Ensinomedio.Qtdm = int.Parse(textBox20.Text);

                Listaensinomedio.Add(Ensinomedio);
            }




            this.Close();
            Banco.Listamedio = Listaensinomedio;
            escola.setDataSourcem(Listaensinomedio);
            escola.Show();
        }

        private void Ensino_medio_Load(object sender, EventArgs e)
        {

        }
    }
}

