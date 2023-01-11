CREATE TABLE [dbo].[Training_Section]
(
	Id_Trained_Employee INT IDENTITY(1,1),
	First_Name VARCHAR(50) NOT NULL,
	Last_Name VARCHAR(50) NOT NULL,
	Score INT

	PRIMARY KEY(Id_Trained_Employee)
)
