using Domain.RepositoryInterfaces;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<string> Create(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return "Sucess";

        }

        public Task<string> Delete()
        {
            throw new NotImplementedException();
        }

        public Task<string> Get()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetList()
        {
            throw new NotImplementedException();
        }

        public Task<string> Update()
        {
            throw new NotImplementedException();
        }
    }
}
