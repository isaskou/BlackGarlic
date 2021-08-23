CREATE PROCEDURE [dbo].[SP_GetAllCustomersWithAdress]
AS
		SELECT p.*, c.*, a.*
		FROM Customer c
		Join Person p ON p.Id = c.PersonId
		JOIN CustomersAdresses ca on ca.CustomerId=c.Id
		JOIN Adress a ON ca.AdressId=a.Id

RETURN 0