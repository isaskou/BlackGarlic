CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL Identity,
	[PersonId] INT,

	CONSTRAINT PK_ClientId PRIMARY KEY (Id),

	CONSTRAINT FK_Client_Person
		FOREIGN KEY (PersonId)
		REFERENCES Person(Id)
)
