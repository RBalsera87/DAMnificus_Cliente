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
        public List<double> recogidaNotas()
        {
            List<double> notas = new List<double> { };
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=damnificus_enlaces;";
            string query = "SELECT Nota FROM notas WHERE Trimestre = 1 order by Asignatura asc";
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
    }
}
