using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class CuentaCorriente : Cuenta
    {
        private decimal saldo;
        private decimal Cupo;
        public override void Consignar(decimal valor)
        {
            saldo -= valor;
        }

        public override void Retirar(decimal valor)
        {
            saldo+=valor;
        }

        public decimal ConsultarSaldo()
        {
            return saldo;
        }
    }
}
