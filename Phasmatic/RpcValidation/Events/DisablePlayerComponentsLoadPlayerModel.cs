﻿namespace Phasmatic.RpcValidation.Events
{
    public class DisablePlayerComponentsLoadPlayerModel : RpcValidator<DisablePlayerComponents>
    {
        public override string Name => "LoadPlayerModel";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            int index = ctx.GetArgument<int>(0);

            return true;
        }
    }
}
