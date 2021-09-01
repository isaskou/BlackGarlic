CREATE PROCEDURE [dbo].[SP_GetCustomerByLastName]
	@ln nvarchar(50)
AS
		SELECT *
		FROM Customer
		Where LastName = @ln
RETURN 0
