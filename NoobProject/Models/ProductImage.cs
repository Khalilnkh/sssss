using System.ComponentModel.DataAnnotations;
namespace NoobProject.Models
{
    public class ProductImage:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
    }
}

