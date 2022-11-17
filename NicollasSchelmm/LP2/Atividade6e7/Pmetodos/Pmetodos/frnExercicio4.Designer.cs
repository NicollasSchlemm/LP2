namespace Pmetodos
{
    partial class bntQantLetras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bntQuantNum = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bntProcuraEspa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(517, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(248, 365);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // bntQuantNum
            // 
            this.bntQuantNum.Location = new System.Drawing.Point(274, 12);
            this.bntQuantNum.Name = "bntQuantNum";
            this.bntQuantNum.Size = new System.Drawing.Size(75, 64);
            this.bntQuantNum.TabIndex = 1;
            this.bntQuantNum.Text = "Contador de Numero";
            this.bntQuantNum.UseVisualStyleBackColor = true;
            this.bntQuantNum.Click += new System.EventHandler(this.bntQuantNum_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Contador de letras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntProcuraEspa
            // 
            this.bntProcuraEspa.Location = new System.Drawing.Point(274, 163);
            this.bntProcuraEspa.Name = "bntProcuraEspa";
            this.bntProcuraEspa.Size = new System.Drawing.Size(75, 64);
            this.bntProcuraEspa.TabIndex = 3;
            this.bntProcuraEspa.Text = "Procura 1º espaço";
            this.bntProcuraEspa.UseVisualStyleBackColor = true;
            this.bntProcuraEspa.Click += new System.EventHandler(this.bntProcuraEspa_Click);
            // 
            // bntQantLetras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 389);
            this.Controls.Add(this.bntProcuraEspa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bntQuantNum);
            this.Controls.Add(this.richTextBox1);
            this.Name = "bntQantLetras";
            this.Text = "frnExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bntQuantNum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bntProcuraEspa;
    }
}