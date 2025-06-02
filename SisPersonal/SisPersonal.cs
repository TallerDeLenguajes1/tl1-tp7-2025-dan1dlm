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