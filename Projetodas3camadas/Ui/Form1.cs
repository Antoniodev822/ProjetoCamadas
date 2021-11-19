using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetodas3camadas.Ui
{
    public partial class Form1 : Form
    {
        LogiDto logiDto = new LogiDto();
        loginb loginb = new loginb(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            logiDto.Email = txt_email.Text;

            loginb.Senha = txt_senha.Text;

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

        }
    }
}
