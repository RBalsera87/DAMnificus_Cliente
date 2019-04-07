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
                Console.WriteLine(ex);
                Console.Read();
            }

            return notas;
        }
    }
}
