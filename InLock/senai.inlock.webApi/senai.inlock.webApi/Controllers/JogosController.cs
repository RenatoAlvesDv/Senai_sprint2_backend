using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using senai.inlock.webApi_.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Controllers
{
    //Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição será no formato: dominio/api/NomeDoController
    // Exemplo: http://localhost:5000/api/jogos
    [Route("api/[controller]")]

    // Define que é um controller de API
    [ApiController]

    /// <summary>
    /// Classe responsável pelos endpoints (URL's) referentes aos jogos
    /// </summary>
    public class JogosController : ControllerBase
    {
        /// <summary>
        /// Objeto que recebe os métodos definidos na interface IJogoRepository
        /// </summary>

        private IJogoRepository _JogoRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _JogoRepository para referencia os métodos no repositório
        /// </summary>
       
        public JogosController()
        {
            _JogoRepository = new JogoRepository();   
        }


        /// <summary>
        /// Lista todo os jogos
        /// </summary>
        /// <returns> uma lista de jogos e um status code</returns>
        /// dominio/api/jogos 
       
        [HttpGet]
        public IActionResult Listar ()
        {

            //_ E UMA BOA PRATICA
            //Cria uma lista nomeada listajogos para receber os dados
            List<JogoDomain> listaJogos = _JogoRepository.ListarTodos();

            // Retorna o status code 200(ok) com a lista de gêneros no formato JSON
            return Ok(listaJogos);
        }
    }
}
