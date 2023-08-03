using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noting_Fication.Models;

namespace Noting_Fication.Repo
{
    public class RepoBase<T> where T : class
    {
        private readonly NotingFication_2Context _dbContext;
        private readonly DbSet<T> _dbSet;
        public RepoBase()
        {
            _dbContext = new NotingFication_2Context();
            _dbSet = _dbContext.Set<T>();
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _dbContext.SaveChanges();
        }
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
