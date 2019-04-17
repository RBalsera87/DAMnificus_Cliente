using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_AccesoDatos
{
    public class CargadoAreaPersonal
    {

        private MySqlConnection conexion;

        public int sacarCurso(string user)
        {
            int salida = 0;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=damnificus_enlaces;";
            string query = "SELECT Curso FROM usuarios WHERE Nombre = '" + user + "';";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        salida = reader.GetInt16(0);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return salida;
        }

        public int sacarUsuario(string user)
        {
            int salida = 0;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=damnificus_enlaces;";
            string query = "SELECT Id FROM usuarios WHERE Nombre = '" + user + "';";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        salida = reader.GetInt16(0);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return salida;
        }

        public List<string>sacarAsignaturas(int curso)
        {
            List<string> salida = new List<string> { };
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=damnificus_enlaces;";
            string query = "SELECT Nombre FROM asignaturas WHERE curso = "+curso+" ORDER BY Id";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        salida.Add(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return salida;
        }





        public List<double> recogidaNotas(int curso, int usuario)
        {
            List<double> notas = new List<double> { };
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=damnificus_enlaces;";
            string query = "SELECT n.Nota FROM notas n INNER JOIN asignaturas a ON n.Asignatura = a.Id WHERE a.Curso = "+curso+" AND n.Usuario = "+usuario+" ORDER BY a.Id, n.Trimestre";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        notas.Add((double)reader.GetDecimal(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return notas;
        }


        public List<double> mediaNotas(int curso, int usuario)
        {
            List<double> notas = new List<double> { };
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=damnificus_enlaces;";
            string query = "SELECT CAST( AVG( n.Nota ) AS DECIMAL( 4, 2 ) ) FROM notas n INNER JOIN asignaturas a ON n.Asignatura = a.Id WHERE a.Curso = "+curso+" AND n.Usuario = "+usuario+" GROUP BY n.Asignatura ORDER BY a.Id";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        notas.Add((double)reader.GetDecimal(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return notas;
        }













        public void cargadoCursos(List<string> cursos)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=damnificus_enlaces;";
            string query = "Select cast(Id as char(1)) from curso;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cursos.Add(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }
                reader.Close();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void cargadoAsignaturas(List<string>asignaturas, string curso)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=damnificus_enlaces;";
            string query = "Select Nombre from asignaturas where Curso = "+curso+" order by Id asc;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        asignaturas.Add(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }
                reader.Close();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void cargadoTrimestres(List<string>trimestres, string asignatura)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=damnificus_enlaces;";
            string query = "Select distinct Trimestre from notas n inner join asignaturas a on n.Asignatura = a.Id where a.Nombre = '" + asignatura + "' order by Asignatura asc;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        trimestres.Add(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }
                reader.Close();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void cargarNuevaNota(string asignatura, string trimestre, string nota)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=damnificus_enlaces;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE notas SET Nota = @nota WHERE Trimestre = @trimestre AND Asignatura = (SELECT Id FROM asignaturas WHERE Nombre = @asignatura) AND Usuario = @user;";
            cmd.Parameters.AddWithValue("@nota", nota);
            cmd.Parameters.AddWithValue("@trimestre", trimestre);
            cmd.Parameters.AddWithValue("@asignatura", asignatura);
            cmd.Parameters.AddWithValue("@user", 2);
            conexion = new MySqlConnection(connectionString);
            conexion.Open();
            cmd.Connection = conexion;
            cmd.ExecuteNonQuery();

           
        }

        public double valoraciones()
        {
            double salida = 0;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=damnificus_enlaces;";
            string query = "SELECT avg(Valoracion) FROM enlaces where Uploader = 2;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       salida = (double)reader.GetDecimal(0);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }
                reader.Close();
                databaseConnection.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return salida;
        }
    }
}
