using senai_SP_Medical_Group_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SP_Medical_Group_webApi.Interfaces
{
    interface ITiposUsuarioRepository
    {
        void Cadastrar(TiposUsuario novoTipo);

        List<TiposUsuario> Listar();

        TiposUsuario BuscarPorId(int id);

        void Atualizar(int id, TiposUsuario tipoAtualizado);

        void Deletar(int id);

    }
}
