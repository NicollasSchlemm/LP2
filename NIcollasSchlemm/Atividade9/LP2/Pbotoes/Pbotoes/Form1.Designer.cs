namespace Pbotoes
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
            this.btnVetorInverte = new System.Windows.Forms.Button();
            this.btnMercadora = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVetorInverte
            // 
            this.btnVetorInverte.Location = new System.Drawing.Point(119, 56);
            this.btnVetorInverte.Name = "btnVetorInverte";
            this.btnVetorInverte.Size = new System.Drawing.Size(113, 50);
            this.btnVetorInverte.TabIndex = 0;
            this.btnVetorInverte.Text = "Recebe e inverte vetor";
            this.btnVetorInverte.UseVisualStyleBackColor = true;
            this.btnVetorInverte.Click += new System.EventHandler(this.btnVetorInverte_Click);
            // 
            // btnMercadora
            // 
            this.btnMercadora.Location = new System.Drawing.Point(322, 56);
            this.btnMercadora.Name = "btnMercadora";
            this.btnMercadora.Size = new System.Drawing.Size(113, 50);
            this.btnMercadora.TabIndex = 1;
            this.btnMercadora.Text = "Mercadoria";
            this.btnMercadora.UseVisualStyleBackColor = true;
            this.btnMercadora.Click += new System.EventHandler(this.btnMercadora_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(520, 56);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(113, 50);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "alunos";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(119, 256);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(113, 50);
            this.btnMedia.TabIndex = 3;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnMercadora);
            this.Controls.Add(this.btnVetorInverte);
            this.Name = "Form1";
            this.Text = "form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVetorInverte;
        private Button btnMercadora;
        private Button btnTotal;
        private Button btnMedia;
    }
}