CREATE PROCEDURE [dbo].[P_Material_INSERT]
	@Brand VARCHAR(50),
	@Type VARCHAR(50),
	@RegistrationNumber VARCHAR(60),
	@GrayCardNumber INT,
	@ContractType VARCHAR(100),
	@ContractName VARCHAR(60)
AS
BEGIN
	INSERT INTO Materials(Brand,Type,RegistrationNumber,GrayCardNumber,ContractType,ContractName)
	VALUES(@Brand,@Type,@RegistrationNumber,@GrayCardNumber,@ContractType,@ContractName)	
END
