CREATE TABLE [dbo].[Projeto]
(
	[IdProjeto] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [nome] VARCHAR(50) NOT NULL, 
    [idAlunoLider] VARCHAR(50) NOT NULL, 
    [IdAvaliador] UNIQUEIDENTIFIER NOT NULL, 
    [situacao] TINYINT NOT NULL, 
    CONSTRAINT [FK_Projeto_Avaliador] FOREIGN KEY (IdAvaliador) REFERENCES Avaliador(IdAvaliador)
)
