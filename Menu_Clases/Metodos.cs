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
                string datoBusqueda = "";
            do

            {
                Console.Write("Búsqueda a partir de una letra: ");

                datoBusqueda = Console.ReadLine();

                switch (datoBusqueda)
                {
                    case "0":
                        Console.WriteLine("Error, dato introducido incorrecto. Inténtalo de nuevo.");
                        break;
                    case "1": goto case "0";
                    case "2": goto case "0";
                    case "3": goto case "0";
                    case "4": goto case "0";
                    case "5": goto case "0";
                    case "6": goto case "0";
                    case "7": goto case "0";
                    case "8": goto case "0";
                    case "9": goto case "0";
                    case " ": goto case "0";
                    case ".": goto case "0";
                    case ",": goto case "0";
                    case ":": goto case "0";
                    case ";": goto case "0";
                }

                
            }
            while (datoBusqueda != "a" && datoBusqueda != "b" && datoBusqueda != "c");
           
            
            for (int i = 0; i < cantidad; i++)
            {
                if (p[i].nombre.IndexOf(datoBusqueda, 1, datoBusqueda.Length) >= 0)
                {
                    Console.WriteLine("Nombre: {0}", p[i].nombre);
                    Console.WriteLine("Género: {0}", p[i].genero);
                    Console.WriteLine("Duración: {0}", p[i].duracion);
                    Console.WriteLine("Tamaño: {0}", p[i].size);
                }
            }
        }
        public void BuscarPorTamaño(peliculas[] p, int cantidad)
        {
            int tamaño= 0;
            Console.Write("Introduce tamaño para buscar ficheros por ese tamaño: ");
            try
            { tamaño = int.Parse(Console.ReadLine()); }
            catch (FormatException)
            {
                Console.WriteLine("Error, el dato introducido no es correcto. Inténtalo de nuevo.");
            }

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
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Nombre: {0}, género: {1}, duracion: {2}, tamaño: {3}", p[i].nombre,p[i].genero,p[i].duracion,p[i].size);
            }
        }
        public void Salir()
        {
            Environment.Exit(0);
        }
    }
}