using System.ComponentModel.Design;
using API;
using Ninject;
using VKApiCore;
using GIFService;

namespace BotContainer
{
    public class DI
    {
        private readonly IKernel _container;

        public DI()
        {
            _container = new StandardKernel();

            _container.Bind<VkService>().ToSelf().InSingletonScope();
            _container.Bind<GifService>().ToSelf().InSingletonScope();
            _container.Bind<BotAPI>().ToSelf().InSingletonScope();
        }

        public TService Get<TService>()
        {
            return _container.Get<TService>();
        }
    }
}
