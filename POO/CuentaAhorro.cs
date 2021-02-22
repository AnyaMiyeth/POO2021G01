using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(decimal valor)
        {
            saldo = valor;
        }

        private decimal saldo;
        public override string Consignar(decimal valor)
        {
            if (valor>0)
            {
                saldo += valor;
                return $"Valor Consignado {valor} su saldo es {saldo}";
            }
            return $"Valor No Consignado, debe ser superiro a $0";
        }

        public override string Retirar(decimal valor)
        {
            if (valor<=saldo)
            {
                saldo -= valor;
                return $"Valor Retirado {valor} su saldo es {saldo}";
            }
            return "Saldos Insuficientes";
        }

        public string ConsultarSaldo()
        {
            return $"Su saldo es {saldo}";
        }
    }
}
