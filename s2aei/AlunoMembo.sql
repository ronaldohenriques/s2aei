CREATE TABLE [dbo].[AlunoMembo]
(
	[IdAlunoMembo] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	  [emaila] VARCHAR(50) NOT NULL,
  [senha] VARCHAR(10) NOT NULL,
  [Nome] VARCHAR(50) NOT NULL,
  [Curso] VARCHAR(50) NOT NULL,
  [Periodo] VARCHAR(50) NOT NULL,
  [Campus] VARCHAR(50) NOT NULL, 
    [ativo] TINYINT NOT NULL
)
