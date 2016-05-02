
-- Inserir novo usuário adminstrador
INSERT INTO Administracao (IdAdministracao, login, senha) VALUES (NEWID(), 'admin', 'admin');
GO


SELECT * FROM Administracao;