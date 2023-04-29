using Castle.DynamicProxy;
using EReconciliationAPI.Core.CrossCuttingConcerns.Validation;
using EReconciliationAPI.Core.Utilities.Interceptors;
using FluentValidation;

namespace EReconciliationAPI.Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;

        public ValidationAspect(Type validatorType)
        {
            if(!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Hatalı Tip");
            }
            _validatorType = validatorType;
        }

        protected override void OnBefore(IInvocation invocation)
        {
            IValidator validator = (IValidator)Activator.CreateInstance(_validatorType);
            Type entityType = _validatorType.BaseType.GetGenericArguments()[0];
            IEnumerable<object> entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
