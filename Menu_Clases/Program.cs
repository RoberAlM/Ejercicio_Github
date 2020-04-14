using System;
//Roberto Alcazar Morales
//Alejandro Conde Gómez
//El David Sánchez Ortiz
//Cecilia Lopez

//Prepara un programa que permita acceder a las siguientes funciones:
//-    Menú de opciones:
//-    Añadir un dato
//-    Mostrar todos los datos
//-    Mostrar datos a partir de un determinado dato de tamaño
//-    Búsqueda parcial a partir de una letra o subconjunto de letras(en el caso de encontrar ese fichero deberá mostrar todos los datos que le pertenecen)
//-    Mensaje de error, dato introducido incorrecto
//-    Salir del menú
namespace Menu_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos.peliculas[] d = new Metodos.peliculas[4];
            int cantidad = 0;
            Metodos m = new Metodos();
            Console.WriteLine("#### Menú ####");
            Console.WriteLine("[1] Añadir un dato");
            Console.WriteLine("[2] Mostrar todos los datos");
            Console.WriteLine("[3] Mostrar datos a partir de un determinado dato de tamaño");
            Console.WriteLine("[4]  Búsqueda parcial a partir de una letra o subconjunto de letras");
            Console.WriteLine("[5] Salir");
            int respuesta = Convert.ToInt32(Console.ReadLine());
            if (respuesta == 1)
            {
                m.AnadirDatos(d ,ref cantidad);
                
            }
            else if (respuesta == 2)
            {
                m.MostrarDatos(d, cantidad);
            }
            else if (respuesta == 3)
            {
                m.BuscarPorTamaño(d, cantidad);
            }
            else if (respuesta == 4)
            {
                m.BuscarApartirDeLetra(d, cantidad);
            }
            else if (respuesta == 5)
            {
                Console.WriteLine("Saliendo...");
         
            }
            else
            {
                Console.WriteLine("Respuesta no valida");
            }






            Console.ReadLine();
        }
    }
}
