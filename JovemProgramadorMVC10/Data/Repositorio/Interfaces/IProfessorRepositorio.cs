using JovemProgramadorMVC10.Models;

namespace JovemProgramadorMVC10.Data.Repositorio.Interfaces
{
    public interface IProfessorRepositorio
    {
        List<Professor> BuscarProfessores();
        void InserirProfessor(Professor professor);
        Professor BuscarId(int id);
        void EditarProfessor(Professor professor);
        void ExcluirProfessor(Professor professor);
    }
}