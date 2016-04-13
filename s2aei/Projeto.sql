CREATE TABLE [dbo].[Projeto]
(
	[idProjeto] UNIQUEIDENTIFIER IDENTITY,
	[idAlunoLider] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_Projeto_AlunoMembro] FOREIGN KEY (idAlunoLider) REFERENCES Participando ([idAluno]), 
    CONSTRAINT [PK_Projeto] PRIMARY KEY ([IdProjeto])

)
