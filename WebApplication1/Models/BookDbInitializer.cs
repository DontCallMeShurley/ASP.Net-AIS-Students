using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication1.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<Class1>
    {
        protected override void Seed(Class1 db)
        {
            db.Books.Add(new Book
            {
                Name = "Вазанов",
                Author = "Дмитрий",
                Otch = "Андреевич",
                Date = DateTime.Parse("5/1/2008",
                          System.Globalization.CultureInfo.InvariantCulture)
            }); ;  
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев",
                Otch = "Андреевич",
                Date = DateTime.Parse("5/1/2003",
                          System.Globalization.CultureInfo.InvariantCulture)
            });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов",
                Otch = "Андреевич",
                Date = DateTime.Parse("5/1/2012",
                          System.Globalization.CultureInfo.InvariantCulture)
            });

            db.Contacts.Add(new Contacts { Address = "проспект Тракторостроителей 35", Nubmer = 223586 });

            base.Seed(db);
        }
    }
}