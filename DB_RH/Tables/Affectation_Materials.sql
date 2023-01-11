CREATE TABLE [dbo].[Affectation_Materials]
(
	 [Id_Affectation_Material] INT IDENTITY(1,1),
	 [Date_Affectation_Material] DATE,
	 Id_Material INT ,
	 Id_HR  INT  ,
	 PRIMARY KEY([Id_Affectation_Material]),
	 FOREIGN KEY(Id_Material) REFERENCES Materials(Id_Material) ,
	 FOREIGN KEY (Id_HR)  REFERENCES HumanRessourceDep(Id_HR)


)
