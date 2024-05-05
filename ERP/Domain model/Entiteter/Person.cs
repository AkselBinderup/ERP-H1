namespace ERP;

public class Person
{   
    public string Fornavn { get; set; }
    public string Efternavn { get; set; }
    public Adresse Adresse { get; set; }
    public string EmailAdresse { get; set;}
    public int TelefonNummer { get; set; }
    public string FuldeNavn => $"{Fornavn} {Efternavn}";
}   
