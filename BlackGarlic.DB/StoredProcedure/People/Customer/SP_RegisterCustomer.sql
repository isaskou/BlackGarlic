CREATE PROCEDURE [dbo].[SP_RegisterCustomer]
	@Email NVARCHAR(50),
	@Password NVARCHAR(50)
AS
BEGIN
	DECLARE @salt NVARCHAR(8)
	Set @salt = (SUBSTRING(CONVERT(NVARCHAR,RAND()),3,8));
	
	INSERT INTO Customer(Email,[Password], Salt, RoleId)
	OUTPUT inserted.Id
	VALUES (@Email, HASHBYTES('SHA2_512',@salt + @Password), @salt, 2)
END
GO
