CREATE PROCEDURE [dbo].[SP_UpdatePerson]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Email nvarchar(50),
	@Password varbinary(32),
	@Salt char(36),
	@RoleId int
AS
	BEGIN
		UPDATE Person
		SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Password=@Password, 
		Salt=@Salt, RoleId=@RoleId
		WHERE Id=@Id
	END