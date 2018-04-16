using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDBContext
    {
        DbSet<Company> Companies { get; set; }
        DbSet<Datum> Data { get; set; }
        DbSet<Info> Infoes { get; set; }
        DbSet<Recovery> Recoveries { get; set; }
        DbSet<TypeEarning> TypeEarnings { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Сurrencies> Сurrencies { get; set; }
        DbSet<Image> Images { get; set; }
    }
}
