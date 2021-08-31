CREATE TABLE [dbo].[CaddieLine]
(
	[Id] INT NOT NULL IDENTITY,
	ProductId int NOT NULL,
	Quantity int NOT NULL DEFAULT 0, 
	CaddieId int NOT NULL,

	CONSTRAINT PK_CaddiLineId PRIMARY KEY (Id),

	CONSTRAINT FK_CaddieLine_Caddie 
		FOREIGN KEY (CaddieId)
		references Caddie(Id),

	CONSTRAINT FK_CaddieLine_Product
		FOREIGN KEY (ProductId)
		references Product(Id),

	CONSTRAINT CK_QuantityUpToZero
		CHECK (Quantity>=0)

)
