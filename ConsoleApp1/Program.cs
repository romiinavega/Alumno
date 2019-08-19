using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Rominice";
            alumno1.Matricula = "100718";

            Console.WriteLine("Nombre: " + alumno1.Nombre);
            Console.WriteLine("Matricula: " + alumno1.Matricula);
            Console.ReadLine();
        }
    }
}
