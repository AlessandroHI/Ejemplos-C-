using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
   class Program
    {
        public static string [,] clientes; // Matriz clientes global
        public static int filas = 0;
        
        static void Main(string[] args)
        {
            string opcion = "";
            
            do
            {
             Console.WriteLine("-----------------------------");
             Console.WriteLine("  Pizzeria El Gatini gordini ");
             Console.WriteLine("-----------------------------\n");
             Console.WriteLine(" 1. Atender clientes");
             Console.WriteLine(" 2. Consultar datos");
             Console.WriteLine(" 3. Salir\n");
             Console.WriteLine(" Elija una opcion: ");
             opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Cantidad de clientes a atender: ");
                        string conCLientes = Console.ReadLine();
                        filas = Int32.Parse(conCLientes);
                        clientes = new string[filas, 3];
                        Atender_Clientes();

                        break;
                    case "2":
                        Mostrar_informacion();
                        break;

                    case "3":
                        Console.WriteLine("Gracias por utilizar el programa...!");
                        break;

                    default:
                        Console.WriteLine("Opcion ingresa no valida, vuelva a intentarlo...\n");
                        break;
                }

            } while (opcion !="3");
            Console.Read();
        }

        public static void Atender_Clientes() {
           
            int contClientes = 0; //contador de clientes atendidos
            int contNo = filas; //contador de clientes no atendidos

            for (int i = 0; i < filas; i++)
            {
                string nombre = "";
                string info = "";
                Console.WriteLine(" \n-----------------------------------");
                Console.WriteLine(" Clientes atendidos: {0} ", contClientes, "\n");
                Console.WriteLine(" Clientes por atender: {0} ", contNo, "\n");
                for (int j = 0; j< 3; j++)
                {
                    
                   
                    if (j == 0)
                    {
                        Console.WriteLine(" \nIngresar el nombre del cliente: ");
                        nombre = Console.ReadLine();
                        clientes[i,j] = nombre;
                    }
                    if(j == 1)
                    {
                        clientes[i, j] = "Atendido";
                    }
                    if (j == 2)
                    {
                        Console.WriteLine(" \nNo. pizzas a ordenar: ");
                        string num = Console.ReadLine();
                        info = informacion(num);
                        clientes[i, j] = info;

                    }
                   

                }

                contClientes++;
                contNo--;
                Console.WriteLine(" \nCliente atendido...\n");
                Console.WriteLine(" \nDesea ver la informacion del orden: ");
                Console.WriteLine(" 1. SI");
                Console.WriteLine(" 2. NO");
                string desicion = Console.ReadLine();
                if (desicion == "1")
                {
                    Console.WriteLine("\n------------ ORDEN ----------------");
                    Console.WriteLine(" -- Cliente: {0}", nombre);
                    Console.WriteLine(" -- Atendido");
                    Console.WriteLine(" -- Detalles : \n {0}", info);
                }
            }

            

        }


        public static void Mostrar_informacion()
        {
            Console.WriteLine("\n------------ ORDENES----------------");
            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine("---- ORDEN: "+(i+1));
                for (int j = 0; j < 3; j++)
                {
                    if(j == 0)
                    {
                        Console.WriteLine(" -- Cliente: {0}", clientes[i, j]);
                    }
                    if (j == 1)
                    {
                        Console.WriteLine(" -- {0}", clientes[i, j]);
                    }
                    if (j == 2)
                    {
                        Console.WriteLine(" --- Detalles : \n  {0}", clientes[i, j]);
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static string informacion(string num)
        {
            int veces  = Int32.Parse(num);
            string info = "";
            int total = 0;
            int contPizzas = 1;
            string caracteristicas = "";


            for (int i = 0; i < veces; i++)
            {
                
                string pizza = contPizzas.ToString();
                Console.WriteLine(" \nPara la Pizza No. {0} que tipo de pizza desea: ", pizza);
                Console.WriteLine(" 1. Pizza cuatro quesos Q30.0");
                Console.WriteLine(" 2. Pizza de pepperoni  Q.30.0");
                Console.WriteLine(" 3. Pizza cuatro estaciones Q.40.0 ");
                Console.WriteLine(" 4. Pizza hawaiana Q.35.0 ");
                string opcionpizza = Console.ReadLine();
                if(opcionpizza == "1")
                {
                    total += 30;
                    caracteristicas += "\nPizza cuatro quesos";
                }
                if (opcionpizza == "2")
                {
                    total += 30;
                    caracteristicas += "\nPizza de pepperoni";
                }
                if (opcionpizza == "3")
                {
                    total += 40;
                    caracteristicas += "\nPizza cuatro estaciones";
                }
                if (opcionpizza == "4")
                {
                    total += 35;
                    caracteristicas += "\nPizza hawaiana";
                }


                Console.WriteLine(" \nPara la Pizza No. {0} que tamaño desea: ", pizza);
                Console.WriteLine(" 1. Personal Q25.0");
                Console.WriteLine(" 2. Mediana  Q.30.0");
                Console.WriteLine(" 3. Grande Q.35.0 ");
                string tamano = Console.ReadLine();
                if (tamano == "1")
                {
                    total += 25;
                    caracteristicas += " tamaño pesonal";
                }
                if (tamano == "2")
                {
                    total += 30;
                    caracteristicas += " tamaño mediana";
                }
                if (tamano == "3")
                {
                    total += 35;
                    caracteristicas += " tamaño grande";
                }

                Console.WriteLine(" \nPara la Pizza No. {0} tipo de masa desea: ", pizza);
                Console.WriteLine(" 1. tradicional Q15.0");
                Console.WriteLine(" 2. delgada  Q.10.0");
                string masa = Console.ReadLine();
                if (tamano == "1")
                {
                    total += 15;
                    caracteristicas += " tipo de masa tradicional";
                }
                if (tamano == "2")
                {
                    total += 10;
                    caracteristicas += " tipo de masa delgada";
                }

                Console.WriteLine(" \nPara la Pizza No. {0} desea ingredientes extras: ", pizza);
                Console.WriteLine(" 1. Si ");
                Console.WriteLine(" 2. No ");
                string ingre = Console.ReadLine();
                if (ingre == "1")
                {
                    caracteristicas += "\nIngredientes extras: ";
                    Console.WriteLine(" \nPara la Pizza No. {0} cuantos ingredientes desea: ", pizza);
                    string noingre = Console.ReadLine();
                    int vecesingre = Int32.Parse(noingre);

                    for(int j = 0; j < vecesingre; j++)
                    {
                        Console.WriteLine("\nIngrese el Ingrediente " + (j+1));
                        Console.WriteLine(" 1. Tocino Q10.0");
                        Console.WriteLine(" 2. Bacon  Q.10.0");
                        Console.WriteLine(" 3. Champiñones Q.5.0");
                        Console.WriteLine(" 4. Pimientos Q.5.0");
                        string ingrediente = Console.ReadLine();
                        if(ingrediente == "1")
                        {
                            total += 10;
                            caracteristicas += " Tocino ";
                        }
                        if (ingrediente == "2")
                        {
                            total += 10;
                            caracteristicas += " Bacon ";
                        }
                        if (ingrediente == "3")
                        {
                            total += 5;
                            caracteristicas += " Champiñones ";
                        }
                        if (ingrediente == "4")
                        {
                            total += 5;
                            caracteristicas += " Pimientos ";
                        }


                    }
                }
                
                contPizzas++;

            }

            string total1 = total.ToString();
            info += " Importe  a pagar: Q."+total1;
            info += caracteristicas;
        
            return info;
        } 
    }
}
