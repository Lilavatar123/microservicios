using Microservicios.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microservicios.Servicio.Interfaz
{
    public interface IProductoServicio
    {
        Task<Producto> ObtenerProducto(Guid id);
        Task<Producto> CrearProducto(Producto producto);
    }
        
}
