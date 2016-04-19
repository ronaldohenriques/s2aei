CREATE TABLE [dbo].[Professor]
(
	[IdProfessor] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [emailp] VARCHAR(50) NOT NULL, 
    [senha] VARCHAR(10) NOT NULL, 
    [nome] VARCHAR(50) NOT NULL, 
    [disciplinaP] VARCHAR(50) NOT NULL, 
    [departamento] VARCHAR(50) NOT NULL, 
    [situacao] TINYINT NOT NULL
)
