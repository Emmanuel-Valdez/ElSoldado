using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_POO_ElSoldado
{
    internal class Revolver: Arma
    {
        public override void Disparar()
        {
            Console.WriteLine("Púm!");
        }
    }
}
