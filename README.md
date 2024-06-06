# ERP Program

## Introduktion

Dette ERP (Enterprise Resource Planning) program er designet til at hjælpe virksomheder med at styre deres kerneforretningsprocesser effektivt. Programmet integrerer forskellige funktioner såsom finansstyring, lagerstyring, salgsstyring og meget mere i én samlet løsning.

## Funktioner

- **Finansstyring**: Overvåg og administrer økonomiske transaktioner, budgetter og regnskaber.
- **Lagerstyring**: Hold styr på lagerbeholdning, bestillinger og leverancer.
- **Salgsstyring**: Administrer kundeordrer, fakturering og salgsrapporter.
- **Virksomhedsstyring**: Administrer virksomheder og deres adresser samt hvilken valuta de bruger.

## Installation

For at installere og køre ERP programmet, følg disse trin:

### Krav

Sørg for, at følgende krav er opfyldt:

- Operativsystem: Windows/Linux/MacOS
- Database: En SQL server

### Klon repository

```bash
git clone https://github.com/AkselBinderup/ERP-H1.git
cd erp-program
Opdater konfigurationsfil
Lav eller find Connection string.
```

Åbn src/main/resources/application.properties og opdater databaseforbindelsesoplysninger.

Byg og kør applikationen

```bash
Kopier kode
mvn clean install
java -jar target/erp-program-1.0.0.jar
```
Projektstruktur
Projektet er organiseret i følgende mapper og filer:

Rodmappen

.github/workflows: Indeholder GitHub Actions workflows.
ERP: Hovedmappen for programkoden.
UnitTests: Indeholder enhedstest for projektet.
.gitattributes og .gitignore: Git konfigurationsfiler.
ERP.sln: Løsningsfil for projektet.
ERP mappen

Database: Indeholder database relaterede filer.
Domain model: Indeholder domænemodeller.
Kunde: Indeholder kunde-relaterede filer.
Product: Indeholder produkt-relaterede filer.
Salg: Indeholder salgs-relaterede filer.
Virksomhed: Indeholder virksomhed-relaterede filer.
ConfigSettings.cs, ERP.csproj, HovedMenus.cs, Program.cs, README.md, Regler.txt, appsettings.json: Diverse konfigurations- og kodefiler.
Database mappen

Repositories: Indeholder repositories til databaseadgang.
CommonDBModule.cs, CompanyDatabase.cs, Database.cs, IDBRepository.cs, SemiCommonDBModule.cs: Database relaterede kodefiler.
Licens
Dette projekt er licenseret under MIT-licensen. Se LICENSE på GitHub for flere detaljer.
