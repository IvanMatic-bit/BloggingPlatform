using BloggingPlatform.Services;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
    {
        private readonly ICRUDService<T, TSearch, TInsert, TUpdate> _service = null;

        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public virtual T Insert(TInsert request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public virtual T Update(int id, [FromBody] TUpdate request)
        {
            return _service.Update(id, request);
        }
        [HttpDelete("{id}")]
        public virtual T Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}