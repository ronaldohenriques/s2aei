CREATE TABLE [dbo].[Administracao]
(
	[IdAdministracao] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [login] VARCHAR(50) NULL, 
    [senha] VARCHAR(10) NULL
)
