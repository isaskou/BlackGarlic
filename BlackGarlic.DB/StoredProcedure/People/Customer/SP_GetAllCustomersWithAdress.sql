CREATE PROCEDURE [dbo].[SP_GetAllCustomersWithAdress]
AS
		SELECT c.*, a.*
		FROM Customer c
		JOIN CustomersAdresses ca on ca.CustomerId=c.Id
		JOIN Adress a ON ca.AdressId=a.Id

RETURN 0