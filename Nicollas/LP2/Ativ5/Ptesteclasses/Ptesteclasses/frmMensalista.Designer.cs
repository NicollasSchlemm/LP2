namespace Ptesteclasses
{
    partial class frmMensalista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtDataEnt = new System.Windows.Forms.TextBox();
            this.txtSalaMensal = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.rbtnNão = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario Mensal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(234, 40);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtDataEnt
            // 
            this.txtDataEnt.Location = new System.Drawing.Point(234, 180);
            this.txtDataEnt.Name = "txtDataEnt";
            this.txtDataEnt.Size = new System.Drawing.Size(100, 20);
            this.txtDataEnt.TabIndex = 5;
            // 
            // txtSalaMensal
            // 
            this.txtSalaMensal.Location = new System.Drawing.Point(234, 128);
            this.txtSalaMensal.Name = "txtSalaMensal";
            this.txtSalaMensal.Size = new System.Drawing.Size(100, 20);
            this.txtSalaMensal.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(234, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(175, 20);
            this.txtNome.TabIndex = 7;
            // 
            // gbxHome
            // 
            this.gbxHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxHome.CausesValidation = false;
            this.gbxHome.Controls.Add(this.rbtnNão);
            this.gbxHome.Controls.Add(this.rbtnSim);
            this.gbxHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbxHome.Location = new System.Drawing.Point(446, 82);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(200, 100);
            this.gbxHome.TabIndex = 8;
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
            this.rbtnSim.Location = new System.Drawing.Point(30, 31);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(42, 17);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Instaciar Mensalista Passando Parametros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Instaciar Mensalista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSalaMensal);
            this.Controls.Add(this.txtDataEnt);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.Load += new System.EventHandler(this.frmMensalista_Load);
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtDataEnt;
        private System.Windows.Forms.TextBox txtSalaMensal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.RadioButton rbtnNão;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}