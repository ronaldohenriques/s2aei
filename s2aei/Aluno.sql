CREATE TABLE [dbo].[Aluno]
(
  [IdAluno] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
  [emaila] VARCHAR(50) NOT NULL,
  [senha] VARCHAR(10) NOT NULL,
  [Nome] VARCHAR(50) NOT NULL,
  [curso] VARCHAR(50) NOT NULL,
  [periodo] VARCHAR(50) NOT NULL,
  [campus] VARCHAR(50) NOT NULL, 
  [situacao] TINYINT NOT NULL
)
