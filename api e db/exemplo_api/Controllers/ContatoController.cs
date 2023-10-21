using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exemplo_api.Context;
using exemplo_api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace exemplo_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        [HttpPost]        
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorID), new { id = contato.Id }, contato);
        }
        [HttpGet("{id}")]
        public IActionResult ObterPorID(int id)
        {
            var contato = _context.Contato.Find(id);
            if(contato == null)
            {
                return NotFound();
            }
            else
            {         
                return Ok(contato);
            }
        }
        [HttpGet("ObterPorNome{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contato.Where(x => x.Nome.Contains(nome));
            if(contatos == null)
            {
                return NotFound();
            }
            else
            {         
                return Ok(contatos);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contato.Find(id);
            if(contatoBanco == null)
            {
                return NotFound();
            }
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contato.Update(contatoBanco);
            _context.SaveChanges();
            
            return Ok(contatoBanco);
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contatoBanco = _context.Contato.Find(id);
            if(contatoBanco == null)
            {
                return NotFound();
            }

            _context.Contato.Remove(contatoBanco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}