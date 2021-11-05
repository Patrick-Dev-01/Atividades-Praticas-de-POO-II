using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            string usuario = textBox_usuario.Text;
            string senha = textBox_senha.Text;

            if (usuario != "administrador" && senha != "admin")
            {
                MessageBox.Show("Usuário ou Senha Incorretos", "Erro de Autenticação");
            }

            else {
                menu.Show();
            }
        }
    }
}
