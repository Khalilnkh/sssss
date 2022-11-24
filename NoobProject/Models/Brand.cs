using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace NoobProject.Models
{
    public class Brand:BaseEntity
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }

        public List<Product>products { get; set; }
    }
}
