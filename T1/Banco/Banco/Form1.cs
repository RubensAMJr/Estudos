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
        public Form1() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            Cliente clt = new Cliente("Victor",20,"11609384","675638","idk");

            Conta cnt = new Conta(250.0,clt,1);

            txtSaldo.Text = Convert.ToString(cnt.saldo);
            txtTitular.Text = cnt.titular.nome;
            txtNumero.Text = Convert.ToString(cnt.numero);




        }

        private void btnDeposita_Click(object sender, EventArgs e) {
            double valor = (Convert.ToDouble(txtSaldo.Text)+Convert.ToDouble(txtValor.Text));
            txtSaldo.Text = Convert.ToString(valor);
        }

        private void button1_Click(object sender, EventArgs e) {
            double valor = (Convert.ToDouble(txtSaldo.Text) - Convert.ToDouble(txtSaque.Text));
            txtSaldo.Text = Convert.ToString(valor);

        }
    }
}
