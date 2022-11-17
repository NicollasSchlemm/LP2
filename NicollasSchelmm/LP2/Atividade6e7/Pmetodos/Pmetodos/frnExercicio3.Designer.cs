namespace Pmetodos
{
    partial class frnExercicio3
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
            this.button1 = new System.Windows.Forms.Button();
            this.bntReaplace = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTexto1 = new System.Windows.Forms.TextBox();
            this.txtTexto2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Remove ocorrecia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntReaplace
            // 
            this.bntReaplace.Location = new System.Drawing.Point(348, 252);
            this.bntReaplace.Name = "bntReaplace";
            this.bntReaplace.Size = new System.Drawing.Size(119, 67);
            this.bntReaplace.TabIndex = 1;
            this.bntReaplace.Text = "Remove Ocorrencia(Reaplace)";
            this.bntReaplace.UseVisualStyleBackColor = true;
            this.bntReaplace.Click += new System.EventHandler(this.bntReaplace_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(607, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "Inverte";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTexto1
            // 
            this.txtTexto1.Location = new System.Drawing.Point(317, 61);
            this.txtTexto1.Name = "txtTexto1";
            this.txtTexto1.Size = new System.Drawing.Size(167, 20);
            this.txtTexto1.TabIndex = 3;
            // 
            // txtTexto2
            // 
            this.txtTexto2.Location = new System.Drawing.Point(317, 126);
            this.txtTexto2.Name = "txtTexto2";
            this.txtTexto2.Size = new System.Drawing.Size(167, 20);
            this.txtTexto2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Texto2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Texto1";
            // 
            // frnExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto2);
            this.Controls.Add(this.txtTexto1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bntReaplace);
            this.Controls.Add(this.button1);
            this.Name = "frnExercicio3";
            this.Text = "frnExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntReaplace;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTexto1;
        private System.Windows.Forms.TextBox txtTexto2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}