using System;
using System.ComponentModel.DataAnnotations;
namespace NoobProject.Models
{
    public class Slider:BaseEntity
    {
        public int Id { get; set; }
        [StringLength(2500)]
        public string MainTitle { get; set; }
        [StringLength(2500)]
        public string SubTitle { get; set; }
        [StringLength(2500)]
        public string Description { get; set; }
        [StringLength(2500)]
        public string Image { get; set; }
        [StringLength(2500)]
        public string PageLink { get; set; }
    }
}
