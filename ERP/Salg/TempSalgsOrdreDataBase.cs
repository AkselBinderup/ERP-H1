namespace ERP;

public class TempSalgsOrdreHovedDataBase
{
	List<SalgsOrdreHoved> salgsOrdreHoveder = new() {
	new SalgsOrdreHoved ("Jon", "Hedegaard", new Adresse("Ultedparken", 34, "Tylstrup", 9382), "Jon@gmail.com", 40404040, new DateTime(2020, 1, 2, 3, 4, 17),1, 
						new DateTime(2022, 1, 4, 5, 30 , 1), new DateTime(2023, 4, 7, 3, 25, 0), 1, Tilstand.Oprettet, 700),
	new SalgsOrdreHoved ("Aksel", "Binderup", new Adresse("AkselVej", 4, "Aabybro", 9000), "Aksel@gmail.com", 30303030, new DateTime(2014, 1, 2, 3,4 ,17), 2, 
						new DateTime(2020, 2, 4, 5, 10, 11), new DateTime(2022, 4, 7, 3, 10, 11), 2, Tilstand.Bekræftet, 400)
	};
	public List<SalgsOrdreHoved> GetData()
	{
		List<SalgsOrdreHoved> data = new List<SalgsOrdreHoved>();
		data.AddRange(salgsOrdreHoveder);
		return data;
	}
}
