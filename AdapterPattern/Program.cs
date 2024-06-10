using AdapterPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        ITurkey turkey = new WildTurkey();
        IDuck duck = new TurkeyAdapter(turkey);

        Test(duck);
    }

    private static void Test(IDuck duck)
    {
        duck.Fly();
        duck.Quack();
    }
}