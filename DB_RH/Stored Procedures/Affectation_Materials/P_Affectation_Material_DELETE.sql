CREATE PROCEDURE [dbo].[P_Affectation_Material_DELETE]
	@Id_Affectation_Material INT
AS
BEGIN
	DELETE [Affectation_Materials]
	WHERE Id_Affectation_Material = Id_Affectation_Material
END
