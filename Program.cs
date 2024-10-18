using DiscordRPC;
using DiscordRPC.Logging;

namespace TestingWinForms
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            DiscordRpcController rpcController = new DiscordRpcController();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}