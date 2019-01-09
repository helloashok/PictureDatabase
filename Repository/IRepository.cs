using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PictureDatabase.Repository
{
 
    interface IRepository<T> where T:class
    {
        // this is for querying all the items in the table
        IEnumerable<T> FindAll();


        // this is for finding   indivdual component 
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);

        //this is for inserting 
        void Create(T entity);

        // this is for update 
        void Update(T entity);

        // this is for delete 
        void Delete(T entity);

        

        //this is for save 
        void Save();

       








    }
   
}

