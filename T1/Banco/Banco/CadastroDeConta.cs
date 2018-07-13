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

        private Form1 aplicacaoPincipal;
        public CadastroDeConta() {
            InitializeComponent();
        }

        private void botaoCadastrar_Click(object sender, EventArgs e) {
            Cliente cliente = new Cliente(titularConta.Text);

            Conta novaConta = new ContaCorrente();
            novaConta.Titular = cliente;
            novaConta.Numero = Convert.ToInt32(numeroDaConta.Text);
        }
    }
}
