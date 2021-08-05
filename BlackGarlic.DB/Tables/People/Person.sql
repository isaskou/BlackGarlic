CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL IDENTITY,
	[FirstName] nvarchar(50),
	[LastName] nvarchar(50),
	[Email] nvarchar(255) UNIQUE,
	[Password] varbinary(32),
	Salt char(36),
	AdressId int NULL,
	[RoleId] int NOT NULL,
	
	CONSTRAINT PK_Id PRIMARY KEY (Id),

	CONSTRAINT FK_Person_Adress
		FOREIGN KEY (AdressId)
		REFERENCES Adress(Id),

	CONSTRAINT FK_Person_Role
		FOREIGN KEY (RoleId)
		REFERENCES Role(Id),

	CONSTRAINT CK_Person_Email
		CHECK (Email LIKE '%@%.%')


)
