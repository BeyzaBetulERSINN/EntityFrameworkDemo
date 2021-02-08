using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class Product // Tablolara karşılık gelen bir nesne
        //benim bir classım var ve bu class veri tabanında şu class a karşılık geliyor demem lazım.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
