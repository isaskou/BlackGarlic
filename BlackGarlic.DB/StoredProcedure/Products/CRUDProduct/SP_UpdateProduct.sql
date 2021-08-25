CREATE PROCEDURE [dbo].[SP_UpdateProduct]
	@ProductId int,
	@Name nvarchar(255),
	@Description nvarchar(max) ,
	@Utilisation nvarchar(max),
	@Ingredients nvarchar(255),
	@IsDisabled Bit , 
	@UnitPrice decimal(6,2) ,
	@CategoryProductId int ,
	@PictureUrl nvarchar(255)
AS
BEGIN
	UPDATE dbo.Product
	SET [Name]=@Name, [Description]=@Description, [Utilisation]=@Utilisation, [Ingredients]=@Ingredients,
	IsDisabled=@IsDisabled, UnitPrice=@UnitPrice,
	CategoryProductId=@CategoryProductId, 
	PictureUrl=@PictureUrl
	WHERE Id=@ProductId
END
