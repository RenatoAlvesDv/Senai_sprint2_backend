using senai_SP_Medical_Group_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SP_Medical_Group_webApi.Interfaces
{
    interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade novaEspecialidade);

        List<Especialidade> Listar();

        Especialidade BuscarPorId(int id);

        void Atualizar(int id, Especialidade especialidadeAtualizada);

        void Deletar(int id);
    }
}