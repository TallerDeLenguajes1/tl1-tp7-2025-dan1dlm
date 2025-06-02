// See https://aka.ms/new-console-template for more information
using system;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
public class Empleado
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public char EstadoCivil { get; set; }
    public DateTime FechaIngreso { get; set; }
    public double SueldoBasico { get; set; }
    public Cargos Cargo { get; set; }

    public int Antiguedad()
    {
        int antiguedad = DateTime.Now.Year - FechaIngreso.Year;
        if (DateTime.Now.Date < FechaIngreso.AddYears(antiguedad)) antiguedad--;
        return antiguedad;
    }

    public int Edad()
    {
        int edad = DateTime.Now.Year - FechaNacimiento.Year;
        if (DateTime.Now.Date < FechaNacimiento.AddYears(edad)) edad--;
        return edad;
    }

    public int AniosParaJubilarse()
    {
        int faltan = 65 - Edad();
        return faltan > 0 ? faltan : 0;
    }

    public double CalcularSalario()
    {
        double adicional = 0;
        int antiguedad = Antiguedad();

        if (antiguedad <= 20)
            adicional = SueldoBasico * 0.01 * antiguedad;
        else
            adicional = SueldoBasico * 0.25;

        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
            adicional *= 1.5;

        if (EstadoCivil == 'C' || EstadoCivil == 'c')
            adicional += 150000;

        return SueldoBasico + adicional;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Empleado[] empleados = new Empleado[3];

        empleados[0] = new Empleado
        {
            Nombre = "Juan",
            Apellido = "Pérez",
            FechaNacimiento = new DateTime(1980, 5, 10),
            EstadoCivil = 'C',
            FechaIngreso = new DateTime(2010, 3, 15),
            SueldoBasico = 650000,
            Cargo = Cargos.Ingeniero
        };

        empleados[1] = new Empleado
        {
            Nombre = "Ana",
            Apellido = "García",
            FechaNacimiento = new DateTime(1990, 8, 22),
            EstadoCivil = 'S',
            FechaIngreso = new DateTime(2015, 7, 1),
            SueldoBasico = 500000,
            Cargo = Cargos.Administrativo
        };

        empleados[2] = new Empleado
        {
            Nombre = "Luis",
            Apellido = "Martínez",
            FechaNacimiento = new DateTime(1975, 12, 3),
            EstadoCivil = 'C',
            FechaIngreso = new DateTime(2000, 1, 20),
            SueldoBasico = 800000,
            Cargo = Cargos.Investigador
        };

        
        foreach (var emp in empleados)
        {
            Console.WriteLine($"{emp.Nombre} {emp.Apellido} - Cargo: {emp.Cargo}");
        }
    }
}