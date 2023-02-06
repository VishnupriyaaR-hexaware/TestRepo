using System.Collections.Generic;

namespace  kayy.Data.Interfaces
{
    public interface IGet<T,TKey> where T : class
    {
        T Get(TKey id) ;
    }
}
