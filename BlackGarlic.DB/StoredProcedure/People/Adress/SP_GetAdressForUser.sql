CREATE PROCEDURE [dbo].[SP_GetAdressForUser]
	@id int
AS
	BEGIN
		Select *
		FROM Adress a
		JOIN CustomersAdresses ca on a.Id = ca.AdressId AND ca.CustomerId=@id
	END
