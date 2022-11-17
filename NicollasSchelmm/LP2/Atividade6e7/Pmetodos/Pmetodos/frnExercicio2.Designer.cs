namespace Pmetodos
{
    partial class frnExercicio2
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
            this.bntIGUAIS = new System.Windows.Forms.Button();
            this.bntInserText1NoText2 = new System.Windows.Forms.Button();
            this.bntColocarAsteristico = new System.Windows.Forms.Button();
            this.txtTexto2 = new System.Windows.Forms.TextBox();
            this.txtTexto1 = new System.Windows.Forms.TextBox();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntIGUAIS
            // 
            this.bntIGUAIS.Location = new System.Drawing.Point(37, 191);
            this.bntIGUAIS.Name = "bntIGUAIS";
            this.bntIGUAIS.Size = new System.Drawing.Size(156, 63);
            this.bntIGUAIS.TabIndex = 0;
            this.bntIGUAIS.Text = "Testar Iguais";
            this.bntIGUAIS.UseVisualStyleBackColor = true;
            this.bntIGUAIS.Click += new System.EventHandler(this.bntIGUAIS_Click);
            // 
            // bntInserText1NoText2
            // 
            this.bntInserText1NoText2.Location = new System.Drawing.Point(250, 191);
            this.bntInserText1NoText2.Name = "bntInserText1NoText2";
            this.bntInserText1NoText2.Size = new System.Drawing.Size(137, 63);
            this.bntInserText1NoText2.TabIndex = 1;
            this.bntInserText1NoText2.Text = "Inserir Texto1 no Texto2";
            this.bntInserText1NoText2.UseVisualStyleBackColor = true;
            this.bntInserText1NoText2.Click += new System.EventHandler(this.bntInserText1NoText2_Click);
            // 
            // bntColocarAsteristico
            // 
            this.bntColocarAsteristico.Location = new System.Drawing.Point(455, 191);
            this.bntColocarAsteristico.Name = "bntColocarAsteristico";
            this.bntColocarAsteristico.Size = new System.Drawing.Size(148, 63);
            this.bntColocarAsteristico.TabIndex = 2;
            this.bntColocarAsteristico.Text = "Inserir Asteristico no meio do primeiro";
            this.bntColocarAsteristico.UseVisualStyleBackColor = true;
            this.bntColocarAsteristico.Click += new System.EventHandler(this.bntColocarAsteristico_Click);
            // 
            // txtTexto2
            // 
            this.txtTexto2.Location = new System.Drawing.Point(238, 96);
            this.txtTexto2.Name = "txtTexto2";
            this.txtTexto2.Size = new System.Drawing.Size(168, 20);
            this.txtTexto2.TabIndex = 3;
            // 
            // txtTexto1
            // 
            this.txtTexto1.Location = new System.Drawing.Point(238, 42);
            this.txtTexto1.Name = "txtTexto1";
            this.txtTexto1.Size = new System.Drawing.Size(168, 20);
            this.txtTexto1.TabIndex = 4;
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Location = new System.Drawing.Point(150, 45);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(43, 13);
            this.lblTexto1.TabIndex = 5;
            this.lblTexto1.Text = "Texto 1";
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Location = new System.Drawing.Point(153, 99);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(40, 13);
            this.lblTexto2.TabIndex = 6;
            this.lblTexto2.Text = "Texto2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frnExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.lblTexto1);
            this.Controls.Add(this.txtTexto1);
            this.Controls.Add(this.txtTexto2);
            this.Controls.Add(this.bntColocarAsteristico);
            this.Controls.Add(this.bntInserText1NoText2);
            this.Controls.Add(this.bntIGUAIS);
            this.Name = "frnExercicio2";
            this.Text = "frnExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntIGUAIS;
        private System.Windows.Forms.Button bntInserText1NoText2;
        private System.Windows.Forms.Button bntColocarAsteristico;
        private System.Windows.Forms.TextBox txtTexto2;
        private System.Windows.Forms.TextBox txtTexto1;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.Button button1;
    }
}