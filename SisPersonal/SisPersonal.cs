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
}