using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtensionMethods02.Models;

namespace ExtensionMethods02.Main
{
    public static class UserQueryExtensions
    {
        public static IQueryable<User> ApplyFilters(this IQueryable<User> query, string name, int? minAge, int? maxAge)
        {
            if(!string.IsNullOrEmpty(name))
            {
                query = query.Where(u=>u.Name.Contains(name));
            }
            if(minAge.HasValue)
            {
                query = query.Where(u=>u.Age >=minAge.Value);
            }

            if(maxAge.HasValue)
            {
                query = query.Where(u=>u.Age <=maxAge.Value);
            }

            return query;
        }
    }
}