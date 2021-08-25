CREATE PROCEDURE [dbo].[SP_AddAdress]
	@Street nvarchar(255),
	@Num nvarchar(50) ,
	@PostalCode int ,
	@City nvarchar(50) ,
	@District nvarchar(50) 
AS
	BEGIN
		INSERT INTO Adress(
			[Street], [Num],[PostalCode],[City], [District]
		)
		OUTPUT inserted.Id
		VALUES(
			@Street, @Num, @PostalCode, @City, @District
		)
			
	END
