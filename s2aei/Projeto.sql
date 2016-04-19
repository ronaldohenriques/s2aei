CREATE TABLE [dbo].[Projeto]
(
	[IdProjeto] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [nome] VARCHAR(50) NOT NULL, 
    [idAlunoLider] VARCHAR(50) NOT NULL, 
    [idOrientador] VARCHAR(50) NOT NULL, 
    [situacao] TINYINT NOT NULL
)
