using System.Collections.Generic;

namespace khggjbjmn.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
