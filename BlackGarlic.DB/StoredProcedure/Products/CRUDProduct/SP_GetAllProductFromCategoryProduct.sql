CREATE PROCEDURE [dbo].[SP_GetAllProductFromCategoryProduct]
	@categoryName nvarchar(255),
	@idCategory int,
	@idProduct int
AS
	SELECT p.*, cp.*
	FROM Product p
		JOIN CategoryProduct cp ON p.CategoryProductId=cp.Id
	Where p.CategoryProductId=@idCategory
RETURN 0
