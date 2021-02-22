using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(decimal cupoInicial)
        {
            cupo = cupoInicial;
            disponibilidad = cupo;
            saldo = 0;
        }
        
        private decimal cupo;
        private decimal disponibilidad;
        private decimal saldo;
        public override string Consignar(decimal valor)
        {
            if (valor<=saldo)
            {
                saldo -= valor;
                return $"Se ha realizado la Consignación su saldo con el Banco ahora es {saldo}";
            }
            return "Solo se permiten consignaciones para reponer el saldo utilizado de la cuenta verifique su saldo con el Banco";
        }

        public override string Retirar(decimal valor)
        {
            if (valor <= disponibilidad)
            {
                saldo += valor;
                disponibilidad -= valor;
                return $"Se ha realizado el retiro de {valor} de su cupo, su disponibilidad es de {disponibilidad} y su saldo con el banco es de {saldo}";
            }
            return "El valor a retirar supera su cupo disponible";
        }

        public string ConsultarSaldo()
        {
            return $"Su Saldo es:{saldo}";
        }

        public string ConsultarCupo()
        {
            return $"Su cupo es:{cupo}";
        }
    }
}
