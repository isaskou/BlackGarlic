CREATE PROCEDURE [dbo].[InsertCommand]
	@DateOfCommand DATE,
	@CustomerId INT, 
	@CustomerAdressId INT
AS
	BEGIN
		INSERT INTO Command(DateOfCommand, CustomerId, CustomerAdressId)
		OUTPUT inserted.Id
		VALUES (@DateOfCommand, @CustomerId, (
					SELECT Id 
					FROM CustomersAdresses 
					WHERE Id=@CustomerAdressId AND CustomerId=@CustomerId))
	END
