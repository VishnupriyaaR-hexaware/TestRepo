using System.Collections.Generic;

namespace  jkhugyjfhgdf.Data.Interfaces
{
    public interface IGet<T,TKey> where T : class
    {
        T Get(TKey id) ;
    }
}
