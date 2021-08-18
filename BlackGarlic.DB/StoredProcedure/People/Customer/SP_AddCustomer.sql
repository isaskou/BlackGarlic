CREATE PROCEDURE [dbo].[SP_AddCustomer]
	@CompanyName nvarchar(255),
	@PersonId int, 
	@Phone int
AS
	BEGIN
		INSERT INTO Customer(
			[CompanyName], [PersonId], [Phone]
		)
		OUTPUT inserted.Id
		VALUES(
			@CompanyName, @PersonId, @Phone
		)
	END
