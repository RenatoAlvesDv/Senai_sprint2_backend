USE SP_Medical_Group;

--fazendo as consultas DQL

--Mostra a quantidade de usuários
SELECT COUNT(IdUsuario)AS QuantidadeDeUsuarios FROM Usuarios ;

--consulta todos os medicos
SELECT * FROM Medicos;

--Consulta os medicos, suas especialidade e a clinica que realizam o atendimento
SELECT Medicos.Nome AS [Médico],Especialidades.Descricao AS Especialidade,Medicos.CRM,Clinicas.NomeFantasia AS Atendimento FROM Medicos
INNER JOIN Especialidades
ON Medicos.IdEspecialidade = Especialidades.IdEspecialidade
INNER JOIN Clinicas
ON Medicos.IdClinica = Clinicas.IdClinica;

--Consulta a quantidade de medico em uma especialidade
SELECT COUNT(IdMedico) AS Quantidade_Medicos_cardiologistas FROM Medicos
INNER JOIN Especialidades
ON Medicos.IdEspecialidade = Especialidades.IdEspecialidade AND Descricao = 'Cardiologia';

