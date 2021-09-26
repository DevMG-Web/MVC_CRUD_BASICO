using HolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundo.Services
{
    public class PaisRepositorioEnMemoria: IRepositorioPais
    {
        public List<Pais> ObtenerTodos()
        {
            List<Pais> paises = new List<Pais>() { 
                new Pais("Republica dominica"),
                new Pais("Colombia"), 
                new Pais("Mexico")
            };
            
            return paises;
        }

    }
}
