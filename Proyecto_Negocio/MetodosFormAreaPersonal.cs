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
        public List<double> cargarListaNotas()
        {
            return cargado.recogidaNotas();
        }



    }
}
