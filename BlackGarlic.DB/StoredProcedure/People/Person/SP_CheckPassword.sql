CREATE PROCEDURE [dbo].[SP_CheckPassword]
	@mail nvarchar(50),
	@pwd nvarchar(50)
AS
	SELECT Id
	FROM Person
	WHERE @mail=Email AND dbo.SF_GeneratePWD([Salt]+@pwd)=[Password]
RETURN 0
