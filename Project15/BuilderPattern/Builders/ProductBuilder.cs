using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderPattern.Models;

namespace BuilderPattern.Builders
{
    public class ProductBuilder
    {
        private Product _product = new Product();

       public ProductBuilder SetId(int Id)
       {
        _product.Id = Id;
        return this;
       }

       public ProductBuilder SetName(string name)
       {
            _product.Name = name;
            return this;
       }

       public ProductBuilder setPrice(decimal price)
       {
        _product.Price = price;
        return this;
       }

       public ProductBuilder SetDescription(string description)
       {
            _product.Description = description;
            return this;
       }

       public ProductBuilder SetIsAvailable(bool isAvailable)
       {
            _product.IsAvailable = isAvailable;
            return this;
       }

       public ProductBuilder Build()
       {
        return this;
       }
    }
}