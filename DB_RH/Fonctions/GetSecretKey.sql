CREATE FUNCTION [dbo].[GetSecretKey]()
RETURNS NVARCHAR(50)
AS
BEGIN
	declare @key VARCHAR(50)
	set @key = '&N*%zh/2ZM?!3n#J.wWH9%3UpDvDq%v$R!;84ew+q+%vr)FPbH';
	RETURN @key;
END