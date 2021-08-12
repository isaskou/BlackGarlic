CREATE PROCEDURE [dbo].[SP_AddCategoryProduct]
	@Name NVARCHAR(255),
	@Description NVARCHAR(Max)
AS
BEGIN
	INSERT INTO [CategoryProduct]([Name], [Description])
	OUTPUT inserted.Id
	VALUES (@Name, @Description)
END