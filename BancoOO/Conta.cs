using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoOO
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }

        public virtual double Saque(double valor)
        {
            return Saldo -= valor;
        }

        public double Deposito(double valor)
        {
            return Saldo += valor;
        }
    }
}
