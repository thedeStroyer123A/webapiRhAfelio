CREATE TABLE [dbo].[ControlCheck]
(
	Id INT IDENTITY(1,1),
	EndDateTraining DATE NOT NULL,
	BeginingDateTraining DATE NOT NULL,
	Passed BIT DEFAULT(0) NOT NULL,
	Failed BIT DEFAULT(1) NOT NULL,
	[Id_HR]   INT,
	Id_Trained_Employee INT,
	
	PRIMARY KEY(Id),
	FOREIGN KEY([Id_HR]) REFERENCES HumanRessourceDep(Id_HR),
	FOREIGN KEY(Id_Trained_Employee)  REFERENCES Training_Section(Id_Trained_Employee)



)
