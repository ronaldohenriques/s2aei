CREATE TABLE [dbo].[Participando]
(
	[idAluno] UNIQUEIDENTIFIER NOT NULL,
	[idProjeto] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Participando] PRIMARY KEY ([idAluno], [idProjeto]), 
    CONSTRAINT [FK_Participando_AlunoMembro] FOREIGN KEY ([idAluno]) REFERENCES AlunoMembro(idAluno),
	CONSTRAINT [FK_Participando_Projeto] FOREIGN KEY ([idProjeto]) REFERENCES Projeto(idProjeto)
)
