using Ninject;
using NUnit.Framework;
using VKApiCore;

namespace BotContainer
{
    [TestFixture]
    class DI_should
    {
        private static readonly IKernel Container = DI.container;

        [Test]
        public void TestContainer()
        {
            var instance1 = Container.Get<IVkService>();
            var instance2 = Container.Get<IVkService>();
            Assert.AreNotEqual(null, instance1);
            Assert.AreEqual(typeof(VkService), instance1);
            Assert.AreEqual(instance1, instance2);
        }
    }
}