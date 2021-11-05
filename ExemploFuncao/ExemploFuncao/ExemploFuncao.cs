using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExemploFuncao
{
    public partial class ExemploFuncao : Form
    {
        public ExemploFuncao()
        {
            InitializeComponent();
        }

        private void button_soma_Click(object sender, EventArgs e)
        {
            Operacao operacao = new Operacao();

            try
            {
                richTextBox1.Text = operacao.RealizarOperacao(textBox1.Text, textBox2.Text, "SOMA");
            }

            catch(Exception ex)
            {
                string err = ex.Message;
                err += " !!!";
                MessageBox.Show(err, "ERRO");
            }
        }

        private void button_subtracao_Click(object sender, EventArgs e)
        {
            Operacao operacao = new Operacao();

            try
            {
                richTextBox1.Text = operacao.RealizarOperacao(textBox1.Text, textBox2.Text, "SUBTRACAO");
            }

            catch (Exception ex)
            {
                string err = ex.Message;
                err += " !!!";
                MessageBox.Show(err, "ERRO");
            }
        }

        private void button_multiplicao_Click(object sender, EventArgs e)
        {
            Operacao operacao = new Operacao();

            try
            {
                richTextBox1.Text = operacao.RealizarOperacao(textBox1.Text, textBox2.Text, "MULTIPLICACAO");
            }

            catch (Exception ex)
            {
                string err = ex.Message;
                err += " !!!";
                MessageBox.Show(err, "ERRO");
            }
        }

        private void button_divisao_Click(object sender, EventArgs e)
        {
            Operacao operacao = new Operacao();

            try
            {
                richTextBox1.Text = operacao.RealizarOperacao(textBox1.Text, textBox2.Text, "DIVISAO");
            }

            catch (Exception ex)
            {
                string err = ex.Message;
                err += " !!!";
                MessageBox.Show(err, "ERRO");
            }
        }
    }
}
