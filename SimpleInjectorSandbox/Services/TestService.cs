using System.Collections.Generic;
using SimpleInjectorSandbox.Models;
using SimpleInjectorSandbox.Repositories.Interfaces;

namespace SimpleInjectorSandbox.Services
{
    public class TestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public List<TestModel> GetAll()
        {
            return _testRepository.GetAll();
        }
    }
}