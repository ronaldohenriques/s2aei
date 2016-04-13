CREATE TABLE [dbo].[AlunoMembro]
(
	[idAluno] UNIQUEIDENTIFIER IDENTITY,
	[EmailA] VARCHAR(50) NOT NULL,
	[senha] VARCHAR(10) NOT NULL,
	[Nome] VARCHAR(50) NOT NULL,
	[Curso] VARCHAR(30) NOT NULL,
	[Periodo] INT NOT NULL,
	[Campus] VARCHAR(30) NOT NULL, 
    CONSTRAINT [PK_AlunoMembro] PRIMARY KEY ([idAluno]) 
)
