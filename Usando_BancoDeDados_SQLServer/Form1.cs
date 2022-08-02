using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usando_BancoDeDados_SQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            string nome = txt_nome.Text;
            string fone = txt_telefone.Text;

            Cadastrar cad = new Cadastrar(nome, fone);
            MessageBox.Show(cad.msg);
        }
    }
}
