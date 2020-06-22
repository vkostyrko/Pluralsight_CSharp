using System;

namespace WorkingWithNUlls
{
    class Program
    {
        static void Main(string[] args)
        {
            var sarah = new Player(new IronBondesDefence()) { Name = "Sarah" };
            var emit = new Player(new DiamondSkinDefence()) { Name = "Emit" };
            var gendry = new Player(SpecialDefence.Null) { Name = "Gendry" };

            sarah.Hit(10);
            emit.Hit(10);
            gendry.Hit(10);

            //var player = new Player() {LastLogin =42 };
            //int dayes = player.LastLogin.GetValueOrDefault(-1);
            //Console.WriteLine(dayes);

            //int? i = null; InvalidOperation Exception
            //int j = (int)i;


            Console.ReadKey();
        }
    }
}
