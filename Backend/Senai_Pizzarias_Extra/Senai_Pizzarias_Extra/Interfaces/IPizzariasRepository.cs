﻿using Senai_Pizzarias_Extra.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Pizzarias_Extra.Interfaces
{
    interface IPizzariasRepository
    {
        
        List<Pizzarias> Listar();

    }
}