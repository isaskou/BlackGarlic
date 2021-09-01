CREATE PROCEDURE [dbo].[SP_FindEmail]
		@Email nvarchar(255),
		@UserId int
AS
BEGIN
	SELECT c.Id
	FROM Customer c
	where Email=@Email AND Id!=@UserId
END
