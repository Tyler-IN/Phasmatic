using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Players
{
    public class DeadPlayerPlaySound : RpcValidator<DeadPlayer>
    {
        public override string Name => "PlaySound";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            int actorId = execution.GetArgument<int>(0);

            return true;
        }
    }
}
