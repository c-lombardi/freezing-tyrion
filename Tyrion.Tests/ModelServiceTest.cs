using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyrion.Services;

namespace Tyrion.Tests
{
    class ModelServiceTest : IModelService
    {
        public bool Add(Models.IDatabaseModel o)
        { 
            return true; 
        }

        public bool Update(Models.IDatabaseModel o)
        {
            return true;
        }

        public bool Remove(Models.IDatabaseModel o)
        {
            return true;
        }

        public bool Remove(int id)
        {
            return true;
        }

        public int AddOrGet(Models.IDatabaseModel obj)
        {
            return 1;
        }
    }
}
