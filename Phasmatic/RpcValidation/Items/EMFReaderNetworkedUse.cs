﻿namespace Phasmatic.RpcValidation.Items
{
    public class EMFReaderNetworkedUse : RpcValidator<EMFReader>
    {
        public override string Name => "NetworkedUse";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            int actorId = ctx.GetArgument<int>(0);

            return true;
        }
    }
}
