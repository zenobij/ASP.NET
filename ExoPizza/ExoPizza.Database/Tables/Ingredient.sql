CREATE TABLE [dbo].[Ingredient]
(
	[IngredientId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [CategorieId] INT NOT NULL, 
    CONSTRAINT [FK_Ingredient_Categorie] FOREIGN KEY (CategorieId) REFERENCES Categorie(CategorieId)
)
