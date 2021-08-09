CREATE PROCEDURE [dbo].[SP_GetAllProductFromCategoryProduct]
	@categoryName nvarchar(255)
AS
	SELECT p.Name, p.Description, p.PictureUrl, p.UnitPrice, p.IsDisabled, cp.Name
	FROM Product p
		JOIN CategoryProduct cp ON p.CategoryProductId=cp.Id
	Where cp.Name=@categoryName
RETURN 0
