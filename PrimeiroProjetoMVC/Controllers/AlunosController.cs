using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrimeiroProjetoMVC.Models;

namespace PrimeiroProjetoMVC.Controllers
{
    public class AlunosController : Controller
    {
        
        private static List<Aluno> _alunos = new()
        {
            new Aluno {Id = 1, Nome = "Daniel Vorcaro", Email = "contato.daniel.vorcaro@gmail.com", Idade = 42},
            new Aluno {Id = 2, Nome = "Diogo Chelles", Email = "pi.diogo@gmail.com", Idade = 18},
        };

        // GET /Alunos - listar todos os alunos
        public IActionResult Index()
        {
            return View(_alunos);
        }

        public IActionResult Detalhes(int id)
        {
            var aluno = _alunos.FirstOrDefault(a => a.Id == id);

            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }

        [HttpGet] 
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Aluno aluno)
        {
            
        }

        
    }
}