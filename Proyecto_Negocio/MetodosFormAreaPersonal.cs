using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_AccesoDatos;
using EntidadesCompartidas;

namespace Proyecto_Negocio
{
    /****************************************
    * Métodos para el Form Area Personal    *
    ****************************************/
    public class MetodosFormAreaPersonal
    {
        AccesoDatos ad = new AccesoDatos();
        CargadoAreaPersonal cargado = new CargadoAreaPersonal();
        
        public async Task<int> sacarCurso(string user)
        {
            string aux = await ad.obtenerCurso(user);
            int salida = 0;
            switch(aux)
            {
                case "curso1":salida = 1;
                    break;
                case "curso2":salida = 2;
                    break;
            }
            
            return salida;
        }

        public async Task<List<string>> sacarAsignaturas(int curso, string user)
        {
            Dictionary<string, string> datos = new Dictionary<string, string> { };
            datos.Add("curso", curso.ToString());
            return await ad.sacarAsignaturas(user, datos);
        }

        public List<double>recogidaNotas(int curso, int usuario)
        {
           return cargado.recogidaNotas(curso, usuario);
        }

        public async Task<int> sacarUsuario(string usuario)
        {
            Dictionary<string, string> datos = new Dictionary<string, string> { };
            datos.Add("usuario", usuario);
            return await ad.sacarUsuario(usuario, datos);
        }

        public List<double>mediaNotas(int curso, int usuario)
        {
            return cargado.mediaNotas(curso, usuario);
        }

        public void agregarNota(string nota, int trimestre, string asignatura, int user)
        {
            cargado.agregarNota(nota, trimestre, asignatura, user);
        }
    }
}
