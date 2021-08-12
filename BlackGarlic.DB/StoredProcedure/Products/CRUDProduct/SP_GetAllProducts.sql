CREATE PROCEDURE [dbo].[SP_GetAllProducts]
AS
	SELECT p.Id, p.Name, p.Description, p.UnitPrice, p.PictureUrl, p.CategoryProductId, cp.Name, p.IsDisabled
	FROM Product p
	JOIN CategoryProduct cp ON p.CategoryProductId=cp.Id
RETURN 0