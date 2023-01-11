CREATE PROCEDURE [dbo].[P_Affectation_Material_INSERT]
	@Date_Affectation_Material DATE,
	@Id_Material INT,
	@Id_HR INT
AS
BEGIN
	INSERT INTO [Affectation_Materials](Date_Affectation_Material , Id_Material , Id_HR)
	VALUES(@Date_Affectation_Material,@Id_Material,@Id_HR)
END
