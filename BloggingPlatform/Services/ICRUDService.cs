using System;

namespace BloggingPlatform.Services
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IService<T, TSearch>
    {
        T Insert(TInsert request);
        T Update(int id, TUpdate request);
        T Delete(int id);
    }
}