using senai_SP_Medical_Group_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SP_Medical_Group_webApi.Interfaces
{
    interface IUsuarioRepository
    {
        Usuario Login(string email, string senha);

        void Cadastrar(Usuario novoUsuario);

        List<Usuario> Listar();

        Usuario BuscarPorId(int id);

        void Atualizar(int id, Usuario usuarioAtualizado);

        void Deletar(int id);
    }
}
