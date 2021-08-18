CREATE PROCEDURE [dbo].[SP_FindEmail]
		@Email nvarchar(255),
		@UserId int
AS
	SELECT p.Id
	FROM Person p
	where Email=@Email AND Id=@UserId
RETURN 0
