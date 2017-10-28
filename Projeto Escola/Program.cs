using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Escola
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            formprincipal TelaPrincipal = new formprincipal();
            TelaPrincipal.Show();
            login loginForm = new login();
            loginForm.ShowDialog(); // Run Login Form.
            
            Application.Run();
        }
    }
}
