using Vella.Shared;

namespace Vella.Client.Pages
{
    public partial class ListProducts
    {
        private List<Product> products;
        private bool variable = true;
        private string? producto;


        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            products = new List<Product>() {
                new Product { Id = 1, Code = "P001", Name = "Producto 1", Description = "Descripción del Producto 1", UnitPrice = 19.99m, UnitAmount = null, Available = 50, Photo = "https://via.placeholder.com/150", Category = "Electrónicos"},
                new Product
                {
                    Id = 2,
                    Code = "P002",
                    Name = "Producto 2",
                    Description = "Descripción del Producto 2",
                    UnitPrice = 29.99m,
                    UnitAmount = 2.5m,
                    Available = 25,
                    Photo = "https://via.placeholder.com/150",
                    Category = "Ropa"
                },
                new Product
                {
                    Id = 3,
                    Code = "P003",
                    Name = "Producto 3",
                    Description = "Descripción del Producto 3",
                    UnitPrice = 9.99m,
                    UnitAmount = 1.0m,
                    Available = 100,
                    Photo = "https://via.placeholder.com/150",
                    Category = "Hogar"
                },
            };

        }

        private Task funcionMayus(string roducto)
        {
            producto = roducto.ToUpper();
            return Task.CompletedTask;
        }
    }
}
