using PictureDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PictureDatabase.Repository
{

  public class AllRepository<T> : IRepository<T> where T : class
    {
     private Picture_ContestContext pic;
        private DbSet<T> dbentity;


        public AllRepository()
        {
            pic = new Picture_ContestContext();
            dbentity = (DbSet<T>)pic.Set<T>();
        }



        public void Create(T entity)
        {
            dbentity.Add(entity);
            this.Save();

            
        }

        public void Delete(T entity)
            
        {
            
            dbentity.Remove(entity);
            this.Save();
           
        }

        public IEnumerable<T> FindAll()
        {
            return dbentity.ToList();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return dbentity.Where(expression);
        }

        public void Save()
        {

            pic.SaveChanges();
            
        }

        public void Update(T entity)
        {
            dbentity.Update(entity);
            this.Save();
        }
        


}



}
