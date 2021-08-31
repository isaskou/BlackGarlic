CREATE TABLE [dbo].[Caddie]
(
	[Id] INT NOT NULL IDENTITY,
	OrderDate datetime NOT NULL DEFAULT GETDATE(),
	CustomerId int NOT NULL,
	ShipAmountId int NOT NULL ,

	CONSTRAINT PK_CaddieId PRIMARY KEY (Id),

	CONSTRAINT FK_Caddie_ShipAmount 
		FOREIGN KEY (ShipAmountId)
		REFERENCES ShipAmount(Id),
	
	CONSTRAINT FK_Caddie_Customer
		FOREIGN KEY (CustomerId)
		References Customer(Id)

)
