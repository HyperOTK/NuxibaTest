using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirAlumnos
{
    public class Usuario
    {

        public int userId { get; set; }

        public string Login { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public Double Sueldo { get; set; }
        public String Ingreso { get; set; }

        public Usuario() { }

        public Usuario(int userId, string Login, string Nombre, string Paterno, string Materno, Double Sueldo, String Ingreso) 
        { 
        
            this.userId = userId;  
            this.Login= Login;
            this.Nombre = Nombre; 
            this.Paterno = Paterno;
            this.Materno = Materno;
            this.Sueldo = Sueldo;
            this.Ingreso = Ingreso;


        }
    }
}
