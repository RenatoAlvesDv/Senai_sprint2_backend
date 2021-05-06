USE SP_Medical_Group;

--Inserindo os dados DML

INSERT INTO TiposUsuarios (DescricaoUsuario)
VALUES ('Administrador')
	  ,('Paciente')
	  ,('Médico');
GO

INSERT INTO Usuarios(IdTipoUsuario,Email,Senha)
VALUES	(3,'eduardo.gomes@spmedical.com', '654321'),
		(3,'ricardo.kodama@spmedical.com', '123456'),
		(3,'renato.alves@spmedical.com', '789456'),
		(2, 'gabriel@email.com', '888888'),
		(2, 'gustavo@email.com', '777777'),
		(2,	'leandro@email.com', '258258'),
		(2, 'vinicius@email.com', '147741'),
		(2, 'edu@bool.com', '369963'),
		(2, 'lucas@email.com', '259519'),
		(2, 'pamela@outlook.com', '357951');
GO

INSERT INTO Pacientes(IdUsuario,Nome,RG,CPF,DataNascimento,Endereco,Telefone)
VALUES	(4, 'Gabriel', '215895205','50886322008','20/06/2000', 'Rua Abreu Medeiros, 8', '11925668541'),
		(5, 'Gustavo','189933680','88888888888','01/02/1997','Rua Abadia dos Dourados, 208 - Vila Indiana','11992538281'),
		(6, 'Leandro','856231213','58889208500','22/01/1965','Rua Adelfa de Figueiredo, 808','11991553332'),
		(7,'Vinicius','143663625','95159753302','28/09/1977','Rua 13 de Maio,88','1125522866'),
		(8,'Edu','599806286','29878505001','10/02/1985','Rua 18 de Abril, 1058','11994432158'),
		(9,'Lucas','115562662','11289980808','08/08/1969','Rua Abel Ramos, 550','11954368769'),
		(10,'Pamela','225819205','56680899980','25/08/2000','Rua Manuel, 15','1125538508');
GO

INSERT INTO Especialidades(Descricao)
VALUES ('Acupuntura'),
      ('Anestesiologia'),
	  ('Angiologia'),
	  ('Cardiologia'),
	  ('Cirurgia Cardiovascular'),
	  ('Cirurgia da Mão'),
	  ('Cirurgia do Aparelho Digestivo'),
	  ('Cirurgia Geral'),
	  ('Cirurgia Pediátrica'),
	  ('Cirurgia Plástica'),
	  ('Cirurgia Torácica'),
	  ('Cirurgia Vascular'),
	  ('Dermatologia'),
	  ('Radioterapia'),
	  ('Urologia'),
	  ('Pediatria'),
	  ('Psiquiatria');
GO

INSERT INTO Clinicas(NomeFantasia,Endereco,RazaoSocial,HorarioAbertura,HorarioFechamento,CNPJ)
VALUES	('Clinica Level', 'Av. Barão Limeira, 532, São Paulo, SP','SP Medical Group','07:00','18:00','77210813000800');
GO

INSERT INTO Medicos(IdClinica,IdUsuario,IdEspecialidade,Nome,CRM)
VALUES	(1,1,10,'Eduardo Gomes','11580SP'),
		(1,2,2,'Ricadro Kodama','15992SP'),
		(1,3,4,'Renato Alves','781888SP');
GO

INSERT INTO StatusConsultas(Descricao)
VALUES	('Agendada'),
		('Realizada'),
		('Cancelada');
GO
	   
INSERT INTO Consultas(IdPaciente,IdMedico,IdStatusConsulta,Descricao,DataConsulta,Horario)
VALUES	(4,3,3,'02/01/2020','10:00'),
		(7,2,2,'18/04/2019','13:00'),
		(1,2,3,'10/08/2020','12:00'),
		(9,2,3,'10/02/2019','11:00'),
		(9,1,1,'01/08/2020','09:00'),
		(6,1,1,'14/02/2020','14:00');
GO


















