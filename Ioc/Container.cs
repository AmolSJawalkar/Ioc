using System;
using System.Collections.Generic;
using System.Linq;

namespace Ioc
{
    public class Container
    {
        private Dictionary<Type, Type> _types = new Dictionary<Type, Type>();

        public void Register<IInterface, IImplementation>() where IImplementation : IInterface
        {
            _types[typeof(IInterface)] = typeof(IImplementation);
        }

        public TInterface Resolve<TInterface>()
        {
            return (TInterface)Create(typeof(TInterface));
        }

        private object Create(Type type)
        {
            var typeInfo = _types[type];

            var firstConstructor = typeInfo.GetConstructors()[0];

            var parametersInfo = firstConstructor.GetParameters();

            var parameters = parametersInfo.Select(p => Create(p.ParameterType)).ToArray();

            return firstConstructor.Invoke(parameters);
        }
    }
}
