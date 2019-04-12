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
    }
}
