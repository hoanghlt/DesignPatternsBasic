using BridgePattern;

internal class Program
{
    private static void Main(string[] args)
    {
        IWeapon sword = new Sword(new FlyingEnchantment());
        sword.Weild();
        sword.Swing();
        sword.UnWeild();

        IWeapon hammer = new Hammer(new SoulEatingEnchantment());
        hammer.Weild();
        hammer.Swing();
        hammer.UnWeild();

        IWeapon swordNew = new Sword(new SoulEatingEnchantment());
        swordNew.Weild();
        swordNew.Swing();
        swordNew.UnWeild();

        IWeapon hammerNew = new Hammer(new FlyingEnchantment());
        hammerNew.Weild();
        hammerNew.Swing();
        hammerNew.UnWeild();
    }
}