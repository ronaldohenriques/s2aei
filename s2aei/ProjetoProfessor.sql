CREATE TABLE [dbo].[ProjetoProfessor]
(
	[IdProjeto] UNIQUEIDENTIFIER NOT NULL , 
    [IdProfessor] UNIQUEIDENTIFIER NOT NULL, 
    PRIMARY KEY ([IdProjeto], [IdProfessor]), 
    CONSTRAINT [FK_ProjetoProfessor_Projeto] FOREIGN KEY (IdProjeto) REFERENCES Projeto(IdProjeto), 
    CONSTRAINT [FK_ProjetoProfessor_Professor] FOREIGN KEY (IdProfessor) REFERENCES Professor(IdProfessor)
)
