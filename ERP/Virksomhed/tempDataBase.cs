using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP;

public class tempDataBase
{
    List<Virksomhed> companies = new() {
            new Virksomhed {Id = 1, FirmaNavn = "Techcollege ", Land = "Danmark", Valuta = Currency.DKK },
            new Virksomhed {Id = 2, FirmaNavn = "Lichtenstein PD", Land = "Lichenstein", Valuta = Currency.SEK}
        };
    public List<Virksomhed> GetData()
    {
        List<Virksomhed> companyCopy = new List<Virksomhed>();
        companyCopy.AddRange(companies);
        return companyCopy;
    }
}
