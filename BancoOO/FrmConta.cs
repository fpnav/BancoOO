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
    public partial class FrmConta : Form
    {
        public List<Cliente> Clientes { get; set; }

        public FrmConta()
        {
            InitializeComponent();
        }

        public FrmConta(List<Cliente> clientes)
        {
            InitializeComponent();
            Clientes = clientes;
        }

        private void FrmConta_Load(object sender, EventArgs e)
        {
            //BUSCAR OS CLIENTES JÁ CRIADOS 
            comboBox1.DataSource = Clientes;
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Nome";

        }

        //Criar Conta para Novo Cliente
        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Numero = Convert.ToInt32(textBox1.Text);
            conta.Saldo = Convert.ToDouble(textBox2.Text);
            conta.Titular = comboBox1.SelectedItem as Cliente;

        }
    }
}
