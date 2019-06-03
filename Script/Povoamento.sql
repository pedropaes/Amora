
DELETE FROM Eloise.dbo.Alergenio;
DELETE FROM Eloise.dbo.IngredienteAlergenio;
DELETE FROM Eloise.dbo.IngredienteReceita;
DELETE FROM Eloise.dbo.Receita;
DELETE FROM Eloise.dbo.Dificuldade;
DELETE FROM Eloise.dbo.Ingrediente;
DELETE FROM Eloise.dbo.Passo;
DELETE FROM Eloise.dbo.Regime;
DELETE FROM Eloise.dbo.Tipo;
DELETE FROM Eloise.dbo.ValorNutricional;
DELETE FROM Eloise.dbo.[User];

--Povoamento Alergenio
BULK INSERT Eloise.dbo.Alergenio FROM 'C:\Users\Pedro\Desktop\Script\Alergenio.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Eloise.dbo.Alergenio;
--Povoamento Dificuldade

BULK INSERT Eloise.dbo.Dificuldade FROM 'C:\Users\Pedro\Desktop\Script\Dificuldade.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Eloise.dbo.Dificuldade;

--Povoamento Ingredientes
BULK INSERT Eloise.dbo.Ingrediente FROM 'C:\Users\Pedro\Desktop\Script\Ingredientes.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Eloise.dbo.Ingrediente;

--Povoamento IngredientesAlergenio
BULK INSERT Eloise.dbo.[IngredienteAlergenio] FROM 'C:\Users\Pedro\Desktop\Script\IngredientesAlergenio.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Eloise.dbo.[IngredienteAlergenio];

--Povoamento IngredientesReceita
BULK INSERT Eloise.dbo.IngredienteReceita FROM 'C:\Users\Pedro\Desktop\Script\IngredientesReceita.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Eloise.dbo.IngredienteReceita;

--Povoamento Passo
BULK INSERT Eloise.dbo.Passo FROM 'C:\Users\Pedro\source\repos\Eloise\Script\Passos.csv'
	WITH (
		ROWTERMINATOR = '|',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Eloise.dbo.Passo;


--Povoamento Receita
BULK INSERT Eloise.dbo.Receita FROM 'C:\Users\Pedro\Desktop\Script\Receita.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Eloise.dbo.Receita;

--Povoamento Regime
BULK INSERT Eloise.dbo.Regime FROM 'C:\Users\Pedro\Desktop\Script\Regime.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Eloise.dbo.Regime;

--Povoamento Tipo
BULK INSERT Eloise.dbo.Tipo FROM 'C:\Users\Pedro\Desktop\Script\Tipo.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Eloise.dbo.Tipo;

--Povoamento ValorNutricional
BULK INSERT Eloise.dbo.ValorNutricional FROM 'C:\Users\Pedro\Desktop\Script\ValorNutricional.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Eloise.dbo.ValorNutricional;

--Povoamento User
BULK INSERT Eloise.dbo.[User] FROM 'C:\Users\Pedro\Desktop\Script\User.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Eloise.dbo.[User];
