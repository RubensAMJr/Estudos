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
    public partial class Form1 : Form {
        List<Conta> contas;
        private int quantidadeContas;
        public Form1() {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e) {
            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            contas = new List<Conta>();

            var menor = from c in contas
                        where c.Saldo > 5000
                        select c;
            








        }

        private void btnDeposita_Click(object sender, EventArgs e) {
            double valor = (Convert.ToDouble(txtSaldo.Text)+Convert.ToDouble(txtValor.Text));
            contas[comboContas.SelectedIndex].Saldo = valor;
            txtSaldo.Text = Convert.ToString(valor);
        }

        private void button1_Click(object sender, EventArgs e) {
            double valor = (Convert.ToDouble(txtSaldo.Text) - Convert.ToDouble(txtSaque.Text));
            contas[comboContas.SelectedIndex].Saldo = valor;

            txtSaldo.Text = Convert.ToString(contas[comboContas.SelectedIndex].Saldo);

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e) {

            int indc = comboContas.SelectedIndex;
            Conta cntAtual = contas[indc];

            txtTitular.Text = cntAtual.Titular.nome;
            txtSaldo.Text = Convert.ToString(cntAtual.Saldo);
            txtNumero.Text = Convert.ToString(cntAtual.Numero);

                

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnTransfere_Click(object sender, EventArgs e) {
            contas[comboContas.SelectedIndex].transfere(Convert.ToDouble(valorTransfere.Text),contas[comboTransfere.SelectedIndex]);

            int indc = comboContas.SelectedIndex;
            Conta cntAtual = contas[indc];

            txtTitular.Text = cntAtual.Titular.nome;
            txtSaldo.Text = Convert.ToString(cntAtual.Saldo);
            txtNumero.Text = Convert.ToString(cntAtual.Numero);




        }

        public void AdicionaConta(Conta conta) {
            this.contas.Add(conta);

            

            comboContas.Items.Add(conta.Titular.nome);
            comboTransfere.Items.Add(conta.Titular.nome);
        }

        private void cadastroConta_Click(object sender, EventArgs e) {
            CadastroDeConta cadastro = new CadastroDeConta(this);
            cadastro.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e) {
            
        }
    }
}
