CREATE TABLE [dbo].[HumanRessourceDep]
(
	Id_HR INT IDENTITY(1,1),
	HRDepartmentName VARCHAR(50) NOT NULL,
	RH_manager_Id INT,
	Location_Id  INT,
	email VARCHAR(60) NOT NULL,
	PRIMARY KEY(Id_HR),
	UNIQUE(RH_manager_Id),
	UNIQUE(email)
)
