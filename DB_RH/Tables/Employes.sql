CREATE TABLE [dbo].[Employes]
(
	[Id_Em] INT IDENTITY(1,1),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	DateDeNaissance DATE NOT NULL ,
	Fonction VARCHAR(60) NOT NULL,
	NumeroTel VARCHAR(60) NOT NULL,
	email VARCHAR(50) NOT NULL,


	PRIMARY KEY(Id_Em),
	UNIQUE(email)
)
