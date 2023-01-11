CREATE TABLE [dbo].[Affectation_Personnel]
(
	[Id_num] INT NOT NULL  IDENTITY(1,1),
	Date_Affectation_Personnel DATE,
	Id_HR  INT,
	Id_Em INT,
	PRIMARY KEY(Id_num),
	FOREIGN KEY(Id_HR) REFERENCES HumanRessourceDep(Id_HR),  
	FOREIGN KEY (Id_Em) REFERENCES Employes(Id_Em)


)
