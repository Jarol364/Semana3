using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                // Muestra el menú de opciones al usuario.
                MostrarMenu();
                opcion = Console.ReadLine().Trim().ToLower(); //aca esta a lo que me refiero abajo 

                // Procesa la opción seleccionada por el usuario.
                ProcesarOpcion(opcion);
            } while (opcion != "salir");
        }

        // Muestra el menú de opciones al usuario.
        static void MostrarMenu()
        {
            Console.WriteLine("Opciones disponibles:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. División");
            Console.WriteLine("4. Potencia");
            Console.WriteLine("5. Área del triángulo");
            Console.WriteLine("6. Área del cuadrado");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");
        }

        // Procesa la opción seleccionada por el usuario.
        static void ProcesarOpcion(string opcion)
        {
            switch (opcion)
            {
                case "sumar":
                    RealizarOperacion("sumar");
                    break;
                case "restar":
                    RealizarOperacion("restar");
                    break;
                case "division":
                    RealizarOperacion("dividir");
                    break;
                case "potencia":
                    CalcularPotencia();                 //aca profe la verdad no sabia como hacerlo ya que al digitar la variacion con tilde no lo tomaba como igual entonces busque
                                                        //en internet y encontre que se podia hacer con el metodo trim() y tolower() para que no importe si el usuario digita con tilde o sin tilde
                                                        //y ahi le agregue las variables que el usuario podria digitar ya que lo que pidio fue que en vez de digitar el numero de la opcion
                                                        //se digite la palabra que esta en el menu
                    break;
                case "area del triangulo":
                case "área del triángulo":
                case "área triángulo":
                    CalcularAreaTriangulo();
                    break;
                case "area del cuadrado":
                case "área del cuadrado":
                case "área cuadrado":
                    CalcularAreaCuadrado();
                    break;
                case "salir":
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        // Se realizan las operaciones de suma, resta y división.
        static void RealizarOperacion(string operacion)
        {
            try
            {
                Console.Write("Ingrese el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;
                switch (operacion)
                {
                    case "sumar":
                        resultado = num1 + num2;
                        break;
                    case "restar":
                        resultado = num1 - num2;
                        break;
                    case "dividir":
                        if (num2 != 0)
                            resultado = num1 / num2;
                        else
                            throw new DivideByZeroException();
                        break;
                }

                Console.WriteLine($"El resultado de {operacion} es: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no válida. Por favor, ingrese números válidos.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: División por cero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Se calcula la potencia de un número.
        static void CalcularPotencia()
        {
            try
            {
                Console.Write("Ingrese la base: ");
                double baseNum = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el exponente: ");
                double exponente = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"La potencia es: {Math.Pow(baseNum, exponente)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no válida. Por favor, ingrese números válidos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Se calculaa el área de un triángulo.
        static void CalcularAreaTriangulo()
        {
            try
            {
                Console.Write("Ingrese la base del triángulo: ");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese la altura del triángulo: ");
                double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"El área del triángulo es: {baseTriangulo * alturaTriangulo / 2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no válida. Por favor, ingrese números válidos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Se calcula el área de un cuadrado.
        static void CalcularAreaCuadrado()
        {
            try
            {
                Console.Write("Ingrese el lado del cuadrado: ");
                double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"El área del cuadrado es: {ladoCuadrado * ladoCuadrado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no válida. Por favor, ingrese números válidos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}