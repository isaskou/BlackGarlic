CREATE PROCEDURE [dbo].[SP_UpdatePersonWithoutPassword]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Email nvarchar(50)
AS
	BEGIN
		UPDATE Person
		SET FirstName=@FirstName, LastName=@LastName, Email=@Email
		WHERE Id=@Id
	END