namespace DependencyInjection.FactorySample;

public interface ISample2
{
    int RandomNumber { get; set; }
}

public class Sample2 : ISample2
{
    public int RandomNumber { get; set; }
    public Sample2()
    {
        RandomNumber = Random.Shared.Next(1, 1001);

    }
}
