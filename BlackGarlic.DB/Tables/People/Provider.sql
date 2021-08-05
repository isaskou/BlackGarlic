CREATE TABLE [dbo].[Provider]
(
	[Id] INT NOT NULL IDENTITY,
	FirstName nvarchar(50) NULL,
	LastName nvarchar(50) NULL,
	Company nvarchar(50) NULL,
	PhoneNumber nvarchar(25) NULL,
	AdressId int NULL


	CONSTRAINT PK_ProviderId PRIMARY KEY (Id),

	CONSTRAINT FK_Provider_Adress
		Foreign key (AdressId)
		REFERENCES Adress(Id)
)
