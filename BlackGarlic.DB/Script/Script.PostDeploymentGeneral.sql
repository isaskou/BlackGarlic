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

EXEC SP_AddCategoryProduct
    @Name='ProduitBase',
    @Description='Le produit nature'
GO

EXEC SP_AddCategoryProduct
    @Name='Tartinables',
    @Description='sucré ou salé, à mettre sur vos toasts'
    GO
EXEC SP_AddCategoryProduct
    @Name='Condiments',
    @Description='Pour accompagner et relever vos plats'
    GO
EXEC SP_AddCategoryProduct
    @Name='Boissons',
    @Description='A mettre dans un verre'
    GO
EXEC SP_AddCategoryProduct
    @Name='Coffrets',
    @Description='Faites plaisir'
    GO


EXEC SP_AddProduct
	@Name = 'Ail noir tête entière bio', 
  @Description = 'Tête d’ail noir bio entièrement produite et transformée dans le Gers (environ 50g).',
  @Utilisation = '"L’ail noir bio s’invite dans de nombreuses préparations, mais peut également être consommé nature.
En sauce, marinade, en purée ou en fines lamelles dans vos plats de pâtes. Il s’associe avec tous les types de viande, la charcuterie, le foie gras, les poissons fins (sole, lotte, bar) et les crustacés.
Pour les amateurs de sucré, il est idéal pour accompagner le chocolat et les agrumes."',
@Ingredients = 'Ail noir 100%',
	@IsDisabled = 0,
	@UnitPrice = 8.50, 
	@CategoryProductId=2,
	@PictureUrl ='https://www.letuverie.com/wp-content/uploads/2019/10/DSC1467-Modifier-600x903.jpg'
GO

EXEC SP_AddProduct
	@Name = 'Gousses d’ail noir bio', 
  @Description = 'Gousses d’ail noir prêtes à l’emploi, dégoussées et pelées.',
  @Utilisation = 'Gagnez du temps pour vos préparations à l’ail noir.
Notre ail noir en gousses s’invite dans de nombreuses préparations, il apportera une saveur unique à vos plats.
En sauce, marinade, en purée ou en fines lamelles dans vos plats de pâtes, l’ail noir s’associe avec tous les types de viande, la charcuterie, le foie gras, les poissons fins (sole, lotte, bar) et les crustacés. Également parfait pour accompagner le chocolat et les agrumes.',
@Ingredients = '100% Gousses d’Ail noir biologique du Gers.',
	@IsDisabled = 0,
	@UnitPrice = 12.60, 
	@CategoryProductId=2,
	@PictureUrl ='https://www.letuverie.com/wp-content/uploads/2019/10/DSC1490-Modifier-600x399.jpg'
GO

EXEC SP_AddProduct
	@Name = 'Bière à l’ail noir bio (x3)', 
  @Description = 'Pack de 3 bières à l’ail noir bio 100% gersoise',
  @Utilisation = 'Bière artisanale à l’ail noir bio, née de la rencontre d’un brasseur et d’un producteur d’ail noir. Un goût subtil et unique au parfum sucré d’ail noir.
Elle est refermentée en bouteille et n’est ni filtrée, ni pasteurisée. Elle ne contient aucun additif.
Nous sommes heureux de vous faire découvrir notre premier brassin, la recette évoluera au fil du temps et de vos commentaires.

Degré d’alcool : 6° Vol',
@Ingredients = 'Eau, malt d’orge*, sucre*, ail noir*, houblon*, levure.',
	@IsDisabled = 0,
	@UnitPrice = 12.50, 
	@CategoryProductId=5,
	@PictureUrl ='https://www.letuverie.com/wp-content/uploads/2020/11/LETUVERIE-biere-BG2-600x400.jpg'
GO


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


    