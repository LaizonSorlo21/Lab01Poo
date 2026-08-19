using System;

class Program
{
    static void Main(string[] args)
    {
        Grifo grifo = new Grifo();

        int opcion = 0;

        do
        {
            Console.WriteLine("\n===== GRIFO =====");
            Console.WriteLine("1. Mostrar información de usuarios");
            Console.WriteLine("2. Agregar cliente");
            Console.WriteLine("3. Agregar empleado");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcion) || opcion < 1 || opcion > 4)
            {
                Console.WriteLine("Entrada inválida. Solo ingrese un número del 1 al 4.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    grifo.MostrarUsuarios();
                    break;

                case 2:
                    Console.Write("\nNombre: ");
                    string nombreCliente = Console.ReadLine();

                    Console.Write("Saldo: ");
                    double saldoCliente = double.Parse(Console.ReadLine());

                    Console.Write("Litros cargados: ");
                    double litros = double.Parse(Console.ReadLine());

                    Cliente cliente = new Cliente(
                        nombreCliente,
                        saldoCliente,
                        litros
                    );

                    grifo.AgregarUsuario(cliente);

                    Console.WriteLine("Cliente agregado.");
                    break;

                case 3:
                    Console.Write("\nNombre: ");
                    string nombreEmpleado = Console.ReadLine();

                    Console.Write("Saldo: ");
                    double saldoEmpleado = double.Parse(Console.ReadLine());

                    Console.Write("Sueldo: ");
                    double sueldo = double.Parse(Console.ReadLine());

                    Empleado empleado = new Empleado(
                        nombreEmpleado,
                        saldoEmpleado,
                        sueldo
                    );

                    grifo.AgregarUsuario(empleado);

                    Console.WriteLine("Empleado agregado.");
                    break;

                case 4:
                    Console.WriteLine("Programa finalizado.");
                    break;
            }

        } while (opcion != 4);
    }
}