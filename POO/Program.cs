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

            CuentaAhorro cuenta = new CuentaAhorro();
            cuenta.Consignar(250);
            Console.WriteLine($"El valor de su saldo es {cuenta.ConsultarSaldo()}");
            cuenta.Retirar(50);
            Console.WriteLine($"El valor de su saldo es {cuenta.ConsultarSaldo()}");
            
            Console.ReadKey();
        }
    }
}
