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

        protected abstract bool ValidateInternal(RpcExecution rpcExecution);

        public virtual bool Validate(RpcExecution rpcExecution)
        {
            rpcExecution.Validator = this;
            bool isValid = ValidateInternal(rpcExecution);
            rpcExecution.IsValid = isValid;
            InstanceTracker.Current.AddExecution(rpcExecution);
            return isValid;
        }
    }

}