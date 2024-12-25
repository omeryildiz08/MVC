using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    //bu class veri tabanı gibi kullanılacak
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}