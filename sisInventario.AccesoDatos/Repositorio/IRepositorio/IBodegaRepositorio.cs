﻿using sisInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IBodegaRepositorio: IRepositorio<Bodega>
    {
        void Actualizar(Bodega bodega);
    }
}
