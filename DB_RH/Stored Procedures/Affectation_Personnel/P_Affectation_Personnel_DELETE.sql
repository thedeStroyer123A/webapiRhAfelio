CREATE PROCEDURE [dbo].[P_Affectation_Personnel_DELETE]
	@Id_num INT
AS
BEGIN
	DELETE FROM Affectation_Personnel
	WHERE Id_num =@Id_num
END
