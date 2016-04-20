CREATE TABLE [dbo].[ComentProfessor]
(
	[IdComentProf] UNIQUEIDENTIFIER NOT NULL , 
    [IdProjeto] UNIQUEIDENTIFIER NOT NULL, 
    [IdBloco] NCHAR(10) NULL, 
    [IdResposta] NCHAR(10) NULL, 
    PRIMARY KEY ([IdComentProf], [IdProjeto]), 
    CONSTRAINT [FK_ComentProfessor_Projeto] FOREIGN KEY (IdProjeto) REFERENCES Projeto(IdProjeto), 
    CONSTRAINT [FK_ComentProfessor_Professor] FOREIGN KEY (IdComentProf) REFERENCES Professor(IdProfessor)

)
