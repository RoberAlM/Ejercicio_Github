using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Menu_Clases
{
    class Metodos
    {
        public struct peliculas
        {
            public string nombre;
            public string genero;
            public int duracion;    //minutos
            public int size;        //GB
        }
        public void BuscarApartirDeLetra(peliculas[] p, int cantidad)
        {
            if (cantidad > 0)

            {
                char datoBusqueda = ' ';
                bool error1 = false;
                do
                {

                    Console.Write("Búsqueda a partir de una letra: ");
                    try
                    {

                        datoBusqueda = Convert.ToChar(Console.ReadLine().ToLower());
                        error1 = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error, el dato introducido no es correcto. Por favor, introduce una letra.");
                        error1 = true;
                    }
                }
                while (error1 == true);


                for (int i = 0; i < cantidad; i++)
                {
                    if (p[i].nombre[0] == datoBusqueda)
                    {
                        Console.WriteLine("Nombre: {0}", p[i].nombre);
                        Console.WriteLine("Género: {0}", p[i].genero);
                        Console.WriteLine("Duración: {0}", p[i].duracion);
                        Console.WriteLine("Tamaño: {0}", p[i].size);
                    }
                }
            }
            else Console.WriteLine("No hay archivos guardados.");
        }
        public void BuscarPorTamaño(peliculas[] p, int cantidad)

        {
            if (cantidad > 0)
            {
                int tamaño = 0;
                bool error = false;

                do
                {
                    Console.Write("Introduce tamaño para buscar ficheros por ese tamaño: ");

                    try
                    {
                        tamaño = int.Parse(Console.ReadLine());
                        error = false;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error, el dato introducido no es correcto. Inténtalo de nuevo.");
                        error = true;
                    }

                }
                while (error == true);

                for (int i = 0; i < cantidad; i++)
                {
                    if (p[i].size == tamaño)
                    {
                        Console.WriteLine("Nombre: {0}", p[i].nombre);
                        Console.WriteLine("Género: {0}", p[i].genero);
                        Console.WriteLine("Duración: {0}", p[i].duracion);
                        Console.WriteLine("Tamaño: {0}", p[i].size);
                    }
                }
            }
            else Console.WriteLine("No hay archivos guardados.");
        }
        public void AnadirDatos(peliculas[] p, ref int cantidad)
        {
            Console.WriteLine("Escribe el nombre");
            p[cantidad].nombre = Console.ReadLine();
            Console.WriteLine("Escribe el género");
            p[cantidad].genero =Console.ReadLine();
            Console.WriteLine("Escribe la duración");
            p[cantidad].duracion =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el tamaño");
            p[cantidad].size = Convert.ToInt32(Console.ReadLine());
            cantidad++;
        }
        public void MostrarDatos(peliculas[] p, int cantidad)
            
        { if (cantidad > 0)
            {
                Console.WriteLine("No hay archivos guardados.");
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("Nombre: {0}, género: {1}, duracion: {2}, tamaño: {3}", p[i].nombre, p[i].genero, p[i].duracion, p[i].size);
                }
            }
        else Console.WriteLine("No hay archivos guardados.");
        }
        public void Salir()
        {
            Environment.Exit(0);
        }
    }
}