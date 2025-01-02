using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtensionMethods.Models;

namespace ExtensionMethods.Extentions
{
    public static class UserQueryExtensions
    {
        public static IQueryable<User> ApplyFilters(this IQueryable<User> query, string name= null , int? minAge = null, int? maxAge=null)
        {
            if(!string.IsNullOrEmpty(name))
            {
                query = query.Where(u=>u.Name.Contains(name));
            }

            if(minAge.HasValue)
            {
                query = query.Where(u=>u.Age >= minAge.Value);
            }

            if(maxAge.HasValue)
            {
                query  = query.Where(u=>u.Age <= maxAge.Value);
            }

            return query;
        }
    }
}