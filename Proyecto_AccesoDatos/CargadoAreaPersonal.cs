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
        

        public List<double> recogidaNotas()
        {
            List<double> notas = new List<double> { };
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=damnificus_enlaces;";
            string query = "SELECT Nota FROM notas order by Asignatura asc";
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

        public void cargadoComboboxes(List<string> cursos, List<string> asignaturas, List<string> trimestres)
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
                query = "Select Nombre from asignaturas order by Id asc;";
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader2 = commandDatabase.ExecuteReader();
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        asignaturas.Add(reader2.GetString(0));
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

        }
    }
}
