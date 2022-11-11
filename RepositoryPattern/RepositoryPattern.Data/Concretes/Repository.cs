using Microsoft.EntityFrameworkCore;
using Repository.Data.Abstracts;
using Repository.Data.Context;
using Repository.Domain;
using Repository.Domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Data.Concretes
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public AppDbContext Context { get;}

        public Repository(AppDbContext context)
        {
            Context = context;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            T existData = Context.Set<T>().Find(entity.CourseId);
            if (existData is not null)
            {
                existData.IsDeleted=true;
                Context.Entry(existData).State=EntityState.Modified;
                Context.SaveChanges();
            }
        }

        public IQueryable<T> UpdateGetAll()
        {
            return Context.Set<T>().Where(x => x.IsDeleted).AsQueryable();

        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return Context.Set<T>().Where(expression).AsQueryable();
        }

        public void HardDelete(T entity)
        {
            T existData = Context.Set<T>().Find(entity.CourseId);
            if (existData is not null)
            {
                Context.Set<T>().Remove(existData);
                Context.SaveChanges();  
            }
        }

        public void Update(T entity)
        {
            T existData = Context.Set<T>().Find(entity.CourseId);
            if (existData is not null)
            {
                Context.Set<T>().Update(entity);
                Context.SaveChanges();
            }

                //Context.Entry(entity).State = EntityState.Modified;
                
        }

        public IQueryable<T> GetById(int id)
        {
            return Context.Set<T>().Where(x => x.CourseId == id).AsQueryable();
        }

        //public void Update(T entity)
        //{
        //    Context.Update(entity);
        //    Context.SaveChanges();
        //}


    }
}
