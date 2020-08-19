using System;
using System.Collections.Generic;
using System.Text;

namespace EFCache.Contracts
{
    /// <summary>
    /// The CacheKey Hash Provider Contract.
    /// </summary>
    public interface IEFCacheKeyHashProvider
    {
        /// <summary>
        /// Computes the unique hash of the input.
        /// </summary>
        /// <param name="data">the input data to hash</param>
        /// <returns>Hashed data</returns>
        string ComputeHash(string data);
    }
}
