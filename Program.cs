using System;

namespace FrontierInc
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new FrontierInc())
                game.Run();
        }
    }
}
