using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplos3ou4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string tres = "Divisiveis por 3: ";
            string quatro = "Divisiveis por 4: ";
            for (int i = 0; i < 30; i++) {
                if(i % 3 == 0) {
                    tres += i + ",";
                }if(i % 4 == 0) {
                    quatro += i + ",";
                }
            }
            MessageBox.Show(tres);
            MessageBox.Show(quatro);
        }
    }
}
