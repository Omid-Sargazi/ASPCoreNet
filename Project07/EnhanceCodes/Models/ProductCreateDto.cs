using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnhanceCodes.Models
{
    public class ProductCreateDto
    {
        [Required(ErrorMessage ="Product Name is required.")]
        [StringLength(100,MinimumLength =2,ErrorMessage ="Product name must be between 2 and 100 characters.")]
        public string Name {get;set;}

        [Required(ErrorMessage ="Price is required.")]
        [Range(0.01,double.MaxValue, ErrorMessage ="Price must be greater than zero.")]
        public decimal Price {get;set;}
    }
}