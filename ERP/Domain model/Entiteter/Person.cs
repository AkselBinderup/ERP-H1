namespace ERP;

public class Person
{   
    public string Fornavn { get; set; }
    public string Efternavn { get; set; }
    public Adresse _Adresse { get; set; }
    public string EmailAddresse { get; set;}
    public int TelefonNummer { get; set; }

    public string GetName() => 
        $"{Fornavn} {Efternavn}";
}   
