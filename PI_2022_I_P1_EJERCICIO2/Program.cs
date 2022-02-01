using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P1_EJERCICIO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nomenclatura de las variables
            //Camel Case = variables y campos privados 
            //nombre
            //nombrePersona
            //tasaInteres

            //Pascal Case = Tipos y métodos
            //Nombre
            //NombrePersona
            //TasaInteres


            //Tipos de Datos
            //Primitivos
            //int, double, string, char

            //Variables
            //tipo de dato / nombre;

            //Sin Inicializar
            //double alturaMetros;
            //Valor Iniciado
            double alturaMetros = 1.80;
            //Console.WriteLine(alturaMetros);
            Console.WriteLine($"La Variable {nameof(alturaMetros)} tiene un valor de {alturaMetros}.");
            

            //char
            char letra  = 'A';
            char numero = '1';
            char simbolo = '$';

            //cadena de texto
            string primerNombre   = "Kevin";
            string primerApellido = "Funez";
            string numeroTelefono = "+504 9455-5443";

            string nombreCompletoConTab = "Kevin\tFunez\nEduardo";

            //Numeros enteros
            int numeroEntero = 50;
            int numeroNegativo = -23;
            uint numeroPositivo = 23;

            //Numeros flotantes
            float numeroReal = 2.3F;

            //Booleanos
            bool esMasculino = true;

            /*Console.WriteLine($"int usa {sizeof(int)} bytes el rango es {int.MinValue:N0} hasta {int.MaxValue:N0}");
            Console.WriteLine($"double usa {sizeof(double)} bytes el rango es {double.MinValue:N0} hasta {double.MaxValue:N0}");
            Console.WriteLine($"decimal usa {sizeof(decimal)} bytes el rango es {decimal.MinValue:N0} hasta {decimal.MaxValue:N0}");
            Console.WriteLine($"float usa {sizeof(float)} bytes el rango es {float.MinValue:N0} hasta {float.MaxValue:N0}");*/


            //Solicitar valores al usuario
            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre}");

            Console.ReadLine();
        }
    }
}
