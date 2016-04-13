CREATE TABLE [dbo].[AlunoLider]
(
	[idAlunoLider] UNIQUEIDENTIFIER, 
	[idProjeto] UNIQUEIDENTIFIER,
    CONSTRAINT [FK_AlunoLider_AlunoMembro] FOREIGN KEY (idAlunoLider) REFERENCES AlunoMembro(idAluno),
	CONSTRAINT [FK_AlunoLider_idProjeto] FOREIGN KEY (idProjeto) REFERENCES Projeto(idProjeto) 
)
