USE [master]
GO
/****** Object:  Database [Eloise]    Script Date: 30/05/2019 17:38:37 ******/
CREATE DATABASE [Eloise]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Eloise', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Eloise.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Eloise_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Eloise_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Eloise] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Eloise].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Eloise] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Eloise] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Eloise] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Eloise] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Eloise] SET ARITHABORT OFF 
GO
ALTER DATABASE [Eloise] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Eloise] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Eloise] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Eloise] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Eloise] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Eloise] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Eloise] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Eloise] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Eloise] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Eloise] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Eloise] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Eloise] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Eloise] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Eloise] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Eloise] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Eloise] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Eloise] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Eloise] SET RECOVERY FULL 
GO
ALTER DATABASE [Eloise] SET  MULTI_USER 
GO
ALTER DATABASE [Eloise] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Eloise] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Eloise] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Eloise] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Eloise] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Eloise', N'ON'
GO
ALTER DATABASE [Eloise] SET QUERY_STORE = OFF
GO
USE [Eloise]
GO
/****** Object:  Table [dbo].[Alergenio]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alergenio](
	[id] [int] NOT NULL,
	[nome] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Alergeni__2A356105542C1015] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dificuldade]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dificuldade](
	[dif_desc] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Dificuld__69FE6FED1CF48B9D] PRIMARY KEY CLUSTERED 
(
	[dif_desc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Encomenda]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Encomenda](
	[id_Ingrediente] [int] NOT NULL,
	[id_Utilizador] [int] NOT NULL,
	[data] [date] NOT NULL,
	[valor] [float] NOT NULL,
	[quantidade] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Ingrediente] ASC,
	[id_Utilizador] ASC,
	[data] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Favoritos]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Favoritos](
	[id_Utilizador] [int] NOT NULL,
	[id_Receita] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Utilizador] ASC,
	[id_Receita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historico_Receitas]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historico_Receitas](
	[id_Utilizador] [int] NOT NULL,
	[id_Receita] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Utilizador] ASC,
	[id_Receita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingrediente]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingrediente](
	[id] [int] NOT NULL,
	[descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Ingredie__3213E83F132582A2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IngredienteAlergenio]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IngredienteAlergenio](
	[id_Alergenio] [int] NOT NULL,
	[id_Ingrediente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Alergenio] ASC,
	[id_Ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IngredienteReceita]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IngredienteReceita](
	[id_Ingrediente] [int] NOT NULL,
	[id_Receita] [int] NOT NULL,
	[quantidade] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Ingredie__EE149075C51F9B16] PRIMARY KEY CLUSTERED 
(
	[id_Ingrediente] ASC,
	[id_Receita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passo]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passo](
	[receitaid] [int] NOT NULL,
	[passo] [int] NOT NULL,
	[tecnica] [varchar](250) NULL,
 CONSTRAINT [PK__Passo__43231C9CC1E33D54] PRIMARY KEY CLUSTERED 
(
	[receitaid] ASC,
	[passo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planeamento]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planeamento](
	[id_Utilizador] [int] NOT NULL,
	[id_Receita] [int] NOT NULL,
	[data] [date] NOT NULL,
	[tipo_refeicao] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Planeame__63E7F40E56FFED40] PRIMARY KEY CLUSTERED 
(
	[id_Utilizador] ASC,
	[id_Receita] ASC,
	[data] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receita]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receita](
	[id] [int] NOT NULL,
	[descricao] [varchar](50) NOT NULL,
	[regime] [varchar](50) NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[dificuldade] [varchar](50) NOT NULL,
	[tempo] [time](7) NOT NULL,
	[valor] [int] NOT NULL,
	[dose] [int] NOT NULL,
	[classificacao] [float] NOT NULL,
	[imagem] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Receita__3213E83F4F40E2B9] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Regime]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regime](
	[regime_desc] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Regime__855ABD306AE190D9] PRIMARY KEY CLUSTERED 
(
	[regime_desc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo](
	[tipo_desc] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Tipo__0E48FBAEF4AD7D63] PRIMARY KEY CLUSTERED 
(
	[tipo_desc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[regime] [varchar](50) NOT NULL,
	[tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Utilizad__3213E83FF545AE66] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ValorNutricional]    Script Date: 30/05/2019 17:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ValorNutricional](
	[id] [int] NOT NULL,
	[Kcal] [float] NOT NULL,
	[Prot] [float] NOT NULL,
	[Carb] [float] NOT NULL,
	[Fat] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Encomenda]  WITH CHECK ADD  CONSTRAINT [FK_EN1] FOREIGN KEY([id_Ingrediente])
REFERENCES [dbo].[Ingrediente] ([id])
GO
ALTER TABLE [dbo].[Encomenda] CHECK CONSTRAINT [FK_EN1]
GO
ALTER TABLE [dbo].[Encomenda]  WITH CHECK ADD  CONSTRAINT [FK_EN2] FOREIGN KEY([id_Utilizador])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Encomenda] CHECK CONSTRAINT [FK_EN2]
GO
ALTER TABLE [dbo].[Favoritos]  WITH CHECK ADD  CONSTRAINT [FK_PRC1] FOREIGN KEY([id_Utilizador])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Favoritos] CHECK CONSTRAINT [FK_PRC1]
GO
ALTER TABLE [dbo].[Favoritos]  WITH CHECK ADD  CONSTRAINT [FK_PRC2] FOREIGN KEY([id_Receita])
REFERENCES [dbo].[Receita] ([id])
GO
ALTER TABLE [dbo].[Favoritos] CHECK CONSTRAINT [FK_PRC2]
GO
ALTER TABLE [dbo].[Historico_Receitas]  WITH CHECK ADD  CONSTRAINT [FK_HR1] FOREIGN KEY([id_Utilizador])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Historico_Receitas] CHECK CONSTRAINT [FK_HR1]
GO
ALTER TABLE [dbo].[Historico_Receitas]  WITH CHECK ADD  CONSTRAINT [FK_HR2] FOREIGN KEY([id_Receita])
REFERENCES [dbo].[Receita] ([id])
GO
ALTER TABLE [dbo].[Historico_Receitas] CHECK CONSTRAINT [FK_HR2]
GO
ALTER TABLE [dbo].[IngredienteAlergenio]  WITH NOCHECK ADD  CONSTRAINT [FK_IA1] FOREIGN KEY([id_Alergenio])
REFERENCES [dbo].[Alergenio] ([id])
GO
ALTER TABLE [dbo].[IngredienteAlergenio] CHECK CONSTRAINT [FK_IA1]
GO
ALTER TABLE [dbo].[IngredienteAlergenio]  WITH NOCHECK ADD  CONSTRAINT [FK_IA2] FOREIGN KEY([id_Ingrediente])
REFERENCES [dbo].[Ingrediente] ([id])
GO
ALTER TABLE [dbo].[IngredienteAlergenio] CHECK CONSTRAINT [FK_IA2]
GO
ALTER TABLE [dbo].[IngredienteReceita]  WITH NOCHECK ADD  CONSTRAINT [FK_IR1] FOREIGN KEY([id_Ingrediente])
REFERENCES [dbo].[Ingrediente] ([id])
GO
ALTER TABLE [dbo].[IngredienteReceita] CHECK CONSTRAINT [FK_IR1]
GO
ALTER TABLE [dbo].[IngredienteReceita]  WITH NOCHECK ADD  CONSTRAINT [FK_IR2] FOREIGN KEY([id_Receita])
REFERENCES [dbo].[Receita] ([id])
GO
ALTER TABLE [dbo].[IngredienteReceita] CHECK CONSTRAINT [FK_IR2]
GO
ALTER TABLE [dbo].[Passo]  WITH NOCHECK ADD  CONSTRAINT [FK_PA1] FOREIGN KEY([receitaid])
REFERENCES [dbo].[Receita] ([id])
GO
ALTER TABLE [dbo].[Passo] CHECK CONSTRAINT [FK_PA1]
GO
ALTER TABLE [dbo].[Passo]  WITH NOCHECK ADD  CONSTRAINT [FK_PA2] FOREIGN KEY([passo])
REFERENCES [dbo].[Ingrediente] ([id])
GO
ALTER TABLE [dbo].[Passo] CHECK CONSTRAINT [FK_PA2]
GO
ALTER TABLE [dbo].[Planeamento]  WITH CHECK ADD  CONSTRAINT [FK_Pl1] FOREIGN KEY([tipo_refeicao])
REFERENCES [dbo].[Tipo] ([tipo_desc])
GO
ALTER TABLE [dbo].[Planeamento] CHECK CONSTRAINT [FK_Pl1]
GO
ALTER TABLE [dbo].[Planeamento]  WITH CHECK ADD  CONSTRAINT [FK_Pl2] FOREIGN KEY([id_Utilizador])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Planeamento] CHECK CONSTRAINT [FK_Pl2]
GO
ALTER TABLE [dbo].[Planeamento]  WITH CHECK ADD  CONSTRAINT [FK_Pl3] FOREIGN KEY([id_Receita])
REFERENCES [dbo].[Receita] ([id])
GO
ALTER TABLE [dbo].[Planeamento] CHECK CONSTRAINT [FK_Pl3]
GO
ALTER TABLE [dbo].[Receita]  WITH NOCHECK ADD  CONSTRAINT [FK_Rec1] FOREIGN KEY([valor])
REFERENCES [dbo].[ValorNutricional] ([id])
GO
ALTER TABLE [dbo].[Receita] CHECK CONSTRAINT [FK_Rec1]
GO
ALTER TABLE [dbo].[Receita]  WITH NOCHECK ADD  CONSTRAINT [FK_Rec2] FOREIGN KEY([tipo])
REFERENCES [dbo].[Tipo] ([tipo_desc])
GO
ALTER TABLE [dbo].[Receita] CHECK CONSTRAINT [FK_Rec2]
GO
ALTER TABLE [dbo].[Receita]  WITH NOCHECK ADD  CONSTRAINT [FK_Rec3] FOREIGN KEY([regime])
REFERENCES [dbo].[Regime] ([regime_desc])
GO
ALTER TABLE [dbo].[Receita] CHECK CONSTRAINT [FK_Rec3]
GO
ALTER TABLE [dbo].[Receita]  WITH NOCHECK ADD  CONSTRAINT [FK_Rec4] FOREIGN KEY([dificuldade])
REFERENCES [dbo].[Dificuldade] ([dif_desc])
GO
ALTER TABLE [dbo].[Receita] CHECK CONSTRAINT [FK_Rec4]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_Ut] FOREIGN KEY([regime])
REFERENCES [dbo].[Regime] ([regime_desc])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_Ut]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_Ut2] FOREIGN KEY([tipo])
REFERENCES [dbo].[Tipo] ([tipo_desc])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_Ut2]
GO
USE [master]
GO
ALTER DATABASE [Eloise] SET  READ_WRITE 
GO
