using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoOO
{
    public class ContaPoupanca : Conta
    {
        public double Taxa { get; set; } 

        public ContaPoupanca()
        {
            Taxa = 0.10;
        }
        
        public override double Saque(double valor)
        {
            return Saldo -= valor + Taxa;
        }
    }
}
