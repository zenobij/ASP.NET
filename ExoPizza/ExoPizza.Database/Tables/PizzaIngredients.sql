CREATE TABLE [dbo].[PizzaIngredients]
(
	[PizzaId] INT NOT NULL, 
    [IngredientId] INT NOT NULL, 
    [Quantite] INT NOT NULL, 
    CONSTRAINT [PK_PizzaIngredients] PRIMARY KEY ([IngredientId], [PizzaId]), 
    CONSTRAINT [FK_PizzaIngredients_Pizza] FOREIGN KEY (PizzaId) REFERENCES Pizza(PizzaId), 
    CONSTRAINT [FK_PizzaIngredients_Ingredient] FOREIGN KEY (IngredientId) REFERENCES Ingredient(IngredientId) 
)
