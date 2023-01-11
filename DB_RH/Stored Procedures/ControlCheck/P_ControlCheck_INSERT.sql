CREATE PROCEDURE [dbo].[P_ControlCheck_INSERT]
	@EndDateTraining DATE ,
	@BeginingDateTraining DATE ,
	@Passed BIT,
	@Failed BIT,
	@Id_HR INT,
	@Id_Trained_Employee INT
AS
BEGIN
	INSERT INTO ControlCheck(EndDateTraining , BeginingDateTraining ,Passed,Failed, Id_HR ,Id_Trained_Employee)
	VALUES(@EndDateTraining ,@BeginingDateTraining ,@Passed ,@Failed ,@Id_HR ,@Id_Trained_Employee)
END
