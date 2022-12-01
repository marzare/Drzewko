using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizacja
{
    public partial class Form2 : Form
    {
        public string nazwa = "";
        public Form2()
        {
            InitializeComponent();
        }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            nazwa = textBox1.Text;
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = nazwa;
        }
    }
}
