using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Alumno
    {
        private const string V = "";

        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Alumno()
        {
            Nombre = "Pendiente";
            Matricula = "Sin asignar";
  
        }

    }
}
