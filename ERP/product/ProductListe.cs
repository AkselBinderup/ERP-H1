using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP;

public partial class ProductListe
{
    public int VareNummer {  get; set; }
    public string? Navn { get; set; }
    public string? Beskrivelse { get; set; }
    private int LagerAntal { get; set; }
    private float IndkøbsPris {  get; set; }
	public float SalgsPris { get; set; }
    public int[] Procent = Enumerable.Range(1, 100).ToArray(); 
    public Enheder Enhed {  get; set; }
    public string? Lokation {  get; set; }

}
