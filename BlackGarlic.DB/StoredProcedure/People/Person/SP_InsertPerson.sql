CREATE PROCEDURE [dbo].[SP_InsertPerson]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Email nvarchar(50),
	@Password nvarchar(50),
	@RoleId int
AS
	DECLARE @Salt nvarchar(8)
	SET @Salt=dbo.SF_GenerateSalt();
	
	INSERT INTO Person(
	FirstName, LastName, Email, [Password], Salt, RoleId)
	OUTPUT inserted.Id
	VALUES (@FirstName, @LastName, @Email, dbo.SF_GeneratePWD(CONCAT(@Salt, @Password)), @Salt, @RoleId)
