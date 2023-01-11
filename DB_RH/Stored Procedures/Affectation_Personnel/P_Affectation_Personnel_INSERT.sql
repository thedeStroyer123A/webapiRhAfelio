CREATE PROCEDURE [dbo].[P_Affectation_Personnel_INSERT]
	@Date_Affectation_Personnel DATE,
	@Id_HR INT,
	@Id_Em INT
AS
BEGIN
	INSERT INTO Affectation_Personnel(Date_Affectation_Personnel,Id_HR,Id_Em)
	VALUES(@Date_Affectation_Personnel,@Id_HR,@Id_Em)
END
