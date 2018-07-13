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
        Conta[] contas;
        public Form1() {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e) {
            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            contas = new Conta[3];
            Cliente cl = new Cliente("Barbara");
            Cliente cl2 = new Cliente("Josemilton");
            Cliente cl3 = new Cliente("Emily");

            contas[0] = new Conta();
            contas[0].Titular = cl;
            contas[0].Saldo = 20000000.0;
            contas[0].Numero = 1;

            contas[1] = new Conta();
            contas[1].Titular = cl2;
            contas[1].Saldo = 20000000.0;
            contas[1].Numero = 2;

            contas[2] = new Conta();
            contas[2].Titular = cl3;
            contas[2].Saldo = 0;
            contas[2].Numero = 3;

            

            for (int i = 0; i < contas.Length; i++) {
                comboContas.Items.Add(contas[i].Titular.nome);
                comboTransfere.Items.Add(contas[i].Titular.nome);

            }









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
    }
}
