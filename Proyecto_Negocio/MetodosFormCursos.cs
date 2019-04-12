﻿using EntidadesCompartidas;
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
            List<Enlaces> listaEnlaces = await ad.obtenerEnlaces(usuario);
            return listaEnlaces;
        }
    }
}