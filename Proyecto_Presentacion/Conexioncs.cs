using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_Presentacion
{
    public class Conexion
    {
        private string cadenaConexion;
        private MySqlConnection conexion;


        public Conexion() { }

        private void conectar()
        {
            try
            {
                cadenaConexion = "Server=localhost;Database=damnificus_enlaces;Uid=root;Pwd=;";
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }

        public List<Enlaces> GetListEnlace()
        {
            conectar();
            MySqlCommand cmd = new MySqlCommand();
            //La palabra BINARY sirve para hacer distinción de mayúsculas y minúsculas
            cmd.CommandText = "Select * from enlaces";
            //cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = conexion;
            MySqlDataReader Datos = cmd.ExecuteReader();
            List<Enlaces> listaEnlaces = null;
            if (Datos.HasRows)
            {
                listaEnlaces = new List<Enlaces>();
                while (Datos.Read())
                {
                    Enlaces enlace = new Enlaces();
                    enlace.id = Datos.GetString(0);
                    enlace.link = Datos.GetString(1);
                    enlace.titulo = Datos.GetString(2);
                    enlace.descripcion = Datos.GetString(3);
                    enlace.valoracion = Datos.GetString(4);
                    enlace.imagen = Datos.GetString(5);
                    enlace.tipo = Datos.GetString(6);
                    enlace.tema = Datos.GetString(7);
                    enlace.uploader = Datos.GetString(8);
                    enlace.activo = Datos.GetString(9);
                    listaEnlaces.Add(enlace);
                    Console.WriteLine(enlace.id);
                }
                

            }

            conexion.Close();
            return listaEnlaces;
            
        }
    }
}
