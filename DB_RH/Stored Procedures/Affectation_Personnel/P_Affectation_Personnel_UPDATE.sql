CREATE PROCEDURE [dbo].[P_Affectation_Personnel_UPDATE]
	@Id_num INT,
	@Date_Affectation_Personnel DATE,
	@Id_HR INT,
	@Id_Em INT
AS
BEGIN
	UPDATE Affectation_Personnel
	SET [Date_Affectation_Personnel] = @Date_Affectation_Personnel , Id_HR = @Id_HR , Id_Em = @Id_Em
	WHERE Id_num = @Id_num
END
