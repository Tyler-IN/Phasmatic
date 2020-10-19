using Phasmatic.TrackingSystems;
using System;

namespace Phasmatic.RpcValidation
{
    public abstract class RpcValidator<T> : RpcValidator
    {
        public override Type View => typeof(T);
    }


    public abstract class RpcValidator
    {

        public abstract System.Type View { get; }

        public abstract string Name { get; }

        protected abstract bool ValidateInternal(ref RpcExecutionContext ctx);

        // TODO: make virtual if ever direct overload necessary
        public bool Validate(ref RpcExecutionContext ctx)
        {
            ctx.Validator = this;
            bool isValid = ValidateInternal(ref ctx);
            ctx.IsValid = isValid;
            InstanceTracker.Current.AddExecution(ctx);
            return isValid;
        }
    }

}