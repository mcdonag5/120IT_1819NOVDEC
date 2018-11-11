using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CodePortfolioStreamWriterReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lbRetrieved.Text = "";
        }

        private void btStore_Click(object sender, EventArgs e) {
            using (StreamWriter sw = new StreamWriter("StoredText.txt")) {
                sw.WriteLine(tbTest.Text);
            }
            tbTest.Clear();
        }

        private void btRetrieve_Click(object sender, EventArgs e) {
            using (StreamReader sr = new StreamReader("StoredText.txt")) {
                lbRetrieved.Text = sr.ReadLine();
            }
        }
    }
}
