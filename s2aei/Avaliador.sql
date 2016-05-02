CREATE TABLE [dbo].[Avaliador]
(
	[IdAvaliador] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [emailAval] VARCHAR(50) NOT NULL, 
    [nome] VARCHAR(50) NOT NULL, 
    [senha] VARCHAR(10) NOT NULL, 
    [areaAtuacao] VARCHAR(50) NOT NULL, 
    [formacao] VARCHAR(50) NOT NULL, 
    [situacao] TINYINT NOT NULL
)
