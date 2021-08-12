CREATE PROCEDURE [dbo].[SP_GetPersonByMail]
	
	@Email nvarchar(255)
AS
	SELECT p.Id, p.FirstName, p.LastName, p.Email, p.RoleId
	FROM Person p
	where Email=@Email
	ORDER BY Email
RETURN 0
