CREATE PROCEDURE [dbo].[SP_GetAdressById]
	@id INT
AS
BEGIN
	SELECT *
	FROM Adress
	Where Id=@id
END
