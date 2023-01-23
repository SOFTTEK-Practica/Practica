using Microsoft.EntityFrameworkCore;
using System;
using WebAppCore.Model;

namespace WebAppCore.DatabaseContext
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesControl>().HasData(
                new SalesControl { Id = 1, DateSale = DateTime.Parse("2023-01-23"), seller = "William", Product = "Coca Cola", Quantity = 200, Customer = "Amazon" },
                new SalesControl { Id = 2, DateSale = DateTime.Parse("2023-01-03"), seller = "William", Product = "BIG Cola", Quantity = 400, Customer = "Amazon" },
                new SalesControl { Id = 3, DateSale = DateTime.Parse("2023-01-13"), seller = "William", Product = "Pepsi Cola", Quantity = 850, Customer = "Amazon" },
                new SalesControl { Id = 4, DateSale = DateTime.Parse("2023-01-01"), seller = "Henry", Product = "Coca Cola", Quantity = 430, Customer = "HP" },
                new SalesControl { Id = 5, DateSale = DateTime.Parse("2023-01-02"), seller = "Henry", Product = "Inca Cola", Quantity = 208, Customer = "HP" },
                new SalesControl { Id = 6, DateSale = DateTime.Parse("2023-01-06"), seller = "Henry", Product = "Pepsi Cola", Quantity = 750, Customer = "HP" },
                new SalesControl { Id = 7, DateSale = DateTime.Parse("2023-01-02"), seller = "Jack", Product = "Coca Cola", Quantity = 510, Customer = "Walmart" },
                new SalesControl { Id = 8, DateSale = DateTime.Parse("2023-01-09"), seller = "Jack", Product = "Coca Cola", Quantity = 290, Customer = "Walmart" },
                new SalesControl { Id = 9, DateSale = DateTime.Parse("2023-01-12"), seller = "Jack", Product = "Inca Cola", Quantity = 360, Customer = "Walmart" },
                new SalesControl { Id = 10, DateSale = DateTime.Parse("2023-01-11"), seller = "Joseph ", Product = "Pepsi Cola", Quantity = 300, Customer = "Sony" },
                new SalesControl { Id = 11, DateSale = DateTime.Parse("2023-01-01"), seller = "Joseph ", Product = "Pepsi Cola", Quantity = 315, Customer = "Sony" },
                new SalesControl { Id = 12, DateSale = DateTime.Parse("2023-01-21"), seller = "Joseph ", Product = "Coca Cola", Quantity = 510, Customer = "Sony" },
                new SalesControl { Id = 13, DateSale = DateTime.Parse("2023-01-02"), seller = "Marco  ", Product = "Inca Cola", Quantity = 210, Customer = "Epson" },
                new SalesControl { Id = 14, DateSale = DateTime.Parse("2023-01-07"), seller = "Marco  ", Product = "Coca Cola", Quantity = 695, Customer = "Epson" },
                new SalesControl { Id = 15, DateSale = DateTime.Parse("2023-01-13"), seller = "Marco  ", Product = "BIG Cola", Quantity = 260, Customer = "Epson" },
                new SalesControl { Id = 16, DateSale = DateTime.Parse("2023-01-03"), seller = "Ryan", Product = "Coca Cola", Quantity = 412, Customer = "Samsung" },
                new SalesControl { Id = 17, DateSale = DateTime.Parse("2023-01-09"), seller = "Ryan", Product = "BIG Cola", Quantity = 202, Customer = "Samsung" },
                new SalesControl { Id = 18, DateSale = DateTime.Parse("2023-01-20"), seller = "Ryan", Product = "Coca Cola", Quantity = 280, Customer = "Samsung" },
                new SalesControl { Id = 19, DateSale = DateTime.Parse("2023-01-04"), seller = "Mark", Product = "Pepsi Cola", Quantity = 250, Customer = "Western Digital" },
                new SalesControl { Id = 20, DateSale = DateTime.Parse("2023-01-04"), seller = "Mark", Product = "BIG Cola", Quantity = 350, Customer = "Seagate" },
                new SalesControl { Id = 21, DateSale = DateTime.Parse("2023-01-05"), seller = "Abraham", Product = "Coca Cola", Quantity = 290, Customer = "IBM" },
                new SalesControl { Id = 22, DateSale = DateTime.Parse("2023-01-06"), seller = "Odin", Product = "Pepsy Cola", Quantity = 350, Customer = "Toshiba" },
                new SalesControl { Id = 23, DateSale = DateTime.Parse("2023-01-07"), seller = "Sonny", Product = "Inca Cola", Quantity = 400, Customer = "Dell" }
            );
        }
    }
}
