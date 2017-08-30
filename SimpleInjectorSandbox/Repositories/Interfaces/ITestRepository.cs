using System.Collections.Generic;
using SimpleInjectorSandbox.Models;

namespace SimpleInjectorSandbox.Repositories.Interfaces
{
    public interface ITestRepository
    {
        List<TestModel> GetAll();
    }
}