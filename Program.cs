using System;

namespace FundamentosCSHARP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Tipos de datos
            //byte numero = 255;
            //sbyte numero = 127;
            //int numero = -128;
            //uint numero = 128;
            //long numero = -128;
            //ulong numero = 128;
            //float numero = 1289.1f;
            //double numero = 1289.1d;
            //decimal numero = 189.1m;
            //bool numero = true;
            //char caracter = 'A';
            //string caracter = "Hola mundo";
            //int numero = new int();
            //int? numero = null;
            //Console.WriteLine(numero.ToString());

            //var nombre = "Ana";
            //Console.WriteLine(nombre);

            var persona = new { nombre = "Ana", apellido = "Muedas" };
            Console.WriteLine(persona.nombre);
        }
    }
}
