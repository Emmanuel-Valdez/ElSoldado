using System.Runtime.CompilerServices;

namespace _22_POO_ElSoldado
{
    public class Utiles
    {
        Soldado s1 = new Soldado();
        Escopeta escopeta = new Escopeta();
        Revolver revolver = new Revolver();
        Rifle rifle = new Rifle();
        public  void Menu()
        {
            
            int opcion = 0;
            do
            {
                Console.WriteLine($@"
                -== Bienvenido al campo de entrenamiento, Soldado ==-
                ¿Qué desea hacer?
                (presione el número correspondiente a la opción del menú)
                1- Recoger arma.
                2- Dejar arma.
                3- Disparar.
                4- Ver arma en uso.
                5- Salir.");

                try
                {
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            if (s1.Arma==null)
                            {
                                Menu2();
                            }
                            else
                            {
                                Console.WriteLine("Parece que el soldado ya está equipado con otra arma.");
                            }
                            

                            break;
                        case 2:
                            if (s1.Arma != null)
                            {
                                s1.TirarArma();
                              

                            }
                            else
                            {
                                Console.WriteLine("El soldado no tiene armas para tirar");
                              
                            }
                            break;
                        case 3:
                            if (s1.Arma != null)
                            {
                                s1.DispararArma();
                             
                            }
                            else
                            {
                                Console.WriteLine("Parece que el soldado no tiene ningún arma en sus manos...");
                                
                            }
                            break;
                        case 4:
                            if (s1.Arma != null)
                            {
                                s1.VerArma();
                           
                            }
                            else
                            {
                                Console.WriteLine("Parece que el soldado no tiene ningún arma en sus manos...");
                               
                            }
                            break;
                        case 5:
                            Console.WriteLine("Game Over");
                            break;


                        default:
                            Console.WriteLine("Debe ingresar una opcion del 1 al 5");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ingresar solo un numero del 1 al 5 inclusive");
                   
                }
                Esperar();
                Console.Clear();
                

            } while (opcion!=5);

        }
        private static void Esperar()
        {
            Console.WriteLine("Oprima cualquier tecla para continuar");
            Console.ReadKey();
        }
        private  void Menu2()
        {
            int opcion2 = 0;
            do
            {
                
                    
                    Console.WriteLine($@"
                        Por favor, escoja el arma que desea utilizar:
                        1- Revolver
                        2- Rifle
                        3- Escopeta
                        4- Volver atrás");
                try
                {
                    opcion2 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ingresar solo un numero del 1 al 4 inclusive");
                   
                }
                switch (opcion2)
                    {
                        case 1:
                            s1.RecogerArma(revolver);
                            opcion2 = 4;
                            break;
                        case 2:
                            s1.RecogerArma(rifle);
                            opcion2 = 4;
                            break;
                        case 3: 
                            s1.RecogerArma(escopeta);
                            opcion2 = 4;
                            break;
                        case 4:

                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta. Debe ingresar un numero del 1 al 4");
                            break;
                    }
                

            } while (opcion2 != 4); ;
           
            
        }
    }
    
}

