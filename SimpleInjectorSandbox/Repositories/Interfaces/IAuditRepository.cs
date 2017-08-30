using System.Collections.Generic;

namespace SimpleInjectorSandbox.Repositories.Interfaces
{
    public interface IAuditRepository<TModel> where TModel : new()
    {
        List<TModel> Load();
    }
}