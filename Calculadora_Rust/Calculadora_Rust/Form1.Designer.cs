
namespace Calculadora_Rust
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pesoLabel = new System.Windows.Forms.Label();
            this.alturaLabel = new System.Windows.Forms.Label();
            this.pesoTextbox = new System.Windows.Forms.TextBox();
            this.alturaTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imcResultado = new System.Windows.Forms.Label();
            this.imcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pesoLabel
            // 
            this.pesoLabel.AutoSize = true;
            this.pesoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pesoLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pesoLabel.Location = new System.Drawing.Point(50, 20);
            this.pesoLabel.Name = "pesoLabel";
            this.pesoLabel.Size = new System.Drawing.Size(55, 28);
            this.pesoLabel.TabIndex = 0;
            this.pesoLabel.Text = "Peso";
            // 
            // alturaLabel
            // 
            this.alturaLabel.AutoSize = true;
            this.alturaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alturaLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.alturaLabel.Location = new System.Drawing.Point(199, 20);
            this.alturaLabel.Name = "alturaLabel";
            this.alturaLabel.Size = new System.Drawing.Size(119, 28);
            this.alturaLabel.TabIndex = 1;
            this.alturaLabel.Text = "Altura (cm)";
            // 
            // pesoTextbox
            // 
            this.pesoTextbox.Location = new System.Drawing.Point(25, 65);
            this.pesoTextbox.Name = "pesoTextbox";
            this.pesoTextbox.Size = new System.Drawing.Size(114, 27);
            this.pesoTextbox.TabIndex = 2;
            // 
            // alturaTextbox
            // 
            this.alturaTextbox.Location = new System.Drawing.Point(199, 65);
            this.alturaTextbox.Name = "alturaTextbox";
            this.alturaTextbox.Size = new System.Drawing.Size(117, 27);
            this.alturaTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(141, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "IMC";
            // 
            // imcResultado
            // 
            this.imcResultado.AccessibleName = "imcResultLabel";
            this.imcResultado.AutoSize = true;
            this.imcResultado.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imcResultado.Location = new System.Drawing.Point(159, 160);
            this.imcResultado.Name = "imcResultado";
            this.imcResultado.Size = new System.Drawing.Size(19, 31);
            this.imcResultado.TabIndex = 5;
            this.imcResultado.Text = ":";
            // 
            // imcButton
            // 
            this.imcButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.imcButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imcButton.ForeColor = System.Drawing.Color.White;
            this.imcButton.Location = new System.Drawing.Point(113, 209);
            this.imcButton.Name = "imcButton";
            this.imcButton.Size = new System.Drawing.Size(112, 48);
            this.imcButton.TabIndex = 6;
            this.imcButton.Text = "Calcular";
            this.imcButton.UseVisualStyleBackColor = false;
            this.imcButton.Click += new System.EventHandler(this.imcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.imcButton);
            this.Controls.Add(this.imcResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alturaTextbox);
            this.Controls.Add(this.pesoTextbox);
            this.Controls.Add(this.alturaLabel);
            this.Controls.Add(this.pesoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pesoLabel;
        private System.Windows.Forms.Label alturaLabel;
        private System.Windows.Forms.TextBox pesoTextbox;
        private System.Windows.Forms.TextBox alturaTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label imcResultado;
        private System.Windows.Forms.Button imcButton;
    }
}

