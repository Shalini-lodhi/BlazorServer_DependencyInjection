namespace DependencyInjection.Logic
{
    public class SomeOtherLogicClass : ILogicClass
    {
        public int Value1 { get; private set; }
        public int Value2 { get; private set; }
        public SomeOtherLogicClass()
        {
            Value1 = 235;
            Value2 = 4316;
        }
    }
}
