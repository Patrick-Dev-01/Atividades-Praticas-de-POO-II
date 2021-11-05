using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Atividade_3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button_logar_Click(object sender, EventArgs e)
        {
            Classes.Autenticacao autenticao = new Classes.Autenticacao();  

            autenticao.Autenticar(textBox1.Text, textBox2.Text);

            if (autenticao.resultado)
            {
                MessageBox.Show("Logado com Sucesso", "Autenticação");
            }

            else { 
                MessageBox.Show("Usuário ou senha incorretos", "Autenticação");
            }
        }
    }
}
