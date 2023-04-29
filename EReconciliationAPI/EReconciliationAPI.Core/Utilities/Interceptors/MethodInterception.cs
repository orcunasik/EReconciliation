using Castle.DynamicProxy;

namespace EReconciliationAPI.Core.Utilities.Interceptors
{
    public class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation)
        {

        }
        protected virtual void OnAfter(IInvocation invocation)
        {

        }
        protected virtual void OnException(IInvocation invocation, Exception e)
        {

        }
        protected virtual void OnSuccess(IInvocation invocation)
        {

        }
        public override void Intercept(IInvocation invocation)
        {
            bool isSuccess = true;
            OnBefore(invocation);

            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {

                isSuccess = false;
                OnException(invocation, e);
            }
            finally
            {
                if (isSuccess)
                    OnSuccess(invocation);
            }

            OnAfter(invocation);
        }
    }
}
