IF OBJECT_ID('dbo.HoldingTable', 'U') IS NOT NULL
  DROP TABLE dbo.HoldingTable
  GO

CREATE TABLE [dbo].[HoldingTable]
(
	[Id] INT NOT NULL IDENTITY ,
	[SecurityId] INT NOT NULL,
	[SecurityName] NVARCHAR(50),
	[PortfolioId] INT NOT NULL,
	[PortfolioName] NVARCHAR(50),
	[ModelPortfolioId] INT NOT NULL,
	[ModelPortfolioName] NVARCHAR(50) NOT NULL,
	[Price] FLOAT,
	[Nominal] FLOAT,
	[MarketValue] FLOAT,
	[CashFlow] FLOAT
	PRIMARY KEY ([Id])
)
GO
CREATE INDEX [Idx_HoldingTable_Id] ON [dbo].[HoldingTable] ([Id])
GO

INSERT INTO [dbo].[HoldingTable]
	([SecurityId], [SecurityName], [PortfolioId],[PortfolioName], [ModelPortfolioId],[ModelProtFolioName],[Price],[Nominal],[MarketValue],[CashFlow])
VALUES
	(1, 'security 1', 1, 'Portforlio 1', 1, 'ModelPortforlio 1', 560, 600,450,56)
GO