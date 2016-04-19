CREATE TABLE [dbo].[Avaliador]
(
	[IdAvaliador] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [emailAval] VARCHAR(50) NULL, 
    [nome] VARCHAR(50) NULL, 
    [senha] VARCHAR(10) NULL, 
    [areaAtuacao] VARCHAR(50) NULL, 
    [formacao] VARCHAR(50) NULL, 
    [situacao] TINYINT NULL
)
