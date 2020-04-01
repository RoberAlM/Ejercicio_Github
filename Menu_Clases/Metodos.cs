﻿using System;
using System.Collections.Generic;
using System.Text;

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

            Console.Write("Busqueda: ");
            string datoBusqueda = Console.ReadLine();
            for (int i = 0; i < cantidad; i++)
            {
                if (p[i].nombre.IndexOf(datoBusqueda, 1, datoBusqueda.Length) >= 0)
                {
                    Console.WriteLine("Nombre: {0}", p[i].nombre);
                    Console.WriteLine("Genero: {0}", p[i].genero);
                    Console.WriteLine("Duracion: {0}", p[i].duracion);
                    Console.WriteLine("Tamaño: {0}", p[i].size);
                }
            }
        }


        public void BuscarPorTamaño(peliculas[] p, int cantidad)
        {
            int tamaño;
            Console.Write("Introduce tamaño para buscar ficheros por ese tamaño: ");
            tamaño = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                if (p[i].size == tamaño)
                {
                    Console.WriteLine("Nombre: {0}", p[i].nombre);
                    Console.WriteLine("Genero: {0}", p[i].genero);
                    Console.WriteLine("Duracion: {0}", p[i].duracion);
                    Console.WriteLine("Tamaño: {0}", p[i].size);
                }
            }
        }

        public void AnadirDatos(peliculas[] p, ref int cantidad)
        {
            Console.WriteLine("Escribe el nombre");
            p[cantidad].nombre = Console.ReadLine();
            Console.WriteLine("Escribe el tamaño");
            p[cantidad].size = Convert.ToInt32(Console.ReadLine());
            cantidad++;
        }
        public void MostrarDatos(peliculas[] p, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Nombre: {0}, tamaño: {1}", p[i].nombre, p[i].size);
            }

        }



    }
}
