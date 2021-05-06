using senai_SP_Medical_Group_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SP_Medical_Group_webApi.Interfaces
{
    interface IMedicoRepository
    {
        void Cadastrar(Medico novoMedico);

        List<Medico> Listar();

        Medico BuscarPorId(int id);

        void Atualizar(int id, Medico medicoAtualizado);

        void Deletar(int id);
    }
}