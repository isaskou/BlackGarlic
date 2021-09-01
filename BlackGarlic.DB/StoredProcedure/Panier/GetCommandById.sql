CREATE PROCEDURE [dbo].[GetCommandById]
	@CommandId INT
AS
	BEGIN 
		SELECT Id, DateOfCommand, CustomerId, CustomerAdressId
		FROM Command
		Where Id=@CommandId
	END
