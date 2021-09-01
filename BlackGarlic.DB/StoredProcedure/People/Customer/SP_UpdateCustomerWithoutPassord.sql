CREATE PROCEDURE [dbo].[SP_UpdateCustomerWithoutPassord]
	@customerId INT,
	@fn NVARCHAR(50),
	@ln NVARCHAR(50),
	@company nvarchar(255),
	@Email NVARCHAR(50),
	@Phone NVARCHAR(10)
AS
	BEGIN
		UPDATE Customer
		SET FirstName=@fn, LastName=@ln, CompanyName=@company, Email=@Email, Phone=@Phone
		WHERE Id=@customerId
	END
