using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabela {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            String tabela = "";
            for (int i = 1; i <= 5; i++) {
                for (int j = 1; j <= i; j++) {
                    tabela += i * j + " "; 
                }
                tabela += "\n";
            }
            MessageBox.Show(tabela);
        }
    }
}
