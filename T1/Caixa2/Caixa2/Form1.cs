using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            double saldo = 100.0;
            double valor = 10.0;

            if(valor <= saldo) {
                MessageBox.Show("Saque realizado com sucesso");
            }
            else {
                MessageBox.Show("");
            }
        }
    }
}
