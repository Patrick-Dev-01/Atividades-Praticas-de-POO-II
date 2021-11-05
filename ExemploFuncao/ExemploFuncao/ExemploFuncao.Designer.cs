
namespace ExemploFuncao
{
    partial class ExemploFuncao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_soma = new System.Windows.Forms.Button();
            this.button_subtracao = new System.Windows.Forms.Button();
            this.button_multiplicao = new System.Windows.Forms.Button();
            this.button_divisao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 22);
            this.textBox2.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(327, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(135, 58);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // button_soma
            // 
            this.button_soma.Location = new System.Drawing.Point(488, 36);
            this.button_soma.Name = "button_soma";
            this.button_soma.Size = new System.Drawing.Size(133, 55);
            this.button_soma.TabIndex = 5;
            this.button_soma.Text = "SOMA";
            this.button_soma.UseVisualStyleBackColor = true;
            this.button_soma.Click += new System.EventHandler(this.button_soma_Click);
            // 
            // button_subtracao
            // 
            this.button_subtracao.Location = new System.Drawing.Point(640, 36);
            this.button_subtracao.Name = "button_subtracao";
            this.button_subtracao.Size = new System.Drawing.Size(132, 55);
            this.button_subtracao.TabIndex = 6;
            this.button_subtracao.Text = "SUBTRAÇÃO";
            this.button_subtracao.UseVisualStyleBackColor = true;
            this.button_subtracao.Click += new System.EventHandler(this.button_subtracao_Click);
            // 
            // button_multiplicao
            // 
            this.button_multiplicao.Location = new System.Drawing.Point(488, 97);
            this.button_multiplicao.Name = "button_multiplicao";
            this.button_multiplicao.Size = new System.Drawing.Size(133, 63);
            this.button_multiplicao.TabIndex = 7;
            this.button_multiplicao.Text = "MULTIPLICAÇÃO";
            this.button_multiplicao.UseVisualStyleBackColor = true;
            this.button_multiplicao.Click += new System.EventHandler(this.button_multiplicao_Click);
            // 
            // button_divisao
            // 
            this.button_divisao.Location = new System.Drawing.Point(640, 97);
            this.button_divisao.Name = "button_divisao";
            this.button_divisao.Size = new System.Drawing.Size(132, 63);
            this.button_divisao.TabIndex = 8;
            this.button_divisao.Text = "DIVISÃO";
            this.button_divisao.UseVisualStyleBackColor = true;
            this.button_divisao.Click += new System.EventHandler(this.button_divisao_Click);
            // 
            // ExemploFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_divisao);
            this.Controls.Add(this.button_multiplicao);
            this.Controls.Add(this.button_subtracao);
            this.Controls.Add(this.button_soma);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExemploFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExemploFuncao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_soma;
        private System.Windows.Forms.Button button_subtracao;
        private System.Windows.Forms.Button button_multiplicao;
        private System.Windows.Forms.Button button_divisao;
    }
}

