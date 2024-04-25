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

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await _context.Exercicio.FindAsync(id);

            if (dados == null)
            {
                return NotFound();
            }
            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Exercicio exercicio)
        {
            if (id != exercicio.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Exercicio.Update(exercicio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            
            return View(exercicio);

        }





        // GET: Exercicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Exercicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exercicio = await _context.Exercicio.FindAsync(id);
            if (exercicio != null)
            {
                _context.Exercicio.Remove(exercicio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExercicioExists(int id)
        {
            return _context.Exercicio.Any(e => e.id == id);
        }





    }


    }

