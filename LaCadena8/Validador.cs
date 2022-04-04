using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCadena8
{
    public class Validador
    {
        public static void CompararIgualdadString(string str1, string str2)
        {
            string nuevoUno = str1.ToUpper();
            string nuevoDos = str2.ToUpper();
            
            bool comparacion = nuevoUno.Equals(nuevoDos);

            if (comparacion == true)
            {
                Console.WriteLine("\n La cadena" + " *" + str1 + "*" + " SI tiene el mismo valor que la cadena " + "*" + str2 + "*");
            }
            else
            {

                Console.WriteLine("\n La cadena" + " *" + str1 + "*" + " NO tiene el mismo valor que la cadena " + "*" + str2 + "*");
            }
        }

        public static void MostrarString(string cadena)
        {

            Console.WriteLine("\n Usted escribio " + "*" + cadena + "*");

        }


        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }

        public static string ValidarString(string mensaje)
        {

            string opcion;
            do
            {

                Console.WriteLine(mensaje);
                opcion = Console.ReadLine();
                if (string.IsNullOrEmpty(opcion))
                {
                    Console.Clear();
                    Console.WriteLine(" \nEl valor ingresado no puede ser vacio.");
                    Console.WriteLine(" Por favor ingrese un valor.");
                }
            } while (string.IsNullOrEmpty(opcion));
            return opcion;

        }
    }
}
