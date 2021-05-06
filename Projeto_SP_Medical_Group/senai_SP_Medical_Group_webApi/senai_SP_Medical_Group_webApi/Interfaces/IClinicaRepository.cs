using senai_SP_Medical_Group_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SP_Medical_Group_webApi.Interfaces
{
    interface IClinicaRepository
    {
        void Cadastrar(Clinica novaClinica);

        List<Clinica> Listar();

        Clinica BuscarPorId(int id);

        void Atualizar(int id, Clinica clinicaAtualizada);

        void Deletar(int id);
    }
}
