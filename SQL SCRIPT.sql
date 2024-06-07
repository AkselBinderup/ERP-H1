
DROP TABLE Virksomhed
GO
DROP TABLE SalgsOrdreHoved
GO
DROP TABLE Kunde
GO
DROP TABLE Produkt
GO 
DROP TABLE Person
GO
DROP TABLE Adresse
GO

CREATE TABLE Adresse(
AdresseId INT IDENTITY(1,+1) PRIMARY KEY NOT NULL,
VejNavn VARCHAR(255),
VejNummer INT,
ByNavn VarChar(255),
PostNummer INT
);
GO
CREATE TABLE Person(
PersonId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Fornavn VARCHAR(255) NOT NULL,
Efternavn VARCHAR(255) NOT NULL,
Email VARCHAR(255),
TelefonNummer INT,
FuldeNavn AS (Fornavn + ' ' + Efternavn) PERSISTED,
AdresseId INT,
FOREIGN KEY (AdresseId) REFERENCES Adresse(AdresseId)
);
GO
CREATE TABLE Produkt(
VareNummer INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Navn VARCHAR(255),
Beskrivelse VARCHAR(MAX),
SalgsPris DECIMAL,
Indkøbspris DECIMAL,
Lokation VARCHAR(MAX),
AntalLager INT,
Enhed VARCHAR(15),
Avance DECIMAL,
[Status] VARCHAR(10) DEFAULT 'Eksisterer'
);
GO
CREATE TABLE Kunde(
KundeNummer INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
SidsteKøb DATETIME,
ProduktId INT,
PersonId INT,
[Status] VARCHAR(10) DEFAULT 'Eksisterer',
FOREIGN KEY (PersonId) REFERENCES Person(PersonId),
FOREIGN KEY (ProduktId) REFERENCES Produkt(VareNummer)
);
GO

CREATE TABLE SalgsOrdreHoved(
OrdreNummer INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
OprettelsesTidspunkt DATETIME,
GennemførelsesTidspunkt DATETIME,
OrdreBeløb DECIMAL,
Tilstand VARCHAR(255),
OrdreLinjer INT,
VareNummer INT,
KundeNummer INT,
FOREIGN KEY (KundeNummer) REFERENCES Kunde(KundeNummer),
FOREIGN KEY (VareNummer) REFERENCES Produkt (VareNummer)
);
GO
CREATE TABLE Virksomhed(
VirksomhedsId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
FirmaNavn VARCHAR(255),
Vej VARCHAR(255),
HusNummer INT,
PostNummer INT,
[By] VARCHAR(255),
Land VARCHAR(255),
Valuta VARCHAR(255)
);
GO
INSERT INTO Adresse (VejNavn, VejNummer, ByNavn, PostNummer)
VALUES ('Main St', 1, 'Copenhagen', 1000),
       ('Elm St', 2, 'Aarhus', 8000),
       ('Oak St', 3, 'Odense', 5000);

INSERT INTO Person (Fornavn, Efternavn, Email, TelefonNummer, AdresseId)
VALUES ('John', 'Doe', 'john.doe@example.com', 12345678, 1),
       ('Jane', 'Smith', 'jane.smith@example.com', 87654321, 2),
       ('Alice', 'Johnson', 'alice.johnson@example.com', 11223344, 3);

INSERT INTO Produkt (Navn, Beskrivelse, SalgsPris, Indkøbspris, Lokation, AntalLager, Enhed, Avance)
VALUES ('Product A', 'Description of Product A', 100.00, 60.00, 'Warehouse A', 10, 'pcs', 40.00),
       ('Product B', 'Description of Product B', 200.00, 120.00, 'Warehouse B', 20, 'pcs', 80.00),
       ('Product C', 'Description of Product C', 300.00, 180.00, 'Warehouse C', 30, 'pcs', 120.00);

INSERT INTO Kunde (SidsteKøb, ProduktId, PersonId)
VALUES ('2023-01-01 10:00:00', 1, 1),
       ('2023-02-01 11:00:00', 2, 2),
       ('2023-03-01 12:00:00', 3, 3);

INSERT INTO SalgsOrdreHoved (OprettelsesTidspunkt, GennemførelsesTidspunkt, OrdreBeløb, Tilstand, OrdreLinjer, VareNummer, KundeNummer)
VALUES ('2023-01-01 10:00:00', '2023-01-02 10:00:00', 100.00, 'Completed', 1, 1, 1),
       ('2023-02-01 11:00:00', '2023-02-02 11:00:00', 200.00, 'Completed', 1, 2, 2),
       ('2023-03-01 12:00:00', '2023-03-02 12:00:00', 300.00, 'Completed', 1, 3, 3);

INSERT INTO Virksomhed (FirmaNavn, Vej, HusNummer, PostNummer, [By], Land, Valuta)
VALUES ('Company A', 'Street A', 1, 1000, 'Copenhagen', 'Denmark', 'DKK'),
       ('Company B', 'Street B', 2, 2000, 'Aarhus', 'Denmark', 'DKK'),
       ('Company C', 'Street C', 3, 3000, 'Odense', 'Denmark', 'DKK');

SELECT 
    so.*, 
    p.FuldeNavn
FROM 
    dbo.SalgsOrdreHoved so
JOIN 
    dbo.Kunde k ON so.KundeNummer = k.KundeNummer
JOIN 
    dbo.Person p ON k.PersonId = p.PersonId;
GO