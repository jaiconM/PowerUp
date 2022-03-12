using Microsoft.EntityFrameworkCore;
using PowerUp.Data.Config;
using PowerUp.Domain.Core.Interfaces;

namespace PowerUp.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<PowerUpDbContext> _optionsBuilder;

        public BaseRepository()
        {
            _optionsBuilder = new DbContextOptions<PowerUpDbContext>();
        }

        public void Adicionar(T obj)
        {
            using (var db = new PowerUpDbContext(_optionsBuilder))
            {
                db.Set<T>().Add(obj);
                db.SaveChanges();
            }
        }

        public void Atualizar(T obj)
        {
            using (var db = new PowerUpDbContext(_optionsBuilder))
            {
                db.Set<T>().Update(obj);
                db.SaveChanges();
            }
        }

        public void Excluir(T obj)
        {
            using (var db = new PowerUpDbContext(_optionsBuilder))
            {
                db.Set<T>().Remove(obj);
                db.SaveChanges();
            }
        }

        public IReadOnlyList<T> Listar()
        {
            using (var db = new PowerUpDbContext(_optionsBuilder))
            {
                return db.Set<T>().AsNoTracking().ToList();
            }
        }

        public T RecuperarPorId(Guid id)
        {
            using (var db = new PowerUpDbContext(_optionsBuilder))
            {
                return db.Set<T>().Find(id);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
