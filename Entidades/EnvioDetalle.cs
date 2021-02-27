﻿using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EnvioDetalle : IDetalle
    {
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        #region Entidades
        public Articulo Articulo { get; set; }
        public Envio Envio { get; set; }
        #endregion
    }
}
