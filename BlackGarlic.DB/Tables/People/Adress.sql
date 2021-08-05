CREATE TABLE [dbo].[Adress]
(
	[Id] INT NOT NULL IDENTITY,
	Street nvarchar(255),
	Num nvarchar(50) NULL,
	PostalCode int,
	City nvarchar(50), 

	CONSTRAINT PK_AdressId
		PRIMARY KEY (Id)
)
