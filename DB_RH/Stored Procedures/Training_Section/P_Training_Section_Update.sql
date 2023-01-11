CREATE PROCEDURE [dbo].[P_Training_Section_UPDATE]
	@Id_Trained_Employee INT,
	@First_Name VARCHAR(50),
	@Last_Name VARCHAR(50),
	@Score INT
AS
BEGIN
	UPDATE Training_Section
	SET [First_Name] = @First_Name , Last_Name = @Last_Name , Score = @Score
	WHERE Id_Trained_Employee = @Id_Trained_Employee
END

	