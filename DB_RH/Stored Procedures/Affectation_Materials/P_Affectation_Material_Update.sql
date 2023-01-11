CREATE PROCEDURE [dbo].[P_Affectation_Material_UPDATE]
		@Id_Affectation_Material INT,
		@Date_Affectation_Material DATE,
		@Id_Material INT,
		@Id_HR INT

AS
BEGIN
	UPDATE [Affectation_Materials]
	SET [Date_Affectation_Material] = @Date_Affectation_Material , Id_Material = @Id_Material , Id_HR = @Id_HR
	WHERE Id_Affectation_Material = @Id_Affectation_Material
END