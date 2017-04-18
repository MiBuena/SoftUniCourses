using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Parameters;

namespace _02.ReflectionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();

            kernel.Bind<ILiquid>().To<Water>().WithConstructorArgument("a", 2);

            var dog = kernel.Get<Dog>();


        }
    }
}
