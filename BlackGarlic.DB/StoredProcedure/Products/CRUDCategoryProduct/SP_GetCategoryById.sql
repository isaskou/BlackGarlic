CREATE PROCEDURE [dbo].[SP_GetCategoryById]
	@CategoryId int
AS
	SELECT *
	FROM CategoryProduct
	WHERE Id=@CategoryId
RETURN 0
