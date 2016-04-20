CREATE TABLE [dbo].[ComentAluno]
(
	[IdComentAluno] UNIQUEIDENTIFIER NOT NULL , 
    [IdProjeto] UNIQUEIDENTIFIER NOT NULL, 
    [IdBloco] NCHAR(10) NULL, 
    [IdResposta] NCHAR(10) NULL, 
    PRIMARY KEY ([IdComentAluno], [IdProjeto]), 
    CONSTRAINT [FK_ComentAluno_Projeto] FOREIGN KEY (IdProjeto) REFERENCES Projeto(IdProjeto), 
    CONSTRAINT [FK_ComentAluno_Alunor] FOREIGN KEY (IdComentAluno) REFERENCES Aluno(IdAluno)
)
