using Proyecto_AccesoDatos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proyecto_Negocio
{
    /****************************************
     * Métodos para el Formulario de Ayuda  *
     ****************************************/
    public class MetodosFormAyuda
    {
        AccesoDatos ad = new AccesoDatos();
        public async Task<string> cambiarPass(string usuario, string passActual, string passNueva)
        {
            return await ad.cambiarPass(usuario, passActual, passNueva);
        }
        public async Task<string> obtenerCurso(string usuario)
        {
            return await ad.obtenerCurso(usuario);
        }
        public async Task<bool> cambiarCurso(string usuario, string curso)
        {
            return await ad.cambiarCurso(usuario, curso);
        }
        public async Task<bool> enviarEmailReporte(string usuario, Dictionary<string, string> datos)
        {
            return await ad.enviarEmailReporte(usuario, datos);
        }
        public async Task<string> enviarEmailPassPerdida(string usuario, Dictionary<string, string> datos)
        {
            return await ad.enviarEmailPassPerdida(usuario, datos);
        }
        public async Task<bool> restaurarPass(string email, string passNueva)
        {
            return await ad.restaurarPass(email, passNueva);
        }
        public bool comprobarEmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> buscarEmailEnBD(string email)
        {
            return await ad.buscarEmailEnBD(email);
        }

        public async Task borrarNotas(string usuario, string curso)
        {
            Dictionary<string, string> datos = new Dictionary<string, string> { };
            datos.Add("curso", curso);
            await ad.borrarNotas(usuario, datos);
        }

    }
}
