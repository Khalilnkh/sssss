using NoobProject.Models;
using System.Collections.Generic;

namespace NoobProject.ViewModels.HomeVM
{
    public class HomeViewModel
    {
        public List<Slider> sliders { get; set; }
        public List<Category> categories { get; set; }
        public List<Product>products { get; set; }
    }
}
