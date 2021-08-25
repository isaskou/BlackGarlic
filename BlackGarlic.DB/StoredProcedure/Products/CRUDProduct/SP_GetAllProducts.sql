CREATE PROCEDURE [dbo].[SP_GetAllProducts]
AS
	SELECT p.*
	FROM Product p
	JOIN CategoryProduct cp ON p.CategoryProductId=cp.Id
RETURN 0