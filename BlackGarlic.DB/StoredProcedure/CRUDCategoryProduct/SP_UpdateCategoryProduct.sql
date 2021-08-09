CREATE PROCEDURE [dbo].[SP_UpdateCategoryProduct]
	@CategoryId int,
	@Name NVARCHAR(255),
	@Description NVARCHAR(Max)
AS
	BEGIN
		UPDATE CategoryProduct
		SET [Name]=@Name, [Description]=@Description
		WHERE Id=@CategoryId
	END
