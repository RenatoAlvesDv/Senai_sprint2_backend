﻿using Microsoft.EntityFrameworkCore;
using senai_SP_Medical_Group_webApi.Contexts;
using senai_SP_Medical_Group_webApi.Domains;
using senai_SP_Medical_Group_webApi.Interfaces;
using senai_SP_Medical_Group_WebApi.ViwModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SP_Medical_Group_webApi.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {

        SP_Medical_GroupContext ctx = new SP_Medical_GroupContext();


        public void Cadastrar(Consulta novaConsulta)
        {
            ctx.Consultas.Add(novaConsulta);

            ctx.SaveChanges();
        }

        public List<Consulta> Listar()
        {
            return ctx.Consultas

                .Include(c => c.IdPacienteNavigation)

                .Include(c => c.IdMedicoNavigation)

                .Include(c => c.IdMedicoNavigation.IdEspecialidadeNavigation)

                .Include(c => c.IdStatusConsultaNavigation)

                .Select(c => new Consulta
                {
                    IdConsulta = c.IdConsulta,
                    DataConsulta = c.DataConsulta,
                    DescricaoAtendimento = c.DescricaoAtendimento,

                    IdPacienteNavigation = new Paciente
                    {
                        IdPaciente = c.IdPacienteNavigation.IdPaciente,
                        IdUsuario = c.IdPacienteNavigation.IdUsuario,
                        NomePaciente = c.IdPacienteNavigation.NomePaciente,
                    },

                    IdMedicoNavigation = new Medico
                    {
                        IdMedico = c.IdMedicoNavigation.IdMedico,
                        IdUsuario = c.IdMedicoNavigation.IdUsuario,
                        NomeMedico = c.IdMedicoNavigation.NomeMedico,
                        CRM = c.IdMedicoNavigation.CRM,

                        IdEspecialidadeNavigation = new Especialidade
                        {
                            IdEspecialidade = c.IdMedicoNavigation.IdEspecialidadeNavigation.IdEspecialidade,
                            DescricaoEspecialidade = c.IdMedicoNavigation.IdEspecialidadeNavigation.DescricaoEspecialidade
                        }
                    },

                    IdStatusConsultaNavigation = new StatusConsulta
                    {
                        IdStatusConsulta = c.IdStatusConsultaNavigation.IdStatusConsulta,
                        DescricaoStatusConsulta = c.IdStatusConsultaNavigation.DescricaoStatusConsulta
                    }

                })

                .ToList();
        }

        public Consulta BuscarPorId(int id)
        {
            return ctx.Consultas

                .Include(c => c.IdPacienteNavigation)

                .Include(c => c.IdMedicoNavigation)

                .Include(c => c.IdMedicoNavigation.IdEspecialidadeNavigation)

                .Include(c => c.IdStatusConsultaNavigation)

                .Select(c => new Consulta
                {
                    IdConsulta = c.IdConsulta,
                    DataConsulta = c.DataConsulta,
                    DescricaoAtendimento = c.DescricaoAtendimento,

                    IdPacienteNavigation = new Paciente
                    {
                        IdPaciente = c.IdPacienteNavigation.IdPaciente,
                        IdUsuario = c.IdPacienteNavigation.IdUsuario,
                        NomePaciente = c.IdPacienteNavigation.NomePaciente,
                    },

                    IdMedicoNavigation = new Medico
                    {
                        IdMedico = c.IdMedicoNavigation.IdMedico,
                        IdUsuario = c.IdMedicoNavigation.IdUsuario,
                        NomeMedico = c.IdMedicoNavigation.NomeMedico,
                        CRM = c.IdMedicoNavigation.CRM,

                        IdEspecialidadeNavigation = new Especialidade
                        {
                            IdEspecialidade = c.IdMedicoNavigation.IdEspecialidadeNavigation.IdEspecialidade,
                            DescricaoEspecialidade = c.IdMedicoNavigation.IdEspecialidadeNavigation.DescricaoEspecialidade
                        }
                    },

                    IdStatusConsultaNavigation = new StatusConsulta
                    {
                        IdStatusConsulta = c.IdStatusConsultaNavigation.IdStatusConsulta,
                        DescricaoStatusConsulta = c.IdStatusConsultaNavigation.DescricaoStatusConsulta
                    }

                })

                .FirstOrDefault(c => c.IdConsulta == id);
        }

        public void Atualizar(int id, Consulta consultaAtualizada)
        {
            Consulta consultaBuscada = ctx.Consultas.Find(id);

            if (consultaAtualizada.IdPaciente != null)
            {
                consultaBuscada.IdPaciente = consultaAtualizada.IdPaciente;
            }
            if (consultaAtualizada.IdMedico != null)
            {
                consultaBuscada.IdMedico = consultaAtualizada.IdMedico;
            }
            if (consultaAtualizada.IdStatusConsulta != null)
            {
                consultaBuscada.IdStatusConsulta = consultaAtualizada.IdStatusConsulta;
            }

            consultaBuscada.DataConsulta = consultaAtualizada.DataConsulta;

            consultaBuscada.HorarioConsulta = consultaAtualizada.HorarioConsulta;

            if (consultaBuscada.DescricaoAtendimento != null)
            {
                consultaBuscada.DescricaoAtendimento = consultaAtualizada.DescricaoAtendimento;
            }

            ctx.Consultas.Update(consultaBuscada);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Consulta consultaBuscada = ctx.Consultas.Find(id);

            ctx.Consultas.Remove(consultaBuscada);

            ctx.SaveChanges();
        }

        public void AtualizarDescricao(int id, ConsultaViewModel atualizarDescricao)
        {
            Consulta consultaBuscada = ctx.Consultas.Find(id);

            if (atualizarDescricao.DescricaoAtendimento != null)
            {
                consultaBuscada.DescricaoAtendimento = atualizarDescricao.DescricaoAtendimento;
            }

            ctx.Consultas.Update(consultaBuscada);

            ctx.SaveChanges();
        }

        public List<Consulta> ListarMinhas(int id)
        {

            return ctx.Consultas

                .Include(c => c.IdPacienteNavigation)

                .Include(c => c.IdMedicoNavigation)

                .Include(c => c.IdMedicoNavigation.IdEspecialidadeNavigation)

                .Include(c => c.IdStatusConsultaNavigation)

                .Select(c => new Consulta
                {
                    IdConsulta = c.IdConsulta,
                    DataConsulta = c.DataConsulta,
                    DescricaoAtendimento = c.DescricaoAtendimento,

                    IdPacienteNavigation = new Paciente
                    {
                        IdPaciente = c.IdPacienteNavigation.IdPaciente,
                        IdUsuario = c.IdPacienteNavigation.IdUsuario,
                        NomePaciente = c.IdPacienteNavigation.NomePaciente,
                    },

                    IdMedicoNavigation = new Medico
                    {
                        IdMedico = c.IdMedicoNavigation.IdMedico,
                        IdUsuario = c.IdMedicoNavigation.IdUsuario,
                        NomeMedico = c.IdMedicoNavigation.NomeMedico,
                        CRM = c.IdMedicoNavigation.CRM,

                        IdEspecialidadeNavigation = new Especialidade
                        {
                            IdEspecialidade = c.IdMedicoNavigation.IdEspecialidadeNavigation.IdEspecialidade,
                            DescricaoEspecialidade = c.IdMedicoNavigation.IdEspecialidadeNavigation.DescricaoEspecialidade
                        }
                    },

                    IdStatusConsultaNavigation = new StatusConsulta
                    {
                        IdStatusConsulta = c.IdStatusConsultaNavigation.IdStatusConsulta,
                        DescricaoStatusConsulta = c.IdStatusConsultaNavigation.DescricaoStatusConsulta
                    }

                })

                .Where(c => c.IdPacienteNavigation.IdUsuario == id || c.IdMedicoNavigation.IdUsuario == id)

                .ToList();
        }

        public void AtualizarStatus(int idConsulta, int idStatus)
        {
            Consulta consultaBuscada = ctx.Consultas.Find(idConsulta);

            if (consultaBuscada.IdStatusConsulta != null)
            {
                consultaBuscada.IdStatusConsulta = idStatus;
            }

            ctx.Consultas.Update(consultaBuscada);

            ctx.SaveChanges();
        }
    }


}
