using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace NoobProject.Models
{
    public class Product:BaseEntity
    {
        public int Id { get; set; }
        [StringLength(1000)]
        public string  Title { get; set; }
        [DataType("money")]
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        public double ExTax { get; set; }
        [StringLength(1000)]
        public string Seria { get; set; }
        public int Code { get; set; }
        public int Count { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string MainImage { get; set; }
        [StringLength(1000)]
        public string HoverImage { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsFeatured { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Brand Brand { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }  

        public List<ProductImage>productImages { get; set; }
        public List<ProductTag>productTags { get; set; }
    }
}

