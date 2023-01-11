CREATE TABLE [dbo].[Materials]
(
	[Id_Material]   INT IDENTITY(1,1),
	Brand VARCHAR(50) NOT NULL,
	Type VARCHAR(50) NOT NULL,
	RegistrationNumber VARCHAR(60) NOT NULL,
	GrayCardNumber INT,
	ContractType VARCHAR(100) NOT NULL,
	ContractName VARCHAR(60) NOT NULL,
	PRIMARY KEY(Id_Material)
)
