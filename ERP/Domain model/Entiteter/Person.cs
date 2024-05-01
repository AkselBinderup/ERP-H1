using ERP.Domain_model.Person_oplysninger;

namespace ERP.Domain_model.Personoplysninger;

public class Person
{   
    public string Fornavn { get; set; }
    public string Efternavn { get; set; }
    public Adresse _Adresse { get; set; }
    public string EmailAddresse { get; set;}
    public int TelefonNummern { get; set; }

    public string GetName() => 
        $"{Fornavn} {Efternavn}";
}   
