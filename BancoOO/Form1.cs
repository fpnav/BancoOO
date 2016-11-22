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
        public List<Cliente> Clientes { get; set; }

        public Form1()
        {
            InitializeComponent();
            label3.Text = "0.00";
        }

        public Form1(List<Cliente> clientes)
        {
            InitializeComponent();
            Clientes = clientes;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.Deposito(Convert.ToDouble(textBox1.Text));
            label3.Text = c.Saldo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Clientes != null)
            {
                FrmCliente formCliente1 = new FrmCliente(Clientes);
                formCliente1.Show();
            }
            else
            {
                FrmCliente formCliente = new FrmCliente();
                formCliente.Show();
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmConta formConta = new FrmConta(Clientes);
            formConta.Show();
        }
    }
}
