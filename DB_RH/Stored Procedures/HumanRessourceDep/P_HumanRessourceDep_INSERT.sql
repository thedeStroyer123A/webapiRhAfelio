CREATE PROCEDURE [dbo].[P_HumanRessourceDep_INSERT]
	@HRDepartmentName VARCHAR(50),
	@RH_manager_Id INT,
	@Location_Id  INT,
	@email VARCHAR(60)
	

AS
BEGIN
	INSERT INTO HumanRessourceDep(HRDepartmentName,RH_manager_Id,Location_Id,email)
	VALUES(@HRDepartmentName,@RH_manager_Id,@Location_Id,@email)
END
