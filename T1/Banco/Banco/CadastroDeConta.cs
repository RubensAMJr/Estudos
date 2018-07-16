using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco {
    public partial class CadastroDeConta : Form {


        private Form1 aplicacaoPrincipal;
        public CadastroDeConta(Form1 aplicacaoPrincipal) {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void botaoCadastrar_Click(object sender, EventArgs e) {
            Cliente cliente = new Cliente(titularConta.Text);

            if (comboTipoConta.SelectedIndex == 0) {
                Conta novaConta = new ContaCorrente();
                novaConta.Titular = cliente;
                novaConta.Numero = Convert.ToInt32(numeroDaConta.Text);
                this.aplicacaoPrincipal.AdicionaConta(novaConta);
            }
            if (comboTipoConta.SelectedIndex == 1) {
                Conta novaConta = new ContaPoupanca();
                novaConta.Titular = cliente;
                novaConta.Numero = Convert.ToInt32(numeroDaConta.Text);
                this.aplicacaoPrincipal.AdicionaConta(novaConta);
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void CadastroDeConta_Load(object sender, EventArgs e) {
            comboTipoConta.Items.Add("Conta corrente");
            comboTipoConta.Items.Add("Conta poupanca");
            
            


        }
    }
}
