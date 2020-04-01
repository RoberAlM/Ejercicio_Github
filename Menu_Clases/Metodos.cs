using System;
using System.Collections.Generic;
using System.Text;

namespace Menu_Clases
{
    class Metodos
    {
        public struct dato
        {
            public string nombre;
            public int size;
        }        

        public void BuscarApartirDeLetra(dato[] d, int cantidad)
        {

            Console.Write("Busqueda: ");
            string datoBusqueda = Console.ReadLine();
            for (int i = 0; i < cantidad; i++)
            {
                if (d[i].nombre.IndexOf(datoBusqueda, 1, datoBusqueda.Length) >= 0)
                {
                    Console.WriteLine("Nombre: {0}", d[i].nombre);
                    Console.WriteLine("Tamaño: {0}", d[i].size);
                }
            }
        }
    }
}
