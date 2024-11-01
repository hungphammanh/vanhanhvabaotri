﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

       
        public string? Name { get; set; }
        
        public string? Description { get; set; }
       
        public String? ImageUrl { get; set; }
       
        public decimal Price { get; set; }
       
        public int Quantity { get; set;}
        [ForeignKey("Category")]
        
        public int CategoryId { get; set; }
        public virtual Category? category { get; set; }



    }
}
