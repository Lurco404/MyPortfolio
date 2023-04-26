using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.InterFaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;
        private DbSet<T> table=null; 
        public GenericRepository(DataContext context)
        {
            _context = context;
            table= _context.Set<T>();
            
        }
        public void Delete(int id)
        {
            T exist=FindById(id);
            table.Remove(exist);
        }

        public T FindById(int id)
        {
            return table.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
           return table.ToList();
            
        }

        public void Insert(T entity)
        {
            table.Add(entity);
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
