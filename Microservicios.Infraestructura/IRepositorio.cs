using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microservicios.Repositorio
{
    public interface IRepositorio<E> : IDisposable where E : Dominio.Entidades.EntidadDominio
    {
        Task<E> GetByIdAsync(object id);
        Task<E> AddAsync(E entity);
    }
}
