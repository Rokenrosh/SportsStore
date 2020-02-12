using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models
{
    public class Product
    {
        public Int32 ProductID { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Please enter a description")]
        public String Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public Decimal Price { get; set; }
        [Required(ErrorMessage = "Please specify a category")]
        public String Category { get; set; }
    }
}
