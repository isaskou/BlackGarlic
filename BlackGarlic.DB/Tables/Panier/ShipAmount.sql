CREATE TABLE [dbo].[ShipAmount]
(
	[Id] INT NOT NULL IDENTITY,
	District nvarchar(25) NOT NULL,
	Amount decimal(4,2) NOT NULL,
	
	
	CONSTRAINT PK_ShipAmountId PRIMARY KEY (Id),
)
