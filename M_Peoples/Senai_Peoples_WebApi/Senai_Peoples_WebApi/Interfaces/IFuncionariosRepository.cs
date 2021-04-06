﻿using Senai.Peoples.WebApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Interfaces
{
    public interface IFuncionariosRepository
    {
        /// <summary>
        /// Retorna todos os funcionários
        /// </summary>
        /// <returns>Lista de Funcionários</returns>
        List<FuncionariosDomain> ListarTodos();

        /// <summary>
        /// Cadastra um novo Funcionario        
        /// </summary>
        /// <param name="novoFuncionario">Obleto novoFuncionario que será cadastrado</param>
        void Cadastrar(FuncionariosDomain novoFuncionario);

        /// <summary>
        /// Atualiza os dados de um funcionário passando id pela URL
        /// </summary>
        /// <param name="id">id do funcionario que será atualizado</param>
        /// <param name="funcionario">Objeto funcionario com as novas informações</param>
        void AtualizarIdUrl(int id, FuncionariosDomain funcionario);

        /// <summary>
        /// Deleta o cadastro de um funcionário
        /// </summary>
        /// <param name="id">id do Funcionário que será deletado</param>
        void Deletar(int id);

        /// <summary>
        /// Busca um Funcionario através do seu id
        /// </summary>
        /// <param name="id">id do gênero que será buscado</param>
        /// <returns>Um objeto do tipo GeneroDomain que foi buscado</returns>
        FuncionariosDomain BuscarPorId(int id);


    }
}