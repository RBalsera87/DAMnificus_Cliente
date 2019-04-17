using EntidadesCompartidas;
using Proyecto_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proyecto_Negocio
{
    public class MetodosFormCursos
    {
        AccesoDatos ad = new AccesoDatos();
        public async Task<List<Enlaces>> obtenerEnlaces(string usuario)
        {
            Object objectoListaEnlaces = await ad.obtenerEnlaces(usuario);
            List<Enlaces> listaEnlaces = (List<Enlaces>)objectoListaEnlaces;
            return listaEnlaces;
        }
    }
}
