﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyrion.Models;

namespace Tyrion.Services
{
    public interface IModelService
    {
        bool Add(IDatabaseModel o);
        bool Update(IDatabaseModel o);
        bool Remove(IDatabaseModel o);
        bool Remove(int id);
        int AddOrGet(IDatabaseModel obj);
    }
}
