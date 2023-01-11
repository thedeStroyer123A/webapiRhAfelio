CREATE PROCEDURE [dbo].[P_Material_DELETE]
	@Id_Material INT
AS
BEGIN
	DELETE Materials
	WHERE Id_Material = @Id_Material
END
