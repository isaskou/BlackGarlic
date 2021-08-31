CREATE PROCEDURE [dbo].[InsertCaddieLine]
	@ProductId int,
	@Quantity int,
	@CaddieId int
AS
	BEGIN
		INSERT INTO CaddieLine(ProductId, Quantity, CaddieId)
		OUTPUT inserted.Id
		VALUES (@ProductId, @Quantity, @CaddieId )
	END
