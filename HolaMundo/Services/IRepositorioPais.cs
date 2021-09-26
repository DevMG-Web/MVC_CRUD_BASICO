using HolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundo.Services
{
    public interface IRepositorioPais
    {
        List<Pais> ObtenerTodos();
    }
}
