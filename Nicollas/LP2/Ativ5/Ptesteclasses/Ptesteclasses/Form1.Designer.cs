namespace Ptesteclasses
{
    partial class frmPrincipal
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
            this.butMensalista = new System.Windows.Forms.Button();
            this.butHorista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butMensalista
            // 
            this.butMensalista.Location = new System.Drawing.Point(95, 151);
            this.butMensalista.Name = "butMensalista";
            this.butMensalista.Size = new System.Drawing.Size(135, 67);
            this.butMensalista.TabIndex = 0;
            this.butMensalista.Text = "Mensalista";
            this.butMensalista.UseVisualStyleBackColor = true;
            this.butMensalista.Click += new System.EventHandler(this.butMensalista_Click);
            // 
            // butHorista
            // 
            this.butHorista.Location = new System.Drawing.Point(95, 42);
            this.butHorista.Name = "butHorista";
            this.butHorista.Size = new System.Drawing.Size(135, 67);
            this.butHorista.TabIndex = 1;
            this.butHorista.Text = "Horista";
            this.butHorista.UseVisualStyleBackColor = true;
            this.butHorista.Click += new System.EventHandler(this.butHorista_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 269);
            this.Controls.Add(this.butHorista);
            this.Controls.Add(this.butMensalista);
            this.Name = "frmPrincipal";
            this.Text = "frmEmprego";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butMensalista;
        private System.Windows.Forms.Button butHorista;
    }
}

