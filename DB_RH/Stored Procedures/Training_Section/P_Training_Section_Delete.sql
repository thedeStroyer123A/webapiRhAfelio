CREATE PROCEDURE [dbo].[P_Training_Section_DELETE]
	@Id_Trained_Employee INT 
AS
BEGIN
	DELETE Training_Section
	WHERE Id_Trained_Employee = @Id_Trained_Employee
END
