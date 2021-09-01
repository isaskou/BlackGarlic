CREATE PROCEDURE [dbo].[GetAllCommandProductByCommandId]
	@CommandId int
AS
	BEGIN
		SELECT Id, CommandId, ProductId, Quantity 
		FROM CommandProduct
		WHERE CommandId=@CommandId
	END
