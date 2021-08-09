CREATE TABLE [dbo].[CaddieLine]
(
	[Id] INT NOT NULL IDENTITY,
	ProductId int NOT NULL,
	Quantity int NOT NULL, 
	TVAAmountId int NOT NULL,
	SubTotal decimal(5,2) NOT NULL,
	CaddieId int NOT NULL,

	CONSTRAINT PK_CaddiLineId PRIMARY KEY (Id),

	CONSTRAINT FK_CaddieLine_Caddie 
		FOREIGN KEY (CaddieId)
		references Caddie(Id),

	CONSTRAINT FK_CaddieLine_Product
		FOREIGN KEY (ProductId)
		references Product(Id),

	CONSTRAINT FK_CaddieLine_TVAAmount
		FOREIGN KEY (TVAAmountId)
		references TVAAmount(Id)
)
