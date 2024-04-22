using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BackEndMeutreino.Models;

namespace BackEndMeutreino.Controllers
{
    public class ExerciciosController : Controller
    {
        private readonly Contexto _context;

        public ExerciciosController(Contexto context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Exercicio.ToListAsync());
        }

        public IActionResult Create() //COLOCANDO O CRIAR, SEGUIR A DIANTE
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Exercicio   exercicio)
        {
            if (ModelState.IsValid)
            {
                _context.Exercicio.Add(exercicio);
                await _context.SaveChangesAsync();
                return RedirectToAction("index");

            }

            return View(exercicio);
        }
        // Página de Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercicio = await _context.Exercicio
                .FirstOrDefaultAsync(m => m.id == id);
            if (exercicio == null)
            {
                return NotFound();
            }

            return View(exercicio);
        }

    }
}
