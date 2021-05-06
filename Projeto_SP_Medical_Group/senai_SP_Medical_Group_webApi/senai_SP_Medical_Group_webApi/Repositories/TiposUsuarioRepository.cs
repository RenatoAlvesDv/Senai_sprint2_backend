using senai_SP_Medical_Group_webApi.Contexts;
using senai_SP_Medical_Group_webApi.Domains;
using senai_SP_Medical_Group_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SP_Medical_Group_webApi.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {

        SP_Medical_GroupContext ctx = new SP_Medical_GroupContext();

        public void Cadastrar(TiposUsuario novoTipo)
        {
            ctx.TiposUsuarios.Add(novoTipo);

            ctx.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            return ctx.TiposUsuarios.ToList();
        }

        public TiposUsuario BuscarPorId(int id)
        {
            return ctx.TiposUsuarios.FirstOrDefault(t => t.IdTipoUsuario == id);
        }

        public void Atualizar(int id, TiposUsuario tipoAtualizado)
        {
            TiposUsuario tipoBuscado = ctx.TiposUsuarios.Find(id);

            if (tipoAtualizado.TituloTipoUsuario != null)
            {
                tipoBuscado.TituloTipoUsuario = tipoAtualizado.TituloTipoUsuario;
            }

            ctx.TiposUsuarios.Update(tipoBuscado);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TiposUsuario tipoBuscado = ctx.TiposUsuarios.Find(id);

            ctx.TiposUsuarios.Remove(tipoBuscado);

            ctx.SaveChanges();
        }

    }
}