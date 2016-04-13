CREATE TABLE [dbo].[Professor]
(
	[idProf] UNIQUEIDENTIFIER IDENTITY,
	[EmailP] VARCHAR(50) NOT NULL,
	[senha] VARCHAR(10) NOT NULL,
	[Nome] VARCHAR(50) NOT NULL,
	[DisciplinaP] VARCHAR(50) NOT NULL,
	[Departamento] VARCHAR(50) NOT NULL,
    CONSTRAINT [PK_Professor] PRIMARY KEY ([idProf])
)
