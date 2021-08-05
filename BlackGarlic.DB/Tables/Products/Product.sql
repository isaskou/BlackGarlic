﻿CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL IDENTITY,
	[Name] nvarchar(255)NOT NULL,
	[Description] nvarchar(max) NULL,
	[IsDisabled] Bit NOT NULL DEFAULT 0, 
	[Price] decimal(6,2) NOT NULL,
	[TypeProductId] int NOT NULL,
	[ProviderId] int NULL,


    CONSTRAINT PK_ProductId PRIMARY KEY (Id),

	CONSTRAINT FK_Product_TypeProduct
		FOREIGN KEY (TypeProductId)
		REFERENCES TypeProduct(Id),

	CONSTRAINT FK_Product_Provider
		FOREIGN KEY (ProviderId)
		REFERENCES [Provider](Id)
)
