using EntidadesCompartidas;
using Proyecto_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Negocio
{
    /****************************************
     * Métodos para el Formulario Inicio    *
     ****************************************/
    public class MetodosFormInicio
    {
        AccesoDatos ad = new AccesoDatos();
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
        public async Task<string> enviarEmailparaRegistro(string usuario, Dictionary<string, string> datos)
        {
            return await ad.enviarEmailparaRegistro(usuario, datos);
        }
        public async Task<bool> buscarEnBD(string modo, string elemento)
        {
            if (modo.Equals("email"))
            {
                return await ad.buscarEmailEnBD(elemento);
            }
            else
            {
                return await ad.buscarUsuarioEnBD(elemento);
            }
        }
        public async Task<bool> enviarConfirmacionRegistro(string usuario, string pass, Dictionary<string, string> datos)
        {
            if (await ad.enviarConfirmacionRegistro(usuario, pass, datos))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
