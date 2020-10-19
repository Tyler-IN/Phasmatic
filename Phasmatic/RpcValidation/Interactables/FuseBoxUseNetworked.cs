using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Interactables
{
    public class FuseBoxUseNetworked : RpcValidator<FuseBox>
    {
        public override string Name => "UseNetworked";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            bool isGhostUsing = ctx.GetArgument<bool>(0);

            return true;
        }
    }
}
