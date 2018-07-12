using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int n1 = 0;
            int atual = 1;
            
            string fibbo = "";
            for (int i = 1; atual < 100; i++) {
                fibbo += atual+ ",";
                int temp = atual + n1;
                n1 = atual;
                atual = temp;
                

            }
            MessageBox.Show(fibbo);
        }
    }
}
