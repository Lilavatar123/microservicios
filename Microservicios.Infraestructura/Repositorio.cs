using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microservicios.Repositorio
{
    public class Repositorio<E> : IRepositorio<E> where E : Dominio.Entidades.EntidadDominio
    {
        private readonly PersistenceContext _Context;
        private readonly DbSet<E> _Set;
        public Repositorio(PersistenceContext context)
        {
            _Context = context;
            _Set = _Context.Set<E>();
        }

        public async Task<E> GetByIdAsync(object id)
        {
            return await _Context.Set<E>().FindAsync(id).ConfigureAwait(false);
        }

        public async Task<E> AddAsync(E entity)
        {
            if (entity != null)
            {
                var item = _Context.Set<E>();
                item.Add(entity);
                await this.CommitAsync().ConfigureAwait(false);
            }
            return entity;
        }

        public async Task CommitAsync()
        {
            _Context.ChangeTracker.DetectChanges();
            await _Context.CommitAsync().ConfigureAwait(false);
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            this._Context.Dispose();
        }
    }
}
