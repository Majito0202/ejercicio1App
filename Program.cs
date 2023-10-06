using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1App
{
    internal class Program
    {

        public struct Empleado
        {
            public int codigo;
            public string nombre;
            public float salario;
        }

        static void Main(string[] args)
        {
            // Tipos de datos

            int num1, num2;
            num1 = 5877;
            float flotante = 3.14f;
            double doble = 15.2d;
            decimal deci = 15.15m;
            byte b = 25;
            long larga = 123456789123456;
            ulong ulargo = 56;
            char Letra = 'a';
            string cadena = "hello";

            // var // dynamic

            var variable = 15.25f;
            dynamic dinamica = 25.3f;
            dinamica = "Nombre empleado";
            dinamica = true;
            dinamica = "c";
            Empleado emp;
            emp.codigo = 1;
            emp.nombre = "María";
            emp.salario = 500.5f; //flotante por ejemplo 50.12 no flotante numero exacto


            //arreglos 
            //Ejemplo
            int n = 4; //siempre poner el valor para que no de error (en la parte del 4)
            string[] musico = new string[n];  // siempre  inicializarlo
            string[] temporal = new string[n];
            musico[0] = "Ricardo";
            musico[1] = "María";
            musico[2] = "Ana";
            musico[3] = "Juan";

            float[] salario = new float[4];

            for (int i = 0; i < 4; i++) //4 porque son 4 cuentas inicia en 0 // i=0 , 1, 2, 3 // i menor (<) que 4 
            {
                Console.WriteLine("Digite el salario: ");
                salario[i] = float.Parse(Console.ReadLine());
            }
           



            Console.WriteLine("Listado de musicos");

            Console.WriteLine(musico[0]);           //cw y sale todo el Console.WriteLine
            Console.WriteLine(musico[1]);
            Console.WriteLine(musico[2]);
            Console.WriteLine(musico[3]);

        







            // otra manera de hacerlo 
            string[] musicos = new string[] { "Ricardo", "María", "Ana", "Juan" };

            //Ejemplo
     



        }



    }
}


         
