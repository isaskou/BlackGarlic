CREATE PROCEDURE [dbo].[SP_GetAllCustomersWithAdress]
AS
	BEGIN
		SELECT p.FirstName, p.LastName, p.Email, c.CompanyName, a.Street, a.Num, a.PostalCode, a.City, a.District
		FROM Customer c
		Join Person p ON p.Id = c.PersonId
		JOIN CustomersAdresses ca on ca.CustomerId=c.Id
		JOIN Adress a ON ca.AdressId=a.Id
	END
