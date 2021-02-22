using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Cuenta
    {
         
        public string Numero { get; set; }

        public abstract void Retirar(decimal valor);


        public abstract void Consignar(decimal valor);
        

       
    }
}
