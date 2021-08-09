CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL IDENTITY,
	[Name] nvarchar(255)NOT NULL,
	[Description] nvarchar(max) NULL,
	[IsDisabled] Bit NOT NULL DEFAULT 0, 
	[UnitPrice] decimal(6,2) NOT NULL,
	[CategoryProductId] int NOT NULL,
	[ProviderId] int NULL,
	[PictureUrl] nvarchar(255),


    CONSTRAINT PK_ProductId PRIMARY KEY (Id),

	CONSTRAINT FK_Product_CategoryProduct
		FOREIGN KEY (CategoryProductId)
		REFERENCES CategoryProduct(Id),

	CONSTRAINT FK_Product_Provider
		FOREIGN KEY (ProviderId)
		REFERENCES [Provider](Id)
)
