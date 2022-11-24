using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NoobProject.Models
{
    public class Category:BaseEntity
    {
        public int Id { get; set; }
        [StringLength(1000)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        public bool IsMain { get; set; }
        public int ParentId { get; set; }
        public Category Parent { get; set; }
        public List<Category>Children { get; set; }
        public List<Product>products { get; set; }
    }
}
