using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrion.Models
{
    public interface IDatabaseModel
    {
        /// <summary>
        /// Loads all foreign references
        /// </summary>
        void Load();
    }
}
