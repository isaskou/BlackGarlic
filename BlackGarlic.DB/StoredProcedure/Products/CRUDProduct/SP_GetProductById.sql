CREATE PROCEDURE [dbo].[SP_GetProductById]
	@productId int
AS
	SELECT *
	FROM Product
	WHERE Id=@productId
RETURN 0
