using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_POO_ElSoldado
{
    internal class Soldado
    {
        private Arma arma;

        internal Arma Arma { get => arma; }

        public void RecogerArma(Arma arma)
        {
          
            this.arma = arma;
            Console.WriteLine("El arma fue recogida exitosamente");
        }
        public void TirarArma()
        {

            this.arma = null;
            Console.WriteLine("El arma se descartó correctamente");
        }

        public void DispararArma()
        {
            this.arma.Disparar();
        }

        public void VerArma()
        {
            // le quitamos estos caracteres al valor devuleto por la funcion gettype "_22_POO_ElSoldado."
            
            Console.WriteLine($"Arma en uso: {this.arma.GetType().ToString().Remove(0,18)}");
        }



    }
}
