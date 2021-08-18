CREATE PROCEDURE [dbo].[SP_GetCustomerByPersonName]
	@PersonLastName nvarchar(50)
AS
		SELECT p.FirstName, p.LastName, p.Email, c.CompanyName, c.Phone
		FROM Person p
		Join Customer c ON p.Id = c.PersonId
		Where p.LastName = @PersonLastName
RETURN 0
