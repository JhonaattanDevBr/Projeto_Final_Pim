using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace InterfacesDoSistemaDesktop.Interfaces_Formularios
{
    public partial class Form_Accesskey : Form
    {
        Thread t1;
        public Form_Accesskey()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            string accessKey = "abc123";
            if(txtAccessKey.Text == accessKey)
            {
                this.Close();
                t1 = new Thread(abrirFormulario);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
                //Form_CadUsuarioPersonalD form_CadUsuarioPersonalD = new Form_CadUsuarioPersonalD();
                //form_CadUsuarioPersonalD.ShowDialog();
            }
            else
            {
                MessageBox.Show("Access Key invalida!");
                txtAccessKey.Clear();
                txtAccessKey.Focus();
            }
        }

        private void abrirFormulario(object obj)
        {
            Application.Run(new Form_CadUsuarioPersonalD());
        }
    }
}
