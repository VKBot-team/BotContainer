using API;
using Ninject;
using VKApiCore;
using GIFService;

namespace BotContainer
{
    public class DI
    {
        public IKernel Container { get; }

        public DI()
        {
            Container = new StandardKernel();

            Container.Bind<VkService>().ToSelf().InSingletonScope();
            Container.Bind<GifService>().ToSelf().InSingletonScope();
            Container.Bind<BotAPI>().ToSelf().InSingletonScope();
        }
    }
}
