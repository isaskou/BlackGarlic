CREATE PROCEDURE [dbo].[SP_GetAllPerson]
	
AS
	SELECT p.Id, p.FirstName, p.LastName, p.Email, p.RoleId
	FROM Person p
RETURN 0
