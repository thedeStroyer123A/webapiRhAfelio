CREATE PROCEDURE [dbo].[P_Employes_UPDATE]
	@Id_Em INT,
	@FirstName varchar(50),
	@LastName varchar(50),
	@DateDeNaissance date,
	@Fonction varchar(60),
	@NumeroTel varchar(60),
	@email varchar(50)

AS
BEGIN
	UPDATE Employes
	SET [FirstName] = @FirstName,LastName = @LastName,DateDeNaissance = @DateDeNaissance ,Fonction = @Fonction ,NumeroTel = @NumeroTel ,email = @email 
	WHERE Id_Em = @Id_Em
END

