using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Effects
{
    public class FootstepSpawn : RpcValidator<Footstep>
    {
        public override string Name => "Spawn";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            bool isRight = ctx.GetArgument<bool>(0);

            return true;
        }
    }
}
