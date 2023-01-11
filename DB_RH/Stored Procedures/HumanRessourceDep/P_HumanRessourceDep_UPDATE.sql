CREATE PROCEDURE [dbo].[P_HumanRessourceDep_UPDATE]
	@Id_HR INT,
	@HRDepartmentName VARCHAR(50),
	@RH_manager_Id INT,
	@Location_Id INT,
	@email VARCHAR(60)
	
AS
BEGIN
	UPDATE HumanRessourceDep
	SET [HRDepartmentName]=@HRDepartmentName , RH_manager_Id = @RH_manager_Id,Location_Id = @Location_Id,email = @email 
	WHERE Id_HR = @Id_HR
END