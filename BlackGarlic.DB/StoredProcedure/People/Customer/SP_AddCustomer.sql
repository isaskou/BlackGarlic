CREATE PROCEDURE [dbo].[SP_AddCustomer]
	
	@fn NVARCHAR(50),
	@ln NVARCHAR(50),
	@company nvarchar(255),
	@Email NVARCHAR(50),
	@Pw NVARCHAR(50),
	@Phone NVARCHAR(10)
AS
BEGIN

	DECLARE @IdRole int
	SET @IdRole = (SELECT Id FROM [Role] WHERE Name = 'Client')
    INSERT INTO Customer
		(FirstName, LastName,CompanyName, Phone, Email,
		[Password], Salt, RoleId)
	OUTPUT inserted.Id
	VALUES(@fn, @ln, @company, @Phone, @Email, @Pw, '0000000', 2 )
END

