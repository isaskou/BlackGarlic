CREATE TABLE [dbo].[CustomersAdresses]
(
	[Id] INT NOT NULL IDENTITY,
	CustomerId INT NOT NULL,
	AdressId INT NOT NULL,

	CONSTRAINT PK_CustomersAdressesId PRIMARY KEY (Id),
	CONSTRAINT FK_CustomersAdresses_CustomerId
		FOREIGN KEY (CustomerId)
		REFERENCES Customer(Id),
	CONSTRAINT FK_CustomersAdresses_AdressId
		FOREIGN KEY (AdressId)
		REFERENCES Adress(Id)
)
