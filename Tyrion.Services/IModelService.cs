using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyrion.Models;

namespace Tyrion.Services
{
    public interface IModelService
    {
        /// <summary>
        /// Adds an Object
        /// </summary>
        /// <param name="o">Object to Add</param>
        /// <returns>True if successful</returns>
        bool Add(IDatabaseModel o);
        /// <summary>
        /// Updates an object
        /// </summary>
        /// <param name="o">Object to Update</param>
        /// <returns>True if successful</returns>
        bool Update(IDatabaseModel o);
        /// <summary>
        /// Removes an Object
        /// </summary>
        /// <param name="o">Object to Remove</param>
        /// <returns>True if Successful</returns>
        bool Remove(IDatabaseModel o);
        /// <summary>
        /// Removes an Object By Id
        /// </summary>
        /// <param name="id">Id of Object</param>
        /// <returns>True if successful</returns>
        bool Remove(int id);
        /// <summary>
        /// Adds or Gets an Object
        /// </summary>
        /// <param name="obj">Object to Add Or Get</param>
        /// <returns>Id of Object</returns>
        int AddOrGet(IDatabaseModel obj);
    }
}
