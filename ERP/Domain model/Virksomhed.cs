using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain_model;

public class Virksomhed
{
    public int id { get; set; }
    public string FirmaNavn { get; set; }
    public string Vej {  get; set; }
    public string HusNummer {  get; set; }
    public string PostNummer { get; set; }
    public string By {  get; set; }
    public string Land { get; set; }
    public Currency Valuta { get; set; }
}
