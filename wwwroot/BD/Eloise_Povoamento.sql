INSERT INTO [Tipo] (tipo_desc)
    VALUES ('admin'),
	 		('user'),
			('Sobremesa'),
			('Sopa'),
			('Prato'),
			('Salada')
GO

INSERT INTO [dbo].[Dificuldade]
           ([dif_desc])
     VALUES
           ('Fácil'),
		   ('Normal'),
		   ('Difícil'),
		   ('Gordon Ramsay')
GO

INSERT INTO [Regime] (regime_desc)
    VALUES ('sem regime'),
			('Vegetariano')

INSERT INTO [dbo].[Ingrediente]
           ([id],[descricao])
     VALUES(1,'Farinha'),
           (2,'Ovos'),
           (3,'Leite'),
           (2,'Cenoura')
GO

INSERT INTO [dbo].[ValorNutricional]
           ([id]
           ,[Kcal]
           ,[Prot]
           ,[Carb]
           ,[Fat])
     VALUES
           (1
           ,259.0
           ,6.80
           ,6.86
           ,24.42)
GO


INSERT INTO [User] (nome, email, password, regime, tipo)
    VALUES ('ze', 'ze@ze.com', 'a', 'sem regime', 'admin')

INSERT INTO [User] (nome, email, password, regime, tipo)
    VALUES ('Pedro', 'pedro@pedro.com', 'p', 'nenhum', 'admin')

INSERT INTO [dbo].[Receita]
           ([id]
           ,[descricao]
           ,[regime]
           ,[tipo]
           ,[dificuldade]
           ,[tempo]
           ,[valor]
           ,[dose]
           ,[classificacao]
           ,[imagem])
     VALUES
           (1
           ,'Bolo de Cenoura'
           ,'Vegetariano'
           ,'Sobremesa'
           ,'Fácil'
           ,'01:00:00'
           ,1
           ,8
           ,5.0
           ,'bolocenoura.png')
GO


INSERT INTO [dbo].[Passo]
           ([receitaid]
           ,[ingredienteid]
           ,[quantidade]
           ,[tecnica]
           ,[numero])
     VALUES
           (1
           ,1
           ,'250 gr.'
           ,'Colocar 250gr. de farinha num recipiente'
           ,1),
		   (1
           ,2
           ,'4'
           ,'Partir 4 ovos'
           ,2)
GO


INSERT INTO [dbo].[IngredienteReceita]
           ([ingredienteid]
           ,[receitaid]
           ,[quantidade])
     VALUES
           (1,1,'250 gr.'),
		   (2,1,'4')
GO






select * from [Tipo]
select * from [Regime]
select * from [User]