using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Effects
{
    public class FootstepControllerNetworkedPlaySound : RpcValidator<FootstepControllerNetworkedPlaySound>
    {
        public override string Name => "NetworkedPlaySound";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            int id = ctx.GetArgument<int>(0);
            int actorID = ctx.GetArgument<int>(1);

            return true;
        }
    }
}
