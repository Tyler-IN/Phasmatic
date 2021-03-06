﻿namespace Phasmatic.RpcValidation.Items
{
    public class CandleNetworkedUse : RpcValidator<Candle>
    {
        public override string Name => "NetworkedUse";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            bool isOn = ctx.GetArgument<bool>(0);

            return true;
        }
    }
}
