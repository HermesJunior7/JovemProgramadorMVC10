using JovemProgramadorMVC10.Data.Repositorio.Interfaces;
using JovemProgramadorMVC10.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorMVC10.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorRepositorio _professorRepositorio;
        public ProfessorController(IProfessorRepositorio professorRepositorio)
        {
            _professorRepositorio = professorRepositorio;
        }
        public IActionResult Index()
        {
            var professor = _professorRepositorio.BuscarProfessores();
            return View(professor);
        }
        public IActionResult AdicionarProfessor()
        {
            return View();
        }
        public IActionResult InserirProfessor(Professor professor)
        {
            try
            {
                _professorRepositorio.InserirProfessor(professor);
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index");
        }
        public IActionResult Editar(int id)
        {
            var professor = _professorRepositorio.BuscarId(id);
            return View(professor);

        }
        public IActionResult EditarProfessor(Professor professor)
        {
            _professorRepositorio.EditarProfessor(professor);
            return RedirectToAction("Index");
        }
        public IActionResult Excluir(int id)
        {
            var professor = _professorRepositorio.BuscarId(id);
            return View(professor);
        }
        public IActionResult ExcluirProfessor(Professor professor)
        {
            _professorRepositorio.ExcluirProfessor(professor);
            return RedirectToAction("Index");
        }
    }
}
