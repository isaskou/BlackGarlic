CREATE PROCEDURE [dbo].[SP_GetCustomerById]
	@CustomerId int
AS
		SELECT p.FirstName, p.LastName, p.Email, c.CompanyName, c.Phone
		FROM Customer c
		Join Person p ON p.Id = c.PersonId
		WHERE c.Id = @CustomerId
RETURN 0
