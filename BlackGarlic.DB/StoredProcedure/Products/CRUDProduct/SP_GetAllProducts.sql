CREATE PROCEDURE [dbo].[SP_GetAllProducts]
AS
	SELECT p.*
	FROM Product p
RETURN 0