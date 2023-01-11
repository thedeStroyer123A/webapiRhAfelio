CREATE PROCEDURE [dbo].[P_Employes_INSERT]
	@FirstName varchar(50),
	@LastName varchar(50),
	@DateDeNaissance date, 
	@Fonction varchar(60),
	@NumeroTel varchar(60),
	@email varchar(50)
AS
BEGIN
	INSERT INTO Employes(FirstName,LastName,DateDeNaissance,Fonction,NumeroTel,email)
	VALUES(@FirstName,@LastName,@DateDeNaissance,@Fonction,@NumeroTel,@email)
END
