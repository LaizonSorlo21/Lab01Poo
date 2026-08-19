using System;

class Cliente : Usuario
{
    public double LitrosCargados { get; set; }

    public Cliente(string nombre, double saldo, double litrosCargados)
        : base(nombre, saldo)
    {
        LitrosCargados = litrosCargados;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Tipo: Cliente");
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Saldo: S/ " + Saldo);
        Console.WriteLine("Litros cargados: " + LitrosCargados);
    }
}