using System;
using System.Collections.Generic;
using System.Text;

namespace Microservicios.Dominio.Entidades
{
    public class Producto : EntidadDominio
    {
        public Guid  Id { get; set; }
        public string Nombre { get; set; }
        public int Referencia{ get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }

    }
}
