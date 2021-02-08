using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ETradeContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        //Tablolarda producs diye birşey arıyor.
    }
}
//contex birden fazla oluşturulabiliyor ama çoğu projede bir contex ile gidilir