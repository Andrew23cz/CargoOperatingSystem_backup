﻿using CargoOperatingSystem.Server.Data;
using CargoOperatingSystem.Server.IRepository;
using CargoOperatingSystem.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CargoOperatingSystem.Server.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _db;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

        public Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            IQueryable<T> query = _db;

            if(includes != null)
            {
                foreach(var item in includes)
                {
                    query = query.Include(item).AsSplitQuery();
                }
            }

            return query.AsNoTracking().FirstOrDefaultAsync(expression);
           
        }

        public async Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null, 
                                            Func<IQueryable<T>, 
                                            IOrderedQueryable<T>> orderBy = null, 
                                            List<string> includes = null)
        {
            IQueryable<T> query = _db;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item).AsSplitQuery();
                }
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Delete(int id)
        {
            var record = await _db.FindAsync(id);
            _db.Remove(record);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities);

        }

        public async Task Insert(T entity)
        {
            await _db.AddAsync(entity);
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await _db.AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            //_db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task<GenericDataResult<T>> GetAllPaged (int skip, int take, Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string> includes = null)
        {
            IQueryable<T> query = _db;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item).AsSplitQuery();
                }
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return new GenericDataResult<T>() 
            {
                Data = query.Skip(skip).Take(take).AsNoTracking(),
                Count = await query.CountAsync()
            };
        }
    }
}
