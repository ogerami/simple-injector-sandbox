using System.Collections.Generic;
using SimpleInjectorSandbox.Models;
using SimpleInjectorSandbox.Repositories.Interfaces;

namespace SimpleInjectorSandbox.Repositories
{
    public class TestRepository : ITestRepository
    {
        public List<TestModel> GetAll()
        {
            return new List<TestModel>
            {
                new TestModel("Test1", "Test1"),
                new TestModel("Test2", "Test2")
            };
        }
    }
}