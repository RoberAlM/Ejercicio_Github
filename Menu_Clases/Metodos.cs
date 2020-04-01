using System;
using System.Collections.Generic;
using System.Text;
struct dato
{
    public string nombre;
    public int size;
}
class Metodos
{
    public void BuscarApartirDeLetra(int cantidad)
    {
        dato[] Dato = new dato[50];
        Console.Write("Busqueda: ");
        string datoBusqueda = Console.ReadLine();
        for (int i = 0; i < cantidad; i++)
        {
            if (Dato[i].nombre.IndexOf(datoBusqueda, 1, datoBusqueda.Length) >= 0)
            {
                Console.WriteLine("Nombre: {0}", Dato[i].nombre);
                Console.WriteLine("Tamaño: {0}", Dato[i].size);
            }
        }
    }
}

