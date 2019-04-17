using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_AccesoDatos;

namespace Proyecto_Negocio
{
    /****************************************
    * Métodos para el Form Area Personal    *
    ****************************************/
    public class MetodosFormAreaPersonal
    {
        CargadoAreaPersonal cargado = new CargadoAreaPersonal();
        
        public int sacarCurso(string user)
        {
            return cargado.sacarCurso(user);
        }

        public List<string> sacarAsignaturas(int curso)
        {
            return cargado.sacarAsignaturas(curso);
        }

        public List<double>recogidaNotas(int curso, int usuario)
        {
           return cargado.recogidaNotas(curso, usuario);
        }

        public int sacarUsuario(string usuario)
        {
            return cargado.sacarUsuario(usuario);
        }

        public List<double>mediaNotas(int curso, int usuario)
        {
            return cargado.mediaNotas(curso, usuario);
        }
    }
}
