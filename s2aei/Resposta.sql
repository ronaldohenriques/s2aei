CREATE TABLE [dbo].[Resposta]
(
	[IdResposta] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [IdProjeto] UNIQUEIDENTIFIER NULL, 
    [IdBloco] TINYINT NULL, 
    [Resposta] TEXT NULL, 
    CONSTRAINT [FK_Resposta_Projeto] FOREIGN KEY (IdProjeto) REFERENCES Projeto(IdProjeto)
)
