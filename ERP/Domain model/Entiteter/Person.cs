namespace ERP;

public class Person
{
    public string Fornavn { get; set; }
    public string Efternavn { get; set; }
    public Adresse Adresse { get; set; }
    public string EmailAdresse { get; set; }
    public int TelefonNummer { get; set; }
    public string FuldeNavn => $"{Fornavn} {Efternavn}";

    public string? VejNavn { get; private set; }
    public int VejNummer { get; private set; }
    public string By { get; private set; }
    public int PostNummer { get; private set; }

    public Person(Adresse adresse)
    {
        VejNavn = adresse.VejNavn;
        VejNummer = adresse.VejNummer;
        By = adresse.By;
        PostNummer = adresse.PostNummer;
    }
}
