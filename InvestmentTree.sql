IF OBJECT_ID('dbo.InvestmentTree', 'U') IS NOT NULL
  DROP TABLE dbo.HoldingTable
  GO

CREATE TABLE [dbo].[InvestmentTree]
(
	[Id] INT NOT NULL IDENTITY ,
	[TreeId] INT NOT NULL,
	[TreeName] NVARCHAR(50),
	[ParentId] INT NOT NULL,
	[SplitType] NVARCHAR(50)
	PRIMARY KEY ([Id])
)
GO
CREATE INDEX [Idx_InvestmentTree_Id] ON [dbo].[InvestmentTree] ([Id])
GO