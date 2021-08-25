CREATE PROCEDURE [dbo].[SP_AddProduct]
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
	INSERT INTO Product(
			[Name],
			[Description],
			[Utilisation],
			[Ingredients],
			[IsDisabled],
			[UnitPrice],
			[CategoryProductId],
			[PictureUrl])
		OUTPUT inserted.Id
		VALUES(
			@Name, @Description,@Utilisation,@Ingredients, @IsDisabled,
			@UnitPrice, @CategoryProductId,
			 @PictureUrl)
END

