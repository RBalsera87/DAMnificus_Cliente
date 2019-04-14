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
        Proyecto_AccesoDatos.CargadoAreaPersonal cargado = new Proyecto_AccesoDatos.CargadoAreaPersonal();
        public List<double> cargarListaNotas(int curso, int trimestre)
        {
            return cargado.recogidaNotas(curso, trimestre);
        }

        public void cargarCursos(List<string>cursos)
        {
            cargado.cargadoCursos(cursos);
        }

        public void cargarAsignaturas(List<string>asignaturas, string curso)
        {
            cargado.cargadoAsignaturas(asignaturas, curso);
        }

        public void cargarTrimestres(List<string>trimestres, string asignatura)
        {
            cargado.cargadoTrimestres(trimestres, asignatura);
        }

        public void agregarNota(string asignatura, string trimestre, string nota)
        {
            cargado.cargarNuevaNota(asignatura, trimestre, nota);
        }

        public double mediaValoraciones()
        {
            return cargado.valoraciones();
        }

    }
}
