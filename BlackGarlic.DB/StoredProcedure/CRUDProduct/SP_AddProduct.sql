CREATE PROCEDURE [dbo].[SP_AddProduct]
	@Name nvarchar(255),
	@Description nvarchar(max) ,
	@IsDisabled Bit , 
	@UnitPrice decimal(6,2) ,
	@CategoryProductId int ,
	@ProviderId int ,
	@PictureUrl nvarchar(255)
AS
BEGIN
	INSERT INTO Product(
			[Name],
			[Description],
			[IsDisabled],
			[UnitPrice],
			[CategoryProductId],
			[ProviderId],
			[PictureUrl])
		OUTPUT inserted.Id
		VALUES(
			@Name, @Description,@IsDisabled,
			@UnitPrice, @CategoryProductId,
			@ProviderId, @PictureUrl)
END

