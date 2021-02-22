using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Uso Cuenta de Ahorro:");
            CuentaAhorro cuenta = new CuentaAhorro(2000000);
            Console.WriteLine(cuenta.Consignar(200000));
            Console.WriteLine(cuenta.Retirar(5000000000));
            Console.WriteLine(cuenta.Retirar(500000));
            Console.WriteLine(cuenta.ConsultarSaldo());

            Console.WriteLine("Uso Cuenta de Corriente");
            CuentaCorriente cuentaCorriente = new CuentaCorriente(1000000);
            Console.WriteLine(cuentaCorriente.Consignar(200000));
            Console.WriteLine(cuentaCorriente.Retirar(5000000000));
            Console.WriteLine(cuentaCorriente.Retirar(500000));
            Console.WriteLine(cuentaCorriente.Consignar(500000));
            Console.WriteLine(cuentaCorriente.ConsultarSaldo());
            Console.ReadKey();
        }
    }
}
