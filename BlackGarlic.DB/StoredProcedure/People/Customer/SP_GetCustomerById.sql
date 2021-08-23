CREATE PROCEDURE [dbo].[SP_GetCustomerById]
	@CustomerId int
AS
		SELECT c.*
		FROM Customer c
		WHERE c.Id = @CustomerId

RETURN 0
