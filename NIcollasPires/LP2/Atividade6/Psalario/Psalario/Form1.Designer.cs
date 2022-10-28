namespace Psalario
{
    partial class mskbxDESCINSS
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
            this.nudNumFIlho = new System.Windows.Forms.NumericUpDown();
            this.bntVERIDADOS = new System.Windows.Forms.Button();
            this.lbDados = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskbxALIINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSALALIQUI = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSAlaFami = new System.Windows.Forms.MaskedTextBox();
            this.mskbxALIIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDESCIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxINSSDESC = new System.Windows.Forms.MaskedTextBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.ckbutCAsado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumFIlho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Filhos";
            // 
            // nudNumFIlho
            // 
            this.nudNumFIlho.Location = new System.Drawing.Point(140, 111);
            this.nudNumFIlho.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumFIlho.Name = "nudNumFIlho";
            this.nudNumFIlho.Size = new System.Drawing.Size(53, 20);
            this.nudNumFIlho.TabIndex = 3;
            // 
            // bntVERIDADOS
            // 
            this.bntVERIDADOS.Location = new System.Drawing.Point(31, 167);
            this.bntVERIDADOS.Name = "bntVERIDADOS";
            this.bntVERIDADOS.Size = new System.Drawing.Size(235, 23);
            this.bntVERIDADOS.TabIndex = 7;
            this.bntVERIDADOS.Text = "Verificar Desconto";
            this.bntVERIDADOS.UseVisualStyleBackColor = true;
            this.bntVERIDADOS.Click += new System.EventHandler(this.bntVERIDADOS_Click);
            // 
            // lbDados
            // 
            this.lbDados.AutoSize = true;
            this.lbDados.Location = new System.Drawing.Point(28, 223);
            this.lbDados.Name = "lbDados";
            this.lbDados.Size = new System.Drawing.Size(46, 13);
            this.lbDados.TabIndex = 9;
            this.lbDados.Text = "lbDados";
            this.lbDados.Click += new System.EventHandler(this.lbDados_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(166, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Aliquota INSS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Aliquota IRPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Salario Familia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Salario Liquido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Desconto INSS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Desconto IRPF";
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(166, 74);
            this.mskbxSalarioBruto.Mask = "9999990.00";
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(100, 20);
            this.mskbxSalarioBruto.TabIndex = 26;
            // 
            // mskbxALIINSS
            // 
            this.mskbxALIINSS.Enabled = false;
            this.mskbxALIINSS.Location = new System.Drawing.Point(140, 289);
            this.mskbxALIINSS.Name = "mskbxALIINSS";
            this.mskbxALIINSS.Size = new System.Drawing.Size(100, 20);
            this.mskbxALIINSS.TabIndex = 27;
            // 
            // mskbxSALALIQUI
            // 
            this.mskbxSALALIQUI.Enabled = false;
            this.mskbxSALALIQUI.Location = new System.Drawing.Point(140, 383);
            this.mskbxSALALIQUI.Name = "mskbxSALALIQUI";
            this.mskbxSALALIQUI.Size = new System.Drawing.Size(100, 20);
            this.mskbxSALALIQUI.TabIndex = 30;
            // 
            // mskbxSAlaFami
            // 
            this.mskbxSAlaFami.Enabled = false;
            this.mskbxSAlaFami.Location = new System.Drawing.Point(140, 351);
            this.mskbxSAlaFami.Name = "mskbxSAlaFami";
            this.mskbxSAlaFami.Size = new System.Drawing.Size(100, 20);
            this.mskbxSAlaFami.TabIndex = 31;
            // 
            // mskbxALIIRPF
            // 
            this.mskbxALIIRPF.Enabled = false;
            this.mskbxALIIRPF.Location = new System.Drawing.Point(140, 317);
            this.mskbxALIIRPF.Name = "mskbxALIIRPF";
            this.mskbxALIIRPF.Size = new System.Drawing.Size(100, 20);
            this.mskbxALIIRPF.TabIndex = 32;
            // 
            // mskbxDESCIRPF
            // 
            this.mskbxDESCIRPF.Enabled = false;
            this.mskbxDESCIRPF.Location = new System.Drawing.Point(367, 317);
            this.mskbxDESCIRPF.Name = "mskbxDESCIRPF";
            this.mskbxDESCIRPF.Size = new System.Drawing.Size(100, 20);
            this.mskbxDESCIRPF.TabIndex = 33;
            // 
            // mskbxINSSDESC
            // 
            this.mskbxINSSDESC.Enabled = false;
            this.mskbxINSSDESC.Location = new System.Drawing.Point(367, 289);
            this.mskbxINSSDESC.Name = "mskbxINSSDESC";
            this.mskbxINSSDESC.Size = new System.Drawing.Size(100, 20);
            this.mskbxINSSDESC.TabIndex = 34;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(365, 53);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 35;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(365, 94);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 36;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(380, 351);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 37;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(380, 386);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 38;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // ckbutCAsado
            // 
            this.ckbutCAsado.AutoSize = true;
            this.ckbutCAsado.Location = new System.Drawing.Point(365, 138);
            this.ckbutCAsado.Name = "ckbutCAsado";
            this.ckbutCAsado.Size = new System.Drawing.Size(62, 17);
            this.ckbutCAsado.TabIndex = 39;
            this.ckbutCAsado.Text = "Casado";
            this.ckbutCAsado.UseVisualStyleBackColor = true;
            this.ckbutCAsado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // mskbxDESCINSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 522);
            this.Controls.Add(this.ckbutCAsado);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.rbtnFeminino);
            this.Controls.Add(this.mskbxINSSDESC);
            this.Controls.Add(this.mskbxDESCIRPF);
            this.Controls.Add(this.mskbxALIIRPF);
            this.Controls.Add(this.mskbxSAlaFami);
            this.Controls.Add(this.mskbxSALALIQUI);
            this.Controls.Add(this.mskbxALIINSS);
            this.Controls.Add(this.mskbxSalarioBruto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbDados);
            this.Controls.Add(this.bntVERIDADOS);
            this.Controls.Add(this.nudNumFIlho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mskbxDESCINSS";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumFIlho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNumFIlho;
        private System.Windows.Forms.Button bntVERIDADOS;
        private System.Windows.Forms.Label lbDados;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.MaskedTextBox mskbxALIINSS;
        private System.Windows.Forms.MaskedTextBox mskbxSALALIQUI;
        private System.Windows.Forms.MaskedTextBox mskbxSAlaFami;
        private System.Windows.Forms.MaskedTextBox mskbxALIIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxDESCIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxINSSDESC;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.CheckBox ckbutCAsado;
    }
}

