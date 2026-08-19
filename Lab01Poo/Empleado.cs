using System;

class Empleado : Usuario
{
    public double Sueldo { get; set; }

    public Empleado(string nombre, double saldo, double sueldo)
        : base(nombre, saldo)
    {
        Sueldo = sueldo;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Tipo: Empleado");
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Saldo: S/ " + Saldo);
        Console.WriteLine("Sueldo: S/ " + Sueldo);
    }
}