﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.DAL.Repositories.Infrastructure
{
    internal interface IRepository<T> : IDisposable where T : class
    {
        DrBeshoyClinicEntities Context { get; }
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
        IQueryable<T> GetAll();
        T GetById(int id);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
    }

    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        #region Properties

        private DrBeshoyClinicEntities _context;

        public DrBeshoyClinicEntities Context
        {
            get => _context ?? (_context = new DrBeshoyClinicEntities());
            private set => _context = value;
        }

        private DbSet<T> _dbSet;
        public DbSet<T> DbSet => _dbSet ?? (_dbSet = Context.Set<T>());

        #endregion

        #region Methods

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            DbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            if (Context == null) return;
            Context.Dispose();
            Context = null;
        }

        #endregion
    }
}