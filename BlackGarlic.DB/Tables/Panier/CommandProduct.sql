CREATE TABLE [dbo].CommandProduct
(
	[Id] INT NOT NULL IDENTITY,
	Quantity INT NOT NULL DEFAULT 0,
	ProductId INT NOT NULL,
	CommandId INT NOT NULL

	CONSTRAINT PK_CommandProduct PRIMARY KEY (Id),

	CONSTRAINT FK_Product_CommandProduct
		FOREIGN KEY (ProductId) 
		REFERENCES Product(Id),

	CONSTRAINT FK_Command_CommandProduct
		FOREIGN KEY (CommandId)
		REFERENCES Command(Id),

	CONSTRAINT CK_QuantityUpToZero
		CHECK (Quantity>=0)
)
