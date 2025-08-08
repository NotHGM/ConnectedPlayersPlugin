using Microsoft.Extensions.DependencyInjection;
using SharedLibraryCore;
using SharedLibraryCore.Helpers;
using SharedLibraryCore.Interfaces;
using SharedLibraryCore.Interfaces.Events;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConnectedPlayers
{
    public class Plugin : IPluginV2
    {
        public const string PluginName = "ConnectedPlayers";
        public string Name => PluginName;
        public string Version => "2025-04-10";
        public string Author => "HGM";

        public static void RegisterDependencies(IServiceCollection services) { }

        public Plugin()
        {
            IManagementEventSubscriptions.Load += OnLoad;
        }

        private Task OnLoad(IManager manager, CancellationToken token)
        {
            Console.WriteLine($"[{Name}] by {Author} loaded. Version: {Version}");

            manager.GetMessageTokens().Add(
                new MessageToken("CONNECTED", (s) =>
                    Task.FromResult(manager.GetActiveClients().Count.ToString())
                )
            );

            return Task.CompletedTask;
        }
    }
}
