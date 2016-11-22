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
    public partial class FrmCliente : Form
    {
        public List<Cliente> Clientes { get; set; }

        public FrmCliente()
        {
            InitializeComponent();

            if (Clientes == null )
            {
                Clientes = new List<Cliente>();    
            }

            
        }

        public FrmCliente(List<Cliente> clientes)
        {
            InitializeComponent();
            Clientes = clientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Nome = textBox1.Text;
            c.Endereco = textBox2.Text;
            c.Email = textBox3.Text;
            Clientes.Add(c);
            this.Close();
            Form1 form1 = new Form1(Clientes);
            form1.Show();
        }
    }
}
