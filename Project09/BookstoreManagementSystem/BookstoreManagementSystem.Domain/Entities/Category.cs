using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagementSystem.Domain.Interfaces;

namespace BookstoreManagementSystem.Domain.Entities
{
    public class Category:IAggregateRoot
    {
        public int Id {get; private set;}
        public string Name {get; private set;}
        public List<Book> Books {get; private set} = new List<Book>();


        public Category(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name cannot be empty.");
            Name = name;
        }

        public void Update(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name cannot be empty");
            Name = name;
        }
    }
}