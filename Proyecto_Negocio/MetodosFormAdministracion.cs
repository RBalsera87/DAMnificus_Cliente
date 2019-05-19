using Proyecto_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Negocio
{
    public class MetodosFormAdministracion
    {
        AccesoDatos ad = new AccesoDatos();
        public async Task<bool> borrarEnlace(string usuario, Dictionary<string, string> datos)
        {
            return await ad.borrarEnlace(usuario, datos);
        }
    }
}
