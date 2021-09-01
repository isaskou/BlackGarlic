CREATE PROCEDURE [dbo].[InsertCommandProduct]
	@Quantity INT, 
	@ProductId INT,
	@CommandId INT
AS
	BEGIN
		INSERT INTO CommandProduct (Quantity, ProductId, CommandId)
		OUTPUT inserted.Id
		VALUES (@Quantity, @ProductId, @CommandId)
	END
