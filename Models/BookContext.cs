using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookingAppStore.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л.Н. Толстой", Price = 220 });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И.С. Тургенев", Price = 150 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А.П. Чехов", Price = 130 });

            base.Seed(db);
        }
    }
}