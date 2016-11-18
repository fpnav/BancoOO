using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "0.00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.Deposito(Convert.ToDouble(textBox1.Text));
            label3.Text = c.Saldo.ToString();
        }
    }
}
