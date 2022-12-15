CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL  PRIMARY KEY Identity,
	[Name] nvarchar(30) not null,
	[Email] nvarchar(50) null, 
    [Visited] INT NOT NULL DEFAULT 0, 
    [Created] DATETIME NOT NULL DEFAULT GetDate(),
	
)
