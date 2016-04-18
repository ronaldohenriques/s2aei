CREATE TABLE [dbo].[Professor]
(
	[IdProfessor] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [emailp] VARCHAR(50) NOT NULL, 
    [senha] VARCHAR(50) NOT NULL, 
    [nome] VARCHAR(50) NOT NULL, 
    [disciplinaP] VARCHAR(50) NOT NULL, 
    [Departamento] VARCHAR(50) NOT NULL, 
    [ativo] TINYINT NOT NULL
)
