using System.Collections.Generic;
using SimpleInjectorSandbox.Repositories.Interfaces;

namespace SimpleInjectorSandbox.Repositories
{
    public class AuditRepository<TModel> : IAuditRepository<TModel> where TModel : new()
    {
        private readonly List<TModel> _models;

        public AuditRepository()
        {
            _models = new List<TModel>();
        }

        public List<TModel> Load()
        {
            _models.Add(new TModel());
            _models.Add(new TModel());
            return _models;
        }
    }
}