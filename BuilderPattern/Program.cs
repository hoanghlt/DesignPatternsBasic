using BuilderPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        IBuilder builder = new MyHamburgerBuilder();
        Cook cook = new Cook(builder);
        Hamburger myHamburger = cook.Build();

        cook.ChangeBuilder(new WifeHamburgerBuilder());
        Hamburger wifeHamburger = cook.Build();

        cook.ChangeBuilder(new SonHamburgerBuilder());
        Hamburger sonHamburger = cook.Build();

        Console.WriteLine($"My Hamburger: {myHamburger}");
        Console.WriteLine($"My Wife Hamburger: {wifeHamburger}");
        Console.WriteLine($"My Son Hamburger: {sonHamburger}");
    }
}