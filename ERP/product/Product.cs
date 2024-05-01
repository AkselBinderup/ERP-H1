using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.product
{
    public partial class Product
    {
        int Varenummer {  get; set; }
        string Navn { get; set; }
        int Lagerantal { get; set; }
        float Indkøbsspris {  get; set; }
        float Salgspris { get; set; }
        int[] procent = Enumerable.Range(1, 100).ToArray(); 

    }
}
