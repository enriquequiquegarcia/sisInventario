﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo:IDisposable
    {
        IBodegaRepositorio Bodega {  get; }
        Task Guardar();

    }
}
