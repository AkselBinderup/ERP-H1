using ERP.Domain_model.Person_oplysninger;

namespace ERP.Domain_model.Personoplysninger;

public class Person
{   
    public string Navn { get; set; }
    public Adresse _Adresse { get; set; }
    //andre oplysninger
}   
