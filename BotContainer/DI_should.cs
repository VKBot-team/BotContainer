using Ninject;
using NUnit.Framework;
using VKApiCore;

namespace BotContainer
{
    [TestFixture]
    class DI_should
    {
        private static readonly DI DI = new DI();

        [Test]
        public void TestGetVkService()
        { 
            var instance1 = DI.Get<VkService>();
            var instance2 = DI.Get<VkService>();

            Assert.AreNotEqual(null, instance1);
            Assert.AreEqual(typeof(VkService), instance1.GetType());
            Assert.AreSame(instance1, instance2);
        }
    }
}