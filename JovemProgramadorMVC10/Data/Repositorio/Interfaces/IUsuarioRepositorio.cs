﻿using JovemProgramadorMVC10.Models;

namespace JovemProgramadorMVC10.Data.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio
    {
         Usuario ValidarUsuario(string email, string senha);        
    }
}
