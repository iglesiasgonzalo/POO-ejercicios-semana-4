using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace POO_ejercicios_semana_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO 1
            Persona persona1 = new Persona();
            persona1.MostrarDatos();

            Console.WriteLine("\nInicializando con solo el nombre:");
            Persona persona2 = new Persona("GONZALO");
            persona2.MostrarDatos();

            Console.WriteLine("\nInicializando con todos los atributos:");
            Persona persona3 = new Persona("Gonzalo", 43, "24556234");
            persona3.MostrarDatos();

            Console.WriteLine("\nModificando la edad de persona3:");
            persona3.SetEdad(43);
            Console.WriteLine($"Edad modificada: {persona3.GetEdad()}");

            Console.ReadKey();*/

            //EJERCICIO 2
            // Crear instancia de la clase Calculadora
            Calculadora miCalculadora = new Calculadora();

            // Sumar dos números enteros
            int sumaEnteros = miCalculadora.Sumar(15, 45);
            Console.WriteLine($"La suma de 15 y 45 es: {sumaEnteros}");

            // Sumar tres números de tipo double
            double sumaDoubles = miCalculadora.Sumar(4.5, 3.5, 6.0);
            Console.WriteLine($"La suma de 4.5, 3.5 y 6.0 es: {sumaDoubles}");

            // Sumar con mensaje
            int sumaConMensaje = miCalculadora.Sumar("Sumando 10 y 7:", 10, 7);
            Console.WriteLine($"Resultado de la suma: {sumaConMensaje}");

            // Verificar si un número es par
            int numero = 15;
            bool esPar = miCalculadora.EsPar(numero);
            Console.WriteLine($"¿El número {numero} es par? {esPar}");

            Console.ReadKey();

        }
    }
    /* Ejercicio 1  Crear la clase Persona con diferentes constructores, para ello tendremos en cuenta las siguientes opciones: 
    Inicializar una clase Persona con atributos nombre, edad y dni.Crear un constructor sin parámetros que inicialice con valores por defecto.
    Inicializar la clase Persona con solo el nombre.Crear un constructor que reciba todos los atributos.
    Crear un método mostrarDatos() que imprima los atributos.Definir la edad como privado y crear un método de acceso (get) y un método para modificar su valor (set).*/
    /*   public class Persona
       {
           public string Nombre;
           private int Edad; 
           public string DNI;

           public Persona()
           {
               Nombre = "Gonzalo";
               Edad = 43;
               DNI = "24556234";
           }

           public Persona(string nombre)
           {
               Nombre = nombre;
               Edad = 43; 
               DNI = "24556234"; 
           }

           public Persona(string nombre, int edad, string dni)
           {
               Nombre = nombre;
               Edad = edad;
               DNI = dni;
           }


           public int GetEdad()
           {
               return Edad;
           }


           public void SetEdad(int edad)
           {
               if (edad >= 0) 
               {
                   Edad = edad;
               }
               else
               {
                   Console.WriteLine("La edad no puede ser negativa.");
               }
           }

           public void MostrarDatos()
           {
               Console.WriteLine($"Nombre: {Nombre}");
               Console.WriteLine($"Edad: {Edad}");
               Console.WriteLine($"DNI: {DNI}");
           }
       }*/

    /*Ejercicio 2: Crear una clase Calculadora.
    Crear un método sumar(int a, int b) que devuelva una suma. Crear un método sumar(double a, double b, double c) para sumar tres números.
    Crear un método sumar(string mensaje, int a, int b) que imprima el mensaje por consola y luego la suma.
    Crear un método que devuelva true si un número es par o false si es impar bool esPar(int a).*/
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

       
        public double Sumar(double a, double b, double c)
        {
            return a + b + c;
        }

        public int Sumar(string mensaje, int a, int b)
        {
            Console.WriteLine(mensaje);
            return a + b;
        }

        public bool EsPar(int a)
        {
            return a % 2 == 0; 
        }
    }

}


