CREATE PROCEDURE [dbo].[SP_UpdateCustomer]
	@customerId INT,
	@fn NVARCHAR(50),
	@ln NVARCHAR(50),
	@company nvarchar(255),
	@Email NVARCHAR(50),
	@Pw NVARCHAR(50),
	@Phone NVARCHAR(10)
AS
	BEGIN
		DECLARE @salt NVARCHAR(8)
		Set @salt = (SUBSTRING(CONVERT(NVARCHAR,RAND()),3,8))
		
		UPDATE Customer
		SET FirstName = @fn, LastName = @ln, CompanyName=@company, Email=@Email, 
		[Password] = HASHBYTES('SHA2_512',@salt + @Pw), Phone=@Phone, Salt = @salt
		WHERE Id=@CustomerId
	END
