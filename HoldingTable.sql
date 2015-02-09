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
	[ModelProtFolioName] NVARCHAR(50) NOT NULL,
	[Price] FLOAT,
	[Nominal] FLOAT,
	[MarketValue] FLOAT,
	[CashFlow] FLOAT
	PRIMARY KEY ([Id])
)
GO
CREATE INDEX [Idx_HoldingTable_Id] ON [dbo].[HoldingTable] ([Id])
GO