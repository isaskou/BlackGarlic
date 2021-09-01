CREATE TABLE [dbo].[Command]
(
	[Id] INT NOT NULL IDENTITY,
	DateOfCommand datetime NOT NULL,
	CustomerId INT NOT NULL,
	CustomerAdressId INT NOT NULL,

	CONSTRAINT PK_Command PRIMARY KEY (Id),

	CONSTRAINT FK_Customer_Command
		FOREIGN KEY (CustomerId)
		REFERENCES Customer(Id),

	CONSTRAINT FK_CustomerAdress_Command
		FOREIGN KEY (CustomerAdressId)
		REFERENCES CustomersAdresses(Id)
)
