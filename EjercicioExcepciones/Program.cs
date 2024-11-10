class Program
{
    static void Main(string[] args)
    {
        Operaciones operaciones = new Operaciones();
        int opcion=0;

        do
        {
            try
            {
                Console.WriteLine("\n=== Menú de Operaciones ===");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.Write("\nSeleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    throw new FormatException("Por favor, ingrese un número válido."); //excepcion aplicada
                }

                if (opcion != 5)
                {
                    Console.Write("Ingrese el primer número: ");
                    if (!double.TryParse(Console.ReadLine(), out double num1))
                    {
                        throw new FormatException("Por favor, ingrese un número válido.");//excepcion aplicada
                    }

                    Console.Write("Ingrese el segundo número: ");
                    if (!double.TryParse(Console.ReadLine(), out double num2))
                    {
                        throw new FormatException("Por favor, ingrese un número válido.");//excepcion aplicada
                    }

                    double resultado = 0;

                    switch (opcion)
                    {
                        case 1:
                            resultado = operaciones.Sumar(num1, num2);
                            Console.WriteLine($"Resultado: {resultado}");
                            break;
                        case 2:
                            resultado = operaciones.Restar(num1, num2);
                            Console.WriteLine($"Resultado: {resultado}");
                            break;
                        case 3:
                            resultado = operaciones.Multiplicar(num1, num2);
                            Console.WriteLine($"Resultado: {resultado}");
                            break;
                        case 4:
                            resultado = operaciones.Dividir(num1, num2);
                            Console.WriteLine($"Resultado: {resultado}");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            }
            catch (FormatException ex) //excepcion aplicada
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex) //excepcion aplicada
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }

        } while (opcion != 5);

        Console.WriteLine("¡Gracias por usar el programa, hasta luego amigo(a)!");
    }
}
