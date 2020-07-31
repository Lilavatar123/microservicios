using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservicios.Dominio.Entidades;
using Microservicios.Servicio.Interfaz;
using Microsoft.AspNetCore.Mvc;

namespace Microservicios.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private readonly IProductoServicio ProductoServicio;

        public ProductoController(IProductoServicio productoServicio)
        {
            ProductoServicio = productoServicio;

        }

        [HttpGet("{id}") ]
        public async Task<Producto> Get(Guid id)
        {
            return await ProductoServicio.ObtenerProducto(id);

        }

        [HttpPost]
        public async Task<Producto> Post(Producto producto)
        {
            return await ProductoServicio.CrearProducto(producto);

        }
    }
}
