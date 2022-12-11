using System;

namespace BloggingPlatform.Services
{
    public interface IService<T, TSearch>
    {
        List<T> Get(TSearch search);

        T GetById(int id);
    }
}