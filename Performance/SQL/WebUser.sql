IF OBJECT_ID('dbo.WebUSer', 'U') IS NOT NULL
  DROP TABLE dbo.WebUser
  GO

CREATE TABLE [dbo].[WebUser]
(
	[Id] INT NOT NULL IDENTITY ,
	[Username] NVARCHAR(50) NOT NULL,
	[Password] NVARCHAR(MAX) NOT NULL,
	[Role] NVARCHAR(50) NOT NULL,
	PRIMARY KEY ([Id])
)
GO
CREATE INDEX [Idx_WebUser_Username] ON [dbo].[WebUser] ([Username])
GO
INSERT INTO [dbo].[WebUser]
	([Username], [Password], [Role])
VALUES
	('admin', '40bd001563085fc35165329ea1ff5c5ecbdbbeef', 'Administrator')
GO