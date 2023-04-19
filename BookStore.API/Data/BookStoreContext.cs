using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)      //this way we configure dbcontext
        {
        }
        public DbSet<Books>Books{get;set;} //create new table in dB



    }
}
