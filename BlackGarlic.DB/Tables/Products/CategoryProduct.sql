CREATE TABLE [dbo].[CategoryProduct]
(
	[Id] INT NOT NULL IDENTITY,
	[Name] nvarchar(255) NOT NULL,
	[Description] nvarchar(max) NULL,

	CONSTRAINT PK_CategoryProductId PRIMARY KEY (Id)
)
