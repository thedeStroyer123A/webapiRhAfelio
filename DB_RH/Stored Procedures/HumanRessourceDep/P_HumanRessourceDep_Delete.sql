CREATE PROCEDURE [dbo].[P_HumanRessourceDep_DELETE]
	@Id_HR INT
AS
BEGIN
	DELETE HumanRessourceDep
	WHERE Id_HR = @Id_HR;
END
