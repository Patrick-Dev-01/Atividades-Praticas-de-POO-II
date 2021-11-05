using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Rust
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imcButton_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToInt32(pesoTextbox.Text);
            double altura = Convert.ToInt32(alturaTextbox.Text);
            double resultadoImc = peso / (altura * altura);

            imcResultado.Text = "" + resultadoImc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
