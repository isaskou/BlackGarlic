/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
--:r .\Script.AddDefaultCategoryProduct.sql

--:r .\Script.AddDefaultProduct.sql

--:r .\Script.AddDefaultRoles.sql

--EXEC SP_AddCategoryProduct
--    @Name='apéritif',
--    @Description='on y retrouve des tapenades, des humus, des crèmes, etc.'
    
--GO

--EXEC SP_AddProduct
--	@Name = 'Tapenade olives et ail noir', 
--    @Description = null,
--	@IsDisabled = 0,
--	@UnitPrice = 9.99, 
--	@CategoryProductId=1,
--	@PictureUrl =null
--GO

INSERT INTO dbo.Role
VALUES
    ('Admin'), 
    ('Client'),
    ('Assistant'),
    ('Com')
GO

EXEC SP_InsertPerson
    @FirstName = 'Isabel',
	@LastName ='Skou',
	@Email ='isa@mail.be',
	@Password ='test',
	@RoleId =1
GO
EXEC SP_InsertPerson
    @FirstName = 'Antoine',
	@LastName ='Isembaert',
	@Email ='antoine@mail.be',
	@Password ='test',
	@RoleId =2
GO

INSERT INTO ShipAmount
    VALUES 
        ('Bruxelles', 2.99),
        ('Brabant-Wallon', 1.99),
        ('Namur', 0.99),
        ('Liège', 1.99),
        ('Luxembourg', 2.99),
        ('Hainaut', 2.99)
GO

INSERT INTO TVAAmount
    VALUES
        (0.06),
        (0.12),
        (0.21)
GO

EXEC SP_AddCustomer
    @CompanyName = 'AZEMBAERT',
    @PersonId = 2,
    @Phone='0489254252'
GO

EXEC SP_AddAdress
    @Street='Rue Vanderkindere', 
    @Num='536', 
    @PostalCode=1180,
    @City='Uccle', 
    @District='Bruxelles'
GO

EXEC SP_AddCustomerAdress
    @CustomerId=1,
    @AdressId=1
GO


    