#region

//------------------------------------------------------------------------
// <copyright file= "RepositoryBase.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/3/2017 5:54:49 AM</date>
//------------------------------------------------------------------------
#endregion

namespace TotalTeamDesigns.DAL.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Contracts.Repositories;
    using Data;

    /// <summary>
    //Repository abstract class
    /// </summary>
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        internal DataContext context;
        internal DbSet<TEntity> dbset;

        public RepositoryBase(DataContext context)
        {
            this.context = context;
            this.dbset = context.Set<TEntity>();
        }

        public virtual void Commit()
        {
            context.SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            if(context.Entry(entity).State == EntityState.Detached)
            {
                dbset.Attach(entity);
            }
            dbset.Remove(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entity = dbset.Find(id);
            Delete(entity);
        }

        public virtual void Dispose()
        {
            context.Dispose();
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return dbset;
        }

        public virtual IQueryable<TEntity> GetAll(object filter)
        {
            return null; //need to override in order to implement specific filtering.
        }

        public virtual TEntity GetById(object id)
        {
            return dbset.Find(id);
        }

        public virtual TEntity GetFullObject(object id)
        {
            return null; //need to override in order to implement specific object graph.
        }

        public virtual IQueryable<TEntity> GetPaged(int top = 20, int skip = 0, object orderBy = null, object filter = null)
        {
            return null; //need to override in order to implement specific filtering and ordering
        }

        public virtual void Insert(TEntity entity)
        {
            dbset.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            dbset.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}