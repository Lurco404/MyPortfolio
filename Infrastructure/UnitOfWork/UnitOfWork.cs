using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.InterFaces;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context)
        {
            _context = context;
            
        }
        IGenericRepository<T> IUnitOfWork<T>.Entity => throw new NotImplementedException();

        void IUnitOfWork<T>.Save()
        {
            throw new NotImplementedException();
        }
    }
}
