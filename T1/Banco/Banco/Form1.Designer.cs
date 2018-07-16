namespace Banco {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnDeposita = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.valorTransfere = new System.Windows.Forms.TextBox();
            this.btnTransfere = new System.Windows.Forms.Button();
            this.comboTransfere = new System.Windows.Forms.ComboBox();
            this.cadastroConta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(73, 32);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 0;
            this.txtTitular.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(73, 58);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(73, 84);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(3, 43);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            // 
            // btnDeposita
            // 
            this.btnDeposita.Location = new System.Drawing.Point(109, 44);
            this.btnDeposita.Name = "btnDeposita";
            this.btnDeposita.Size = new System.Drawing.Size(75, 23);
            this.btnDeposita.TabIndex = 4;
            this.btnDeposita.Text = "Deposita";
            this.btnDeposita.UseVisualStyleBackColor = true;
            this.btnDeposita.Click += new System.EventHandler(this.btnDeposita_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Saque";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSaque
            // 
            this.txtSaque.Location = new System.Drawing.Point(3, 17);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(100, 20);
            this.txtSaque.TabIndex = 6;
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(73, 1);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 7;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(12, 35);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 8;
            this.Nome.Text = "Nome:";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Conta:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.valorTransfere);
            this.panel1.Controls.Add(this.btnTransfere);
            this.panel1.Controls.Add(this.comboTransfere);
            this.panel1.Controls.Add(this.txtSaque);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.btnDeposita);
            this.panel1.Location = new System.Drawing.Point(15, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 143);
            this.panel1.TabIndex = 12;
            // 
            // valorTransfere
            // 
            this.valorTransfere.Location = new System.Drawing.Point(3, 103);
            this.valorTransfere.Name = "valorTransfere";
            this.valorTransfere.Size = new System.Drawing.Size(121, 20);
            this.valorTransfere.TabIndex = 15;
            // 
            // btnTransfere
            // 
            this.btnTransfere.Location = new System.Drawing.Point(139, 103);
            this.btnTransfere.Name = "btnTransfere";
            this.btnTransfere.Size = new System.Drawing.Size(81, 23);
            this.btnTransfere.TabIndex = 14;
            this.btnTransfere.Text = "Transferir";
            this.btnTransfere.UseVisualStyleBackColor = true;
            this.btnTransfere.Click += new System.EventHandler(this.btnTransfere_Click);
            // 
            // comboTransfere
            // 
            this.comboTransfere.FormattingEnabled = true;
            this.comboTransfere.Location = new System.Drawing.Point(3, 69);
            this.comboTransfere.Name = "comboTransfere";
            this.comboTransfere.Size = new System.Drawing.Size(121, 21);
            this.comboTransfere.TabIndex = 13;
            // 
            // cadastroConta
            // 
            this.cadastroConta.Location = new System.Drawing.Point(12, 110);
            this.cadastroConta.Name = "cadastroConta";
            this.cadastroConta.Size = new System.Drawing.Size(105, 23);
            this.cadastroConta.TabIndex = 13;
            this.cadastroConta.Text = "CadastrarConta";
            this.cadastroConta.UseVisualStyleBackColor = true;
            this.cadastroConta.Click += new System.EventHandler(this.cadastroConta_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 300);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cadastroConta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtTitular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnDeposita;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboTransfere;
        private System.Windows.Forms.Button btnTransfere;
        private System.Windows.Forms.TextBox valorTransfere;
        private System.Windows.Forms.Button cadastroConta;
        private System.Windows.Forms.Button button2;
    }
}

