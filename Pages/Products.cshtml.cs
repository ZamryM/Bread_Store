using BreadStore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BreadStore.Pages
{
    public class ProductsModel : PageModel
    {
        public List<BreadModel> BreadModels = new List<BreadModel>()
        {
            new BreadModel(){BreadName="Flat Bread",ImageName="FlatBread",BreadSize="Medium",BreadPrice=25},
            new BreadModel(){BreadName="French Bread",ImageName="FrenchBread",BreadSize="Large",BreadPrice=35},
            new BreadModel(){BreadName="Multi Grain Bread",ImageName="MultiGrainBread",BreadSize="Small",BreadPrice=40},
            new BreadModel(){BreadName="Rye Bread",ImageName="RyeBread",BreadSize="Medium",BreadPrice=25},
            new BreadModel(){BreadName="Wheat Bread",ImageName="WheatBread",BreadSize="Large",BreadPrice=35},
            new BreadModel(){BreadName="White Bread",ImageName="WhiteBread",BreadSize="Small",BreadPrice=40},
        };
        public void OnGet()
        {
        }
    }
}
