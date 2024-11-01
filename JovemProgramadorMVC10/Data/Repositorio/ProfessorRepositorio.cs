using JovemProgramadorMVC10.Data.Repositorio.Interfaces;
using JovemProgramadorMVC10.Models;

namespace JovemProgramadorMVC10.Data.Repositorio
{
    public class ProfessorRepositorio : IProfessorRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public ProfessorRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Professor> BuscarProfessores()
        {
            return _bancoContexto.Professor.Select(p=> new Professor { Id = p.Id, Nome = p.Nome ?? "Registro Inválido"}).ToList();
                
        }

        public void InserirProfessor(Professor professor)
        {
            _bancoContexto.Professor.Add(professor);
            _bancoContexto.SaveChanges();
        }

        public Professor BuscarId(int id)
        {
            return _bancoContexto.Professor.FirstOrDefault(x => x.Id == id);          
        }

        public void EditarProfessor(Professor professor)
        {
            _bancoContexto.Professor.Update(professor);
            _bancoContexto.SaveChanges();
        }

        public void ExcluirProfessor(Professor professor)
        {
            _bancoContexto.Professor.Remove(professor);
            _bancoContexto.SaveChanges();
        }       
    }
}
