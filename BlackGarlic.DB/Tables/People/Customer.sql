CREATE TABLE [dbo].[Customer]
(
	[Id] INT NOT NULL Identity,
	CompanyName nvarchar(255) NULL,
	[PersonId] INT NOT NULL,
	Phone int NULL,

	CONSTRAINT PK_CustomerId PRIMARY KEY (Id),

	CONSTRAINT FK_Client_Person
		FOREIGN KEY (PersonId)
		REFERENCES Person(Id)
)
