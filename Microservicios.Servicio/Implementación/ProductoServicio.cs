using Microservicios.Dominio.Entidades;
using Microservicios.Repositorio;
using Microservicios.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microservicios.Servicio.Implementación
{
    public class ProductoServicio : IProductoServicio
    {
        private readonly IRepositorio<Producto> RepositorioProducto;

        public ProductoServicio(IRepositorio<Producto> repositorioProducto)
        {
            RepositorioProducto = repositorioProducto;
        }

        public async Task<Producto> CrearProducto(Producto producto)
        {
           return await RepositorioProducto.AddAsync(producto);
        }

        public async Task<Producto> ObtenerProducto(Guid id)
        {
            return await RepositorioProducto.GetByIdAsync(id);
        }
    }
}
