﻿using EmemIsaac.QuizManager.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmemIsaac.QuizManager.Persistence.Repositories
{
    public class BaseRepository<T, TId> : IAsyncRepository<T, TId> where T : class
    {
        protected readonly QuizManagerDbContext _dbContext;

        public BaseRepository(QuizManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _dbContext.AddAsync<T>(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(TId id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetPagedAsync(int page, int pageSize)
        {
            page = page < 0 ? 0 : page;
            pageSize = pageSize < 0 ? 100 : pageSize;
            pageSize = pageSize > 500 ? 500 : pageSize;
            return await _dbContext.Set<T>().Skip(page * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
