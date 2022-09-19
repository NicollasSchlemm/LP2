namespace Calculadora
{
    partial class Form1
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.Mais = new System.Windows.Forms.Button();
            this.Menos = new System.Windows.Forms.Button();
            this.Vezes = new System.Windows.Forms.Button();
            this.Divisão = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.Sair = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero2";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(114, 6);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(114, 45);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            // 
            // Mais
            // 
            this.Mais.Location = new System.Drawing.Point(61, 124);
            this.Mais.Name = "Mais";
            this.Mais.Size = new System.Drawing.Size(75, 41);
            this.Mais.TabIndex = 4;
            this.Mais.Text = "+";
            this.Mais.UseVisualStyleBackColor = true;
            this.Mais.Click += new System.EventHandler(this.Mais_Click);
            // 
            // Menos
            // 
            this.Menos.Location = new System.Drawing.Point(175, 124);
            this.Menos.Name = "Menos";
            this.Menos.Size = new System.Drawing.Size(75, 41);
            this.Menos.TabIndex = 5;
            this.Menos.Text = "-";
            this.Menos.UseVisualStyleBackColor = true;
            this.Menos.Click += new System.EventHandler(this.Menos_Click);
            // 
            // Vezes
            // 
            this.Vezes.Location = new System.Drawing.Point(61, 194);
            this.Vezes.Name = "Vezes";
            this.Vezes.Size = new System.Drawing.Size(75, 42);
            this.Vezes.TabIndex = 6;
            this.Vezes.Text = "x";
            this.Vezes.UseVisualStyleBackColor = true;
            this.Vezes.Click += new System.EventHandler(this.Vezes_Click);
            // 
            // Divisão
            // 
            this.Divisão.Location = new System.Drawing.Point(175, 194);
            this.Divisão.Name = "Divisão";
            this.Divisão.Size = new System.Drawing.Size(75, 42);
            this.Divisão.TabIndex = 7;
            this.Divisão.Text = "/";
            this.Divisão.UseVisualStyleBackColor = true;
            this.Divisão.Click += new System.EventHandler(this.Divisão_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(114, 83);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 9;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(241, 27);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 10;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(241, 67);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 23);
            this.Limpar.TabIndex = 11;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 248);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Divisão);
            this.Controls.Add(this.Vezes);
            this.Controls.Add(this.Menos);
            this.Controls.Add(this.Mais);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button Mais;
        private System.Windows.Forms.Button Menos;
        private System.Windows.Forms.Button Vezes;
        private System.Windows.Forms.Button Divisão;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Limpar;
    }
}

