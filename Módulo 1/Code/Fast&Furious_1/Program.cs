using CommandDotNet;

namespace FastFurious
{
    class Program
    {
        static int Main(string[] args)
        {
            AppRunner<FastNFuriousProgram> appRunner = new AppRunner<FastNFuriousProgram>();
            return appRunner.Run(args);
        }
    }
}
