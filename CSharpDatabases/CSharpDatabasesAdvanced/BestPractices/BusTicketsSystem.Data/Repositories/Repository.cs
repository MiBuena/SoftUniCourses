﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Data.Interfaces;

namespace BusTicketsSystem.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly BusTicketsSystemContext context;


        public Repository(BusTicketsSystemContext context)
        {
            this.context = context;
        }

        public void Add(TEntity entity)
        {
            this.context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            this.context.Set<TEntity>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            foreach (var element in entities)
            {
                this.context.Set<TEntity>().Remove(element);
            }
        }

        public TEntity GetById(int id)
        {
            return this.context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return this.context.Set<TEntity>().Where(predicate);
        }
    }

}
