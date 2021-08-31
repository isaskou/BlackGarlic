CREATE PROCEDURE [dbo].[GetProductsByCategoryId]
	@CategoryId INT
AS
	BEGIN
		SELECT *
		FROM Product
		WHERE CategoryProductId=@CategoryId
	END
	GO
