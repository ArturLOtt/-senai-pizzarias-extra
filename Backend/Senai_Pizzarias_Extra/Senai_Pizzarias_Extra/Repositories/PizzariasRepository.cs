using Senai_Pizzarias_Extra.Interfaces;
using Senai_Pizzarias_Extra.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Pizzarias_Extra.Repositories
{
    public class PizzariasRepository : IPizzariasRepository
    {

        SENAI_PIZZARIAS_EXTRAContext ctx = new SENAI_PIZZARIAS_EXTRAContext();

        public List<Pizzarias> Listar()
        {

                List<Pizzarias> pizzariasLista = new List<Pizzarias>();

                return ctx.Pizzarias.ToList();

        }
    }
}
