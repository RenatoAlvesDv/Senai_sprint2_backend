USE InLock_Games_Manha
GO

INSERT INTO TipoUsuarios (titulo)
VALUES					 ('Administrador')
						,('Cliente');
GO

INSERT INTO Usuarios (idTipoUsuario, email, senha)
VALUES				 (1, 'admin@admin.com', 'admin')
					,(2, 'cliente@cliente.com', 'cliente');
GO

INSERT INTO Estudios (nomeEstudio)
VALUES				 ('Blizzard')
					,('Rockstar Studios')
					,('Square Enix');
GO

INSERT INTO Jogos (nomeJogo, descricao, dataLancamento, idEstudio, valor)
VALUES            ('Diablo 3', '� um jogo que cont�m bastante a��o e � viciante,seja voc� um novato ou um f�', '2012/05/15', 1, '99')
				 ,('Red Dead Redemption II', 'jogo eletr�nico de a��o-aventura western', '2018/10/26', 2, '120');
GO



