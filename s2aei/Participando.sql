CREATE TABLE [dbo].[Participando]
(
	[Professor_idProfessor] UNIQUEIDENTIFIER NOT NULL , 
    [AlunoMembo_idAlunoMembo] UNIQUEIDENTIFIER NOT NULL, 
    [Projeto_idProjeto] UNIQUEIDENTIFIER NOT NULL, 
    [Avaliador_idAvaliador] UNIQUEIDENTIFIER NOT NULL, 
    PRIMARY KEY ([Professor_idProfessor], [AlunoMembo_idAlunoMembo], [Projeto_idProjeto], [Avaliador_idAvaliador]), 
    CONSTRAINT [FK_Participando_Professor] FOREIGN KEY (Professor_idProfessor) REFERENCES Professor(IdProfessor), 
    CONSTRAINT [FK_Participando_AlunoMembro] FOREIGN KEY (AlunoMembo_idAlunoMembo) REFERENCES AlunoMembo(IdAlunoMembo), 
    CONSTRAINT [FK_Participando_Projeto] FOREIGN KEY (Projeto_idProjeto) REFERENCES Projeto (IdProjeto), 
    CONSTRAINT [FK_Participando_Avaliador] FOREIGN KEY (Avaliador_idAvaliador) REFERENCES Avaliador(IdAvaliador)
)
