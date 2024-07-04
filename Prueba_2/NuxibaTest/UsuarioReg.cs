using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuxibaTest;

namespace NuxibaTest
{
    public class UsuarioReg
    {
        public static int Agregar(Usuario usuario)
        {
            int retorna = 0;
            DateTime fechaIngreso = DateTime.Today;

            using (SqlConnection Conection = Conexion.EstableceConexion())
            {

                String queryuser = "insert into usuarios (Login,Nombre,Paterno,Materno) values ('" + usuario.Login + "','" + usuario.Nombre + "','" + usuario.Paterno + "','" + usuario.Materno + "');";
                SqlCommand command = new SqlCommand(queryuser, Conection);
                retorna = command.ExecuteNonQuery();
            }
            using (SqlConnection Conection = Conexion.EstableceConexion())
            {

                String queryempl = "insert into empleados (Login,Sueldo,FechaIngreso) values ('" + usuario.Login + "','" + usuario.Sueldo + "','" + fechaIngreso.ToString("d") + "');";
                SqlCommand command = new SqlCommand(queryempl, Conection);

                retorna = command.ExecuteNonQuery();
            }

            return retorna;


        }

        public static List<Usuario> MostrarTOP()
        {
            List<Usuario> Usuarios = new List<Usuario>();

            using (SqlConnection Conection = Conexion.EstableceConexion())
            {
                String consulta = "SELECT TOP 10 u.userId, u.Login, u.Nombre, u.Paterno, u.Materno, e.Sueldo FROM usuarios u JOIN empleados e ON u.userId = e.userId ORDER BY e.Sueldo DESC;";
                SqlCommand command = new SqlCommand(consulta, Conection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Usuario Usuario = new Usuario();

                    Usuario.userId = reader.GetInt32(0);
                    Usuario.Login = reader.GetString(1);
                    Usuario.Nombre = reader.GetString(2);
                    Usuario.Paterno = reader.GetString(3);
                    Usuario.Materno = reader.GetString(4);
                    Usuario.Sueldo = reader.GetDouble(5);

                    Usuarios.Add(Usuario);
                }

                Conection.Close();
                return Usuarios;
            }

        }

        public static List<Usuario> Mostrar()
        {
            List<Usuario> Usuarios = new List<Usuario>();

            using (SqlConnection Conection = Conexion.EstableceConexion())
            {
                String consulta = "SELECT u.userId, u.Login, u.Nombre, u.Paterno, u.Materno, e.FechaIngreso, e.Sueldo FROM usuarios u JOIN empleados e ON u.userId = e.userId;";
                SqlCommand command = new SqlCommand(consulta, Conection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Usuario Usuario = new Usuario();

                    Usuario.userId = reader.GetInt32(0);
                    Usuario.Login = reader.GetString(1);
                    Usuario.Nombre = reader.GetString(2);
                    Usuario.Paterno = reader.GetString(3);
                    Usuario.Materno = reader.GetString(4);
                    Usuario.Ingreso = reader.GetDateTime(5).ToString("dd/MM/yyyy");
                    Usuario.Sueldo = reader.GetDouble(6);

                    Usuarios.Add(Usuario);

                }

                Conection.Close();
                return Usuarios;
            }

        }

        public static int Modificar(Usuario usuario)
        {
            int res = 0;
            using (SqlConnection Conection = Conexion.EstableceConexion())
            {
                String consulta = "UPDATE empleados SET sueldo = '" + usuario.Sueldo + "' WHERE Login = '" + usuario.Login + "';";
                SqlCommand command = new SqlCommand(consulta, Conection);

                res = command.ExecuteNonQuery();
                Conection.Close();
            }
            return res;
        }

        public static string CSV()
        {
            List<Usuario> Usuarios = new List<Usuario>();

            using (SqlConnection Conection = Conexion.EstableceConexion())
            {
                String consulta = "SELECT u.Login, u.Nombre, u.Paterno, u.Materno, e.FechaIngreso, e.Sueldo FROM usuarios u JOIN empleados e ON u.userId = e.userId;";
                SqlCommand command = new SqlCommand(consulta, Conection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Usuario Usuario = new Usuario();

                    Usuario.Login = reader.GetString(0);
                    Usuario.Nombre = reader.GetString(1);
                    Usuario.Paterno = reader.GetString(2);
                    Usuario.Materno = reader.GetString(3);
                    Usuario.Ingreso = reader.GetDateTime(4).ToString("dd/MM/yyyy");
                    Usuario.Sueldo = reader.GetDouble(5);

                    Usuarios.Add(Usuario);

                }

                Conection.Close();
            }

            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("Login,Nombre,Paterno,Materno,Sueldo,FechaIngreso");
            foreach (var Usuario in Usuarios)
            {
                csvContent.AppendLine($"{Usuario.Login},{Usuario.Nombre},{Usuario.Paterno},{Usuario.Materno},{Usuario.Sueldo},{Usuario.Ingreso}");
            }

            string filePath = "usuarios.csv";
            File.WriteAllText(filePath, csvContent.ToString());

            return filePath;

        }
    }
}
