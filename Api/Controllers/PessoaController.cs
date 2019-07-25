using Api.Models.ModelView;
using Api.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        // GET: api/Pessoa
        [HttpGet]
        public IActionResult Get()
        {
            var pessoas = new List<PessoaModelView>
            {
                new PessoaModelView() { PessoaId = 1, Nome = $"Pessoa 2 - {Request.ContentType}" },
                new PessoaModelView() { PessoaId = 2, Nome = $"Pessoa 4 - {Request.ContentType}" }
            };

            return Ok(pessoas);
        }

        // POST: api/Pessoa
        [HttpPost]
        public IActionResult Post([FromBody] PessoaViewModel pessoaViewModel)
        {
            var pessoas = new List<PessoaModelView>
            {
                new PessoaModelView() { PessoaId = 1, Nome = $"Kleiton - {Request.ContentType}" },
                new PessoaModelView() { PessoaId = 2, Nome = $"Humberto - {Request.ContentType}" }
            };

            var novaPessoa = new PessoaModelView()
            {
                PessoaId = pessoaViewModel.PessoaId,
                Nome = pessoaViewModel.Nome
            };

            pessoas.Add(novaPessoa);
            return Ok(pessoas);
        }
    }
}