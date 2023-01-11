CREATE PROCEDURE [dbo].[P_ControlCheck_DELETE]
	@Id INT
AS
BEGIN
	DELETE ControlCheck
	WHERE Id = @Id
END 

