using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP;

public partial class ProductListe
{
    public int Varenummer {  get; set; }
    public string? Navn { get; set; }
    public string? Beskrivelse { get; set; }
    private int Lagerantal { get; set; }
    private float Indkøbsspris {  get; set; }
	public float Salgspris { get; set; }
    public int[] procent = Enumerable.Range(1, 100).ToArray(); 
    public Enheder Enhed {  get; set; }
    public string? Lokation {  get; set; }

}
