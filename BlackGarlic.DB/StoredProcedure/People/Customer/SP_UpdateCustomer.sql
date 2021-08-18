CREATE PROCEDURE [dbo].[SP_UpdateCustomer]
	@CustomerId int, 
	@CompanyName nvarchar(255), 
	@Phone int null
AS
	BEGIN
		UPDATE Customer
		SET CompanyName=@CompanyName, Phone=@Phone
		WHERE Id=@CustomerId
	END
