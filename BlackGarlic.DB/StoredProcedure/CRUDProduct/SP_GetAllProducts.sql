CREATE PROCEDURE [dbo].[SP_GetAllProducts]
AS
BEGIN
	SELECT p.Id, p.Name, p.Description, p.UnitPrice, p.PictureUrl, cp.Name
	FROM Product p
	JOIN CategoryProduct cp ON p.CategoryProductId=cp.Id
END
