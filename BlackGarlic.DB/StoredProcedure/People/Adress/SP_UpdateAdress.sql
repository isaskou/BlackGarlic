CREATE PROCEDURE [dbo].[SP_UpdateAdress]
	@AdressId int,
	@Street nvarchar(255),
	@Num nvarchar(50) ,
	@PostalCode int ,
	@City nvarchar(50) ,
	@District nvarchar(50) 
AS
	BEGIN
		UPDATE Adress
		SET Street=@Street, Num=@Num, PostalCode=@PostalCode, City=@City, District=@District
		WHERE Id=@AdressId

	END
