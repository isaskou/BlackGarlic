CREATE PROCEDURE [dbo].[SP_UpdateCustomerAdress]
	@CustomerAdressId int,
	@CustomerId int, 
	@AdressId int
AS
	BEGIN
		UPDATE CustomersAdresses
		SET CustomerId=@CustomerId, AdressId=@AdressId
		WHERE Id=@CustomerAdressId
	END
