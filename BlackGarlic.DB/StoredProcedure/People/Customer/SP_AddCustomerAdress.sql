CREATE PROCEDURE [dbo].[SP_AddCustomerAdress]
	@CustomerId int, 
	@AdressId int

AS
	BEGIN
		INSERT INTO CustomersAdresses(
			[CustomerId], [AdressId]
		)
		OUTPUT inserted.Id
		VALUES(
			@CustomerId, @AdressId
		)
	END