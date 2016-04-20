CREATE TABLE [dbo].[ProjetoAluno]
(
	[IdProjeto] UNIQUEIDENTIFIER NOT NULL, 
    [IdAluno] UNIQUEIDENTIFIER NOT NULL, 
    PRIMARY KEY ([IdProjeto], [IdAluno]), 
    CONSTRAINT [FK_ProjetoAluno_Projeto] FOREIGN KEY (IdProjeto) REFERENCES Projeto(IdProjeto), 
    CONSTRAINT [FK_ProjetoAluno_Aluno] FOREIGN KEY (IdAluno) REFERENCES Aluno(IdAluno) 
)
