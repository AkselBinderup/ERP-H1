using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP;

public class Produkt
{
    public string VareNummer{ get; set; }
    public string Navn { get; set; }
    public string Beskrivelse { get; set; }
    public decimal SalgsPris { get; set; }
    public decimal IndkøbsPris { get; set; }
    public string Lokation {  get; set; }
    public decimal AntalLager {  get; set; }
    public Enheder Enhed {  get; set; }

    public Produkt()
    {
        //beregne fortjeneste
        //beregne avance i procent
    }
}
