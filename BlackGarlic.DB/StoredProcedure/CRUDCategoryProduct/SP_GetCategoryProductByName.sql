CREATE PROCEDURE [dbo].[SP_GetCategoryProductByName]
	@name nvarchar(255)
AS
	SELECT *
	FROM CategoryProduct
	Where [Name]=@name
RETURN 0
