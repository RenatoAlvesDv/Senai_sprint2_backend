using SENAI_filmes_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI_filmes_webApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositorio GeneroRepository
    /// </summary>
    interface IGeneroRepositoey
    {


        // TipoRetorno NomeMetodo();1q1
        // VOID Cadastrar();

        /// <summary>
        /// Retorna todos os gêneros
        /// </summary>
        /// <returns>Uma lista de gêneros</returns>

        List<GeneroDomain> ListarTodos();

        /// <summary>
        /// Busca um gênero através do seu id
        /// </summary>
        /// <param name="id">Id do gênero que será buscado/param>
        /// <returns>Um obejto do tipo GeneroDomain que foi buscado</returns>
        GeneroDomain BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo gênero
        /// </summary>
        /// <param name="novoGenero">Objeto novoGenero que será cadastrado</param>
        void Cadastrar(GeneroDomain novoGenero);

        /// <summary>
        /// Atualiza um gênero existente passando o id pelo corpo da requisição
        /// </summary>
        /// <param name="genero">Obejeto genero que será atualizado</param>
        void AtualizarIdCorpo(GeneroDomain genero);

        void AtualizarIdUrl(int id, GeneroDomain genero);

        /// <summary>
        /// Deleta um gênero
        /// </summary>
        /// <param name="id">id do genero que será deletado </param>
        void Deletar(int id)

    }
}
