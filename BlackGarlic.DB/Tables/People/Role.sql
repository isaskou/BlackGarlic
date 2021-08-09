CREATE TABLE [dbo].[Role]
(
	[Id] INT NOT NULL Identity,
	[Name] nvarchar(10) NOT NULL, 
	
	CONSTRAINT PK_RoleId PRIMARY KEY (Id), 

	CONSTRAINT CK_RoleName 
		CHECK (Name IN('Admin', 'Client', 'Assistant', 'Com'))
)
