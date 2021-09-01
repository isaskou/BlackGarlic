CREATE PROCEDURE [dbo].[SP_GetRoleById]
	@Id int

AS
BEGIN
	SELECT *
	FROM [Role]
	Where Id=@Id
END
