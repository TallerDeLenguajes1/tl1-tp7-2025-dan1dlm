// See https://aka.ms/new-console-template for more information
namespace EspacioCalculadora;

using EspacioCalculadora;

public class Calculadora
{
    private double dato;

    public Calculadora()
    {
        dato = 0;
    }

    public void Sumar(double termino)
    {
        dato += termino;
    }

    public void Restar(double termino)
    {
        dato -= termino;
    }

    public void Multiplicar(double termino)
    {
        dato *= termino;
    }

    public void Dividir(double termino)
    {
        if (termino != 0)
            dato /= termino;
        else
            Console.WriteLine("Error: División por cero no permitida.");
    }

    public void Limpiar()
    {
        dato = 0;
    }
    public double Resultado
    {
        get { return dato; }
    }
}


class Program
{
    static void Main(string[] args)
    {
        interfaz();
    }

    static void interfaz()
    {


        Calculadora calculadora = new Calculadora();
        string opcion;
        do
        {
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Limpiar");
            Console.WriteLine("6. Mostrar resultado");
            Console.WriteLine("0. Salir");
            opcion = Console.ReadLine();

            if (opcion == "0") break;

            if (opcion == "5")
            {
                calculadora.Limpiar();
                Console.WriteLine("Resultado limpiada.");
                continue;
            }

            if (opcion == "6")
            {
                Console.WriteLine($"Resultado actual: {calculadora.Resultado}");
                continue;
            }

            Console.Write("Ingrese un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            switch (opcion)
            {
                case "1":
                    calculadora.Sumar(numero);
                    break;
                case "2":
                    calculadora.Restar(numero);
                    break;
                case "3":
                    calculadora.Multiplicar(numero);
                    break;
                case "4":
                    calculadora.Dividir(numero);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (true);

        Console.WriteLine("Calculadora cerrada.");

    }
}

