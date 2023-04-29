using Castle.DynamicProxy;
using System.Reflection;

namespace EReconciliationAPI.Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            List<MethodInterceptionBaseAttribute> classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>(true).ToList();
            List<MethodInterceptionBaseAttribute> methodAttributes = type.GetMethod(method.Name).GetCustomAttributes<MethodInterceptionBaseAttribute>(true).ToList();
            classAttributes.AddRange(methodAttributes);

            return classAttributes.OrderBy(m => m.Priority).ToArray();
        }
    }
}
