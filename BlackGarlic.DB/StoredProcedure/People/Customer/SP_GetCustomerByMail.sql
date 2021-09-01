CREATE PROCEDURE [dbo].[SP_GetCustomerByMail]
	@Email nvarchar(255)
AS
		SELECT *
		FROM Customer
		Where Email = @Email
RETURN 0
