using System;
using Ninject;
using Ninject.Extensions.Conventions;
using VKApiCore;

namespace BotContainer
{
    public class DI
    {
        public static IKernel container { get; }

        static DI()
        {
            container = new StandardKernel();

            container.Bind(syntax => syntax
                .FromThisAssembly()
                .SelectAllClasses()
                .BindAllInterfaces()
                .Configure(onSyntax => onSyntax.InSingletonScope())
            );
        }
    }
}
