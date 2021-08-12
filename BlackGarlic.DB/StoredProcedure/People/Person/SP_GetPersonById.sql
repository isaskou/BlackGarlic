CREATE PROCEDURE [dbo].[SP_GetPersonById]
	@PersonId int
AS
	SELECT p.Id, p.FirstName, p.LastName, p.Email, p.RoleId
	FROM Person p
	WHERE Id=@PersonId
	ORDER BY Id
RETURN 0
