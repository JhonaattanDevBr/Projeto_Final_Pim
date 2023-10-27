using InterfacesDoSistemaDesktop.Interfaces_Acesso;
using InterfacesDoSistemaDesktop.Interfaces_AtualizarDados;
using InterfacesDoSistemaDesktop.Interfaces_Formularios;
using InterfacesDoSistemaDesktop.Interfaces_Views_Delete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesDoSistemaDesktop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form_AtualizarConvMedico());
        }
    }
}
