CREATE PROCEDURE [dbo].[SP_GetCustomerByMail]
	@Email nvarchar(255)
AS
		SELECT p.FirstName, p.LastName, p.Email, c.CompanyName, c.Phone
		FROM Person p
		Join Customer c ON p.Id = c.PersonId
		Where p.Email = @Email
RETURN 0
