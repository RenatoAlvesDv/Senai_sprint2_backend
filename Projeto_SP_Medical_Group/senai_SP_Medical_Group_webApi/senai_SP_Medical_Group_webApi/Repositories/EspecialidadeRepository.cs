using senai_SP_Medical_Group_webApi.Contexts;
using senai_SP_Medical_Group_webApi.Domains;
using senai_SP_Medical_Group_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SP_Medical_Group_webApi.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {

        SP_Medical_GroupContext ctx = new SP_Medical_GroupContext();

        public void Cadastrar(Especialidade novaEspecialidade)
        {
            ctx.Especialidades.Add(novaEspecialidade);

            ctx.SaveChanges();
        }

        public List<Especialidade> Listar()
        {
            return ctx.Especialidades.ToList();
        }

        public Especialidade BuscarPorId(int id)
        {
            return ctx.Especialidades.FirstOrDefault(e => e.IdEspecialidade == id);
        }

        public void Atualizar(int id, Especialidade especialidadeAtualizada)
        {
            Especialidade especialidadeBuscada = ctx.Especialidades.Find(id);

            if (especialidadeAtualizada.DescricaoEspecialidade != null)
            {
                especialidadeBuscada.DescricaoEspecialidade = especialidadeAtualizada.DescricaoEspecialidade;
            }

            ctx.Especialidades.Update(especialidadeBuscada);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Especialidade especialidadeBuscada = ctx.Especialidades.Find(id);

            ctx.Especialidades.Remove(especialidadeBuscada);

            ctx.SaveChanges();
        }

    }
}
