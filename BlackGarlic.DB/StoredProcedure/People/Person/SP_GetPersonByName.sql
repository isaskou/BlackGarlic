CREATE PROCEDURE [dbo].[SP_GetPersonByName]
	@LastName nvarchar(50)
AS
	SELECT p.Id, p.FirstName, p.LastName, p.Email, p.RoleId
	FROM Person p
	Where LastName=@LastName
	ORDER BY LastName
RETURN 0
