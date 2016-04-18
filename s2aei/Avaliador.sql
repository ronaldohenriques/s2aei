CREATE TABLE [dbo].[Avaliador]
(
	[IdAvaliador] INT NOT NULL PRIMARY KEY, 
    [emailAval] VARCHAR(50) NULL, 
    [nome] VARCHAR(50) NULL, 
    [senha] VARCHAR(50) NULL, 
    [areaAtuacao] VARCHAR(50) NULL, 
    [formacao] VARCHAR(50) NULL, 
    [ativo] TINYINT NULL
)
