CREATE PROCEDURE [dbo].[SP_GetAdressByCustomerAdressId]
	@CustomerAdressId int
AS
BEGIN
	SELECT a.*, ca.*
	FROM Adress a
	JOIN CustomersAdresses ca ON ca.AdressId=a.Id
	WHERE ca.CustomerId = @CustomerAdressId
END
