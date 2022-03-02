using DevFramework.Northwind.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Core.DataAccess
{
   public  interface IQueryableReposityory<T>where T:class,IEntity,new()
    {
        IQueryable<T> Table { get; }
    }
}
