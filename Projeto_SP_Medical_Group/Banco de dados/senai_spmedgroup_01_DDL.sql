CREATE DATABASE SP_Medical_Group;
USE SP_Medical_Group;

CREATE TABLE TiposUsuarios
(
	IdTipoUsuario INT PRIMARY KEY IDENTITY,
	DescricaoUsuario VARCHAR(150) UNIQUE NOT NULL
);

CREATE TABLE Usuarios
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	IdTipoUsuario INT FOREIGN KEY REFERENCES TiposUsuarios(IdTipoUsuario),
	Email VARCHAR(200) UNIQUE NOT NULL,
	Senha VARCHAR(150) NOT NULL
);

CREATE TABLE Pacientes
(
	IdPaciente INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuarios(IdUsuario),
	Nome VARCHAR(150) NOT NULL,
	RG CHAR(9) UNIQUE NOT NULL,
	CPF CHAR(11) UNIQUE NOT NULL,
	DataNascimento DATE NOT NULL,
	Endereco VARCHAR(200) NOT NULL,
	Telefone VARCHAR(25) UNIQUE NOT NULL
);

CREATE TABLE Especialidades
(
	IdEspecialidade INT PRIMARY KEY IDENTITY,
	Descricao VARCHAR(150) NOT NULL
);

CREATE TABLE Clinicas
(
	IdClinica INT PRIMARY KEY IDENTITY,
	NomeFantasia VARCHAR(150) NOT NULL,
	Endereco VARCHAR(250) UNIQUE NOT NULL,
	RazaoSocial VARCHAR(150) UNIQUE NOT NULL,
	HorarioAbertura TIME NOT NULL,
	HorarioFechamento TIME NOT NULL,
	CNPJ CHAR(14) UNIQUE NOT NULL
);

CREATE TABLE Medicos
(
	IdMedico INT PRIMARY KEY IDENTITY,
	IdClinica INT FOREIGN KEY REFERENCES Clinicas(IdClinica),
	IdUsuario INT FOREIGN KEY REFERENCES Usuarios(IdUsuario),
	IdEspecialidade INT FOREIGN KEY REFERENCES Especialidades(IdEspecialidade),
	Nome VARCHAR(150) NOT NULL,
	CRM VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE StatusConsultas
(
	IdStatusConsulta INT PRIMARY KEY IDENTITY,
	Descricao VARCHAR(50) NOT NULL
);


CREATE TABLE Consultas
(
	IdConsulta INT PRIMARY KEY IDENTITY,
	IdStatusConsulta INT FOREIGN KEY REFERENCES StatusConsultas(IdStatusConsulta),
	IdMedico INT FOREIGN KEY REFERENCES Medicos(IdMedico),
	IdPaciente INT FOREIGN KEY REFERENCES Pacientes(IdPaciente),
	DataConsulta DATE NOT NULL,
	Horario TIME NOT NULL,
	Descricao VARCHAR(300) NOT NULL
);


