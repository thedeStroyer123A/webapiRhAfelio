CREATE PROCEDURE [dbo].[P_Training_Section_INSERT]
	@First_Name  VARCHAR(50),
	@Last_Name VARCHAR(50),
	@Score INT
AS
BEGIN
	INSERT INTO Training_Section(First_Name , Last_Name , Score )
	VALUES(@First_Name,@Last_Name,@Score)
END
