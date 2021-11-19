using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projetodas3camadas.Code.BLL;
using Projetodas3camadas.Code.DTO;

namespace Projetodas3camadas
{
    public partial class Form1 : Form
    {
        Futebol_BLL futbll = new Futebol_BLL();
        Futebol_DTO futdto = new Futebol_DTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            futdto.NOME = txt_nome.Text;
            futdto.POSICAO = txt_posicao.Text;

            futbll.inserir(futdto);
        }
    }
}
