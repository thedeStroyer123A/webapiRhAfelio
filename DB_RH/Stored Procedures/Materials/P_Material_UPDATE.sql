CREATE PROCEDURE [dbo].[P_Material_UPDATE]
	@Id_Material INT,
	@Brand VARCHAR(50),
	@Type VARCHAR(50),
	@RegistrationNumber VARCHAR(60),
	@GrayCardNumber INT,
	@ContractType VARCHAR(100),
	@ContractName VARCHAR(60)
AS
BEGIN
	UPDATE Materials
	SET [Brand] = @Brand , Type = @Type , RegistrationNumber = @RegistrationNumber , GrayCardNumber = @GrayCardNumber , ContractType = @ContractType , ContractName = @ContractName
	WHERE Id_Material = @Id_Material
END