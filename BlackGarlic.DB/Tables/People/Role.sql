CREATE TABLE [dbo].[Role]
(
	[Id] INT NOT NULL Identity,
	[Name] nvarchar(10) NOT NULL CHECK (Name IN('Admin', 'Client', 'Assistant', 'Com')), 
	
	CONSTRAINT PK_RoleId PRIMARY KEY (Id)
)
