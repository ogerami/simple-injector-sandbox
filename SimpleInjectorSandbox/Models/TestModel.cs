namespace SimpleInjectorSandbox.Models
{
    public class TestModel
    {
        public TestModel()
        {
            Test1 = "AuditTest";
            Test2 = "AuditTest";
        }

        public TestModel(string test1, 
            string test2)
        {
            Test1 = test1;
            Test2 = test2;
        }

        public string Test1 { get; }
        public string Test2 { get; }
    }
}