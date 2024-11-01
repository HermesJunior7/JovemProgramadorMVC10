using JovemProgramadorMVC10.Data.Repositorio.Interfaces;
using JovemProgramadorMVC10.Models;

namespace JovemProgramadorMVC10.Data.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public UsuarioRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public Usuario ValidarUsuario(string email, string senha)
        {
            return _bancoContexto.Usuario.SingleOrDefault(x => x.Email == email && x.Senha == senha);
        }
    }
}