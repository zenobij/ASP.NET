﻿CREATE TABLE [dbo].[Pizza]
(
	[PizzaId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Code] NVARCHAR(5) NOT NULL, 
    [Prix] FLOAT NULL
)
