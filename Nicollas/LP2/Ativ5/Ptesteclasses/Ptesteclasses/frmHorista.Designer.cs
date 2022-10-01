namespace Ptesteclasses
{
    partial class frmHorista
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.rbtnNão = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.txtDataEnt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalaHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumHora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiasFalta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butInstanciarHorista = new System.Windows.Forms.Button();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(286, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(175, 20);
            this.txtNome.TabIndex = 11;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(286, 54);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 10;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Matrícula";
            // 
            // gbxHome
            // 
            this.gbxHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxHome.CausesValidation = false;
            this.gbxHome.Controls.Add(this.rbtnNão);
            this.gbxHome.Controls.Add(this.rbtnSim);
            this.gbxHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbxHome.Location = new System.Drawing.Point(534, 99);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(200, 100);
            this.gbxHome.TabIndex = 12;
            this.gbxHome.TabStop = false;
            this.gbxHome.Text = "Trabalha Em Home Office";
            // 
            // rbtnNão
            // 
            this.rbtnNão.AutoSize = true;
            this.rbtnNão.Checked = true;
            this.rbtnNão.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnNão.Location = new System.Drawing.Point(30, 66);
            this.rbtnNão.Name = "rbtnNão";
            this.rbtnNão.Size = new System.Drawing.Size(45, 17);
            this.rbtnNão.TabIndex = 1;
            this.rbtnNão.TabStop = true;
            this.rbtnNão.Text = "Não";
            this.rbtnNão.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(30, 34);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(42, 17);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // txtDataEnt
            // 
            this.txtDataEnt.Location = new System.Drawing.Point(286, 221);
            this.txtDataEnt.Name = "txtDataEnt";
            this.txtDataEnt.Size = new System.Drawing.Size(100, 20);
            this.txtDataEnt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data de Entrada na Empresa";
            // 
            // txtSalaHora
            // 
            this.txtSalaHora.Location = new System.Drawing.Point(286, 143);
            this.txtSalaHora.Name = "txtSalaHora";
            this.txtSalaHora.Size = new System.Drawing.Size(100, 20);
            this.txtSalaHora.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Salario por hora";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNumHora
            // 
            this.txtNumHora.Location = new System.Drawing.Point(286, 183);
            this.txtNumHora.Name = "txtNumHora";
            this.txtNumHora.Size = new System.Drawing.Size(100, 20);
            this.txtNumHora.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nimero de Horas";
            // 
            // txtDiasFalta
            // 
            this.txtDiasFalta.Location = new System.Drawing.Point(286, 265);
            this.txtDiasFalta.Name = "txtDiasFalta";
            this.txtDiasFalta.Size = new System.Drawing.Size(100, 20);
            this.txtDiasFalta.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Dias de falta";
            // 
            // butInstanciarHorista
            // 
            this.butInstanciarHorista.Location = new System.Drawing.Point(247, 306);
            this.butInstanciarHorista.Name = "butInstanciarHorista";
            this.butInstanciarHorista.Size = new System.Drawing.Size(267, 63);
            this.butInstanciarHorista.TabIndex = 21;
            this.butInstanciarHorista.Text = "Instaciar Horista";
            this.butInstanciarHorista.UseVisualStyleBackColor = true;
            this.butInstanciarHorista.Click += new System.EventHandler(this.butInstanciarHorista_Click);
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 391);
            this.Controls.Add(this.butInstanciarHorista);
            this.Controls.Add(this.txtDiasFalta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalaHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataEnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.Load += new System.EventHandler(this.frmHorista_Load);
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.RadioButton rbtnNão;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.TextBox txtDataEnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalaHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiasFalta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butInstanciarHorista;
    }
}