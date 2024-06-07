namespace ERP;

public class Person
{
    public string? Fornavn { get; set; }
    public string? Efternavn { get; set; }
    public Adresse? Adresse { get; set; }
    public string? Email { get; set; }
    public int TelefonNummer { get; set; }
    public string? FuldeNavn => $"{Fornavn} {Efternavn}";
    public string? VejNavn { get;  set; }
    public int VejNummer { get; set; }
    public string? ByNavn { get; set; }
    public int PostNummer { get; set; }

    public Person(){}

    public Person(Adresse adresse)
    {
        VejNavn = adresse.VejNavn;
        VejNummer = adresse.VejNummer;
        ByNavn = adresse.By;
        PostNummer = adresse.PostNummer;
    }

    public Person(string? fornavn, string? efternavn, string? email, int telefonNummer)
    {
        Fornavn = fornavn;
        Efternavn = efternavn;
        Email= email;
        TelefonNummer = telefonNummer;
    }
}
