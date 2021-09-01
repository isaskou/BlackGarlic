CREATE PROCEDURE [dbo].[SP_GetCustomerByMailAndPasswordMatch]
	@email NVARCHAR(50),
	@password NVARCHAR(MAX)
AS
BEGIN
	SELECT *
	FROM Customer
	WHERE [Password] = HASHBYTES('SHA2_512',Salt + @password) AND Email = @email

END
GO