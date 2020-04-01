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
        public void AnadirDatos(dato[]d,ref int cantidad)
        {
            Console.WriteLine("Escribe el nombre");
            d[cantidad].nombre = Console.ReadLine();
            Console.WriteLine("Escribe el tamaño");
            d[cantidad].size = Convert.ToInt32(Console.ReadLine());
            cantidad++;
        }
        public void MostrarDatos(dato[]d,int cantidad)
        {
            for(int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Nombre: {0}, tamaño: {1}", d[i].nombre, d[i].size);
            }
        }
    }
}
