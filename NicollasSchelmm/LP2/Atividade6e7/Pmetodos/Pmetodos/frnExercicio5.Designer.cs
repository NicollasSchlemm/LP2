namespace Pmetodos
{
    partial class txtNum1
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.bntSorteio = new System.Windows.Forms.Button();
            this.txtNum01 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(97, 45);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(53, 13);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Numero 1";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(97, 91);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(53, 13);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Numero 2";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(156, 88);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 2;
            // 
            // bntSorteio
            // 
            this.bntSorteio.Location = new System.Drawing.Point(156, 169);
            this.bntSorteio.Name = "bntSorteio";
            this.bntSorteio.Size = new System.Drawing.Size(100, 35);
            this.bntSorteio.TabIndex = 4;
            this.bntSorteio.Text = "Sorteio do Numero";
            this.bntSorteio.UseVisualStyleBackColor = true;
            this.bntSorteio.Click += new System.EventHandler(this.bntSorteio_Click);
            // 
            // txtNum01
            // 
            this.txtNum01.Location = new System.Drawing.Point(156, 42);
            this.txtNum01.Name = "txtNum01";
            this.txtNum01.Size = new System.Drawing.Size(100, 20);
            this.txtNum01.TabIndex = 5;
            // 
            // txtNum1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 266);
            this.Controls.Add(this.txtNum01);
            this.Controls.Add(this.bntSorteio);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Name = "txtNum1";
            this.Text = "frnExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button bntSorteio;
        private System.Windows.Forms.TextBox txtNum01;
    }
}