using System;
using System.Collections.Generic;

class Grifo
{
    public List<Usuario> Usuarios { get; set; }

    public Grifo()
    {
        Usuarios = new List<Usuario>();
    }

    public void AgregarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
    }

    public void MostrarUsuarios()
    {
        if (Usuarios.Count == 0)
        {
            Console.WriteLine("No existen usuarios registrados.");
            return;
        }

        int numero = 1;

        foreach (Usuario usuario in Usuarios)
        {
            Console.WriteLine("\nUsuario #" + numero);
            usuario.MostrarInformacion();
            numero++;
        }
    }
}