using System.Collections.Generic;

namespace jkhugyjfhgdf.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
