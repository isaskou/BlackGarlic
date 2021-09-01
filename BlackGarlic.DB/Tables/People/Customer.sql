CREATE TABLE [dbo].[Customer]
(
	[Id] INT NOT NULL Identity,
	[FirstName] nvarchar(50),
	[LastName] nvarchar(50),
	CompanyName nvarchar(255) NULL,
	Phone nvarchar(10) NULL,
	[Email] nvarchar(255) UNIQUE NOT NULL,
	[Password] NVARCHAR(50) NOT NULL,
	Salt NVARCHAR(8),
	[RoleId] int NOT NULL


	CONSTRAINT PK_CustomerId PRIMARY KEY (Id),

	CONSTRAINT FK_Customer_Role
		FOREIGN KEY (RoleId)
		REFERENCES Role(Id),

		CONSTRAINT CK_Customer_Email
		CHECK (Email LIKE '%@%.%')

)
