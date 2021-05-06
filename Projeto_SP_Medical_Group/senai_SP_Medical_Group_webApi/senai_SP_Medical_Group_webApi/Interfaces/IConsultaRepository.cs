using senai_SP_Medical_Group_webApi.Domains;

using senai_SP_Medical_Group_WebApi.ViwModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SP_Medical_Group_webApi.Interfaces
{
    interface IConsultaRepository
    {
        void Cadastrar(Consulta novaConsulta);

        List<Consulta> Listar();

        Consulta BuscarPorId(int id);

        void Atualizar(int id, Consulta consultaAtualizada);

        void Deletar(int id);

        List<Consulta> ListarMinhas(int id);

        void AtualizarStatus(int id, int idStatus);

        void AtualizarDescricao(int id, ConsultaViewModel atualizarDescricao);
    }
}
