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
	@CategoryProductId=1,
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
	@CategoryProductId=1,
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
	@CategoryProductId=4,
	@PictureUrl ='https://www.letuverie.com/wp-content/uploads/2020/11/LETUVERIE-biere-BG2-600x400.jpg'
GO

EXEC SP_AddProduct
	@Name = 'Miel à l’ail noir bio
', 
  @Description = 'Miel à l’ail noir certifié bio, prêt à l’emploi.',
  @Utilisation = 'Un mélange subtil de miel bio français et d’ail noir bio gersois pour allier les bienfaits et les qualités nutritionnelles de deux supers aliments.
Le miel à l’ail noir est idéal pour vos préparations aussi bien salées que sucrées.
Le goût sucré et délicat de l’ail noir et la douceur du miel en font un ingrédient idéal pour de nombreux plats, marinades, vinaigrettes ou simplement en toast.
Parfait pour laquer vos viandes et poissons, accompagner vos fromages, vos salades, il sera également délicieux dans de nombreux desserts : crêpes, cakes, madeleines, pain d’épice…

L’association de ce miel biologique spécialement sélectionné et de notre ail noir bio, surprendra et ravira vos papilles.',
@Ingredients = 'Miel français issu de l’agriculture biologique (AB) 80%, Ail Noir issu de l’agriculture biologique (AB) du Gers 20%',
	@IsDisabled = 0,
	@UnitPrice = 10.80, 
	@CategoryProductId=2,
	@PictureUrl ='https://www.letuverie.com/wp-content/uploads/2020/04/Miel-ail-noir.png
'
GO

EXEC SP_AddProduct
	@Name = 'Coffret découverte L’Ail Noir', 
  @Description = 'Coffret dégustation ail noir comprenant une tête entière, de la pâte et du miel à l’ail noir bio AB.',
  @Utilisation = 'Tous les bienfaits et plaisirs de l’ail noir réunis dans un coffret découverte, pour déguster ou faire déguster l’ail noir bio, ses vertus naturelles et ses nombreuses utilisations en cuisine.

Vous trouverez dans votre coffret découverte Ail Noir en toile de jute L’étuverie :

– Notre tête entière d’ail noir bio en écrin (+/- 50g): le produit brut pour une utilisation à votre convenance. En dés, en lamelles, mixé, infusé… nos gousses d’ail noir sauront agrémenter vos plats salés et sucrés mais vous pourrez également les consommer directement comme un bonbon.

– Notre pâte d’ail noir bio (60g) pour une utilisation plus simple et rapide. La pâte d’ail noir bio est parfaite pour une infusion rapide, elle peut aussi être simplement étalée sur une tartine beurrée (Tapas) ou incorporée dans vos sauces.

– Notre miel à l’ail noir bio (250g), produit de grande douceur au goût subtil. Ce miel est idéal pour vos vinaigrettes, pour laquer vos viandes et grillades ou encore dans vos gâteaux.',
@Ingredients = '',
	@IsDisabled = 0,
	@UnitPrice = 27.40, 
	@CategoryProductId=5,
	@PictureUrl ='https://www.letuverie.com/wp-content/uploads/2020/06/Coffret-1-600x400.jpg'
GO

EXEC SP_AddProduct
	@Name = 'Ail noir en pâte bio', 
  @Description = 'Pâte d’ail noir bio prête à l’emploi.',
  @Utilisation = 'Notre pâte d’ail noir peut être consommée nature sur des toasts ou dans des préparations.
L’ail noir s’associe avec tous les types de viande, la charcuterie, le foie gras, les poissons fins (sole, lotte, bar) et les crustacés.
Pour les amateurs de sucré, il est idéal pour accompagner le chocolat et les agrumes.',
@Ingredients = 'Ail Noir biologique du Gers 90%, Huile de Tournesol Bio du Gers 10%',
	@IsDisabled = 0,
	@UnitPrice = 10.20, 
	@CategoryProductId=2,
	@PictureUrl ='https://www.letuverie.com/wp-content/uploads/2019/10/DSC1608-Modifier-600x399.jpg'
GO

EXEC SP_AddProduct
	@Name = 'Moutarde à l’ail noir bio', 
  @Description = 'Moutarde à l”ail noir bio prête à l’emploi.',
  @Utilisation = 'Notre moutarde à l’ail noir bio accompagnera vos viandes, légumes ou vinaigrette.
Elle sera également idéale pour vos marinades.
Une moutarde de caractère, fine et forte avec son beau parfum d’ail noir.',
@Ingredients = 'Moutarde française biologique 90%, Ail Noir biologique du Gers 10%',
	@IsDisabled = 0,
	@UnitPrice = 7.00, 
	@CategoryProductId=3,
	@PictureUrl ='https://www.letuverie.com/wp-content/uploads/2021/08/IMG_1284-2-1-600x740.jpg'
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


    