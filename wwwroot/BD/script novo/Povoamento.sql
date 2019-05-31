
--Povoamento Alergenio
DELETE FROM Alergenio;
BULK INSERT dbo.Alergenio FROM 'C:\Users\Pedro\Desktop\Script\Alergenio.csv' 
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Alergenio;

--Povoamento Dificuldade
DELETE FROM Dificuldade;
BULK INSERT dbo.Dificuldade FROM 'C:\Users\Pedro\Desktop\Script\Dificuldade.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Dificuldade;

--Povoamento Ingredientes
DELETE FROM Ingrediente;
BULK INSERT dbo.Ingrediente FROM 'C:\Users\Pedro\Desktop\Script\Ingredientes.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Ingrediente;

--Povoamento IngredientesAlergenio
DELETE FROM IngredienteAlergenio;
BULK INSERT dbo.IngredienteAlergenio FROM 'C:\Users\Pedro\Desktop\Script\IngredientesAlergenio.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM IngredienteAlergenio;

--Povoamento IngredientesReceita
DELETE FROM IngredienteReceita;
BULK INSERT dbo.IngredienteReceita FROM 'C:\Users\Pedro\Desktop\Script\IngredientesReceita.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM IngredienteReceita;

--Povoamento Passo
DELETE FROM Passo;
BULK INSERT dbo.Passo FROM 'C:\Users\Pedro\Desktop\Script\Passos.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Passo;

--Povoamento Receita
DELETE FROM Receita;
BULK INSERT dbo.Receita FROM 'C:\Users\Pedro\Desktop\Script\Receita.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Receita;

--Povoamento Regime
DELETE FROM Regime;
BULK INSERT dbo.Regime FROM 'C:\Users\Pedro\Desktop\Script\Regime.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Regime;

--Povoamento Tipo
DELETE FROM Tipo;
BULK INSERT dbo.Tipo FROM 'C:\Users\Pedro\Desktop\Script\Tipo.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM Tipo;

--Povoamento ValorNutricional
DELETE FROM ValorNutricional;
BULK INSERT dbo.ValorNutricional FROM 'C:\Users\Pedro\Desktop\Script\ValorNutricional.csv'
	WITH (
		ROWTERMINATOR = '\n',
		FIELDTERMINATOR = ';',
		CODEPAGE = 'ACP',
		KEEPIDENTITY
	);

SELECT * FROM ValorNutricional;
