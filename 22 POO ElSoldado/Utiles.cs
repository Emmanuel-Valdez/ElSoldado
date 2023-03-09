namespace _22_POO_ElSoldado
{
    public class Utiles
    {
        Soldado soldado = new Soldado();
        Escopeta escopeta = new Escopeta();
        Revolver revolver = new Revolver();
        Rifle rifle = new Rifle();
        public void Menu()
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
                            

                            break;
                        case 2:
                            if (soldado.Arma != null)
                            {
                                soldado.TirarArma();
                                Esperar();

                            }
                            else
                            {
                                Console.WriteLine("El soldado no tiene armas para tirar");
                                Esperar();
                            }
                            break;
                        case 3:
                            if (soldado.Arma != null)
                            {
                                soldado.DispararArma();
                                Esperar();
                            }
                            else
                            {
                                Console.WriteLine("Parece que el soldado no tiene ningún arma en sus manos...");
                                Esperar();
                            }
                            break;
                        case 4:
                            if (soldado.Arma != null)
                            {
                                soldado.VerArma();
                                Esperar();
                            }
                            else
                            {
                                Console.WriteLine("Parece que el soldado no tiene ningún arma en sus manos...");
                                Esperar();
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
                
                

            } while (opcion!=5);

        }
        private static void Esperar()
        {
            Console.WriteLine("Oprima cualquier tecla para continuar");
            Console.ReadKey();
        }
        private static void Menu2()
        {
            int opcion2 = 0;
            do
            {
                try
                {
                    opcion2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($@"
                        Por favor, escoja el arma que desea utilizar:
                        1- Revolver
                        2- Rifle
                        3- Escopeta
                        4- Volver atrás");
                    switch (opcion2)
                    {
                        case 1:
                            
                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ingresar solo un numero del 1 al 4 inclusive");
                    throw;
                }
            } while (opcion2 != 4); ;
           
            
        }
    }
    
}

