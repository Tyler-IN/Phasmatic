using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Players
{
    public class DeadPlayerSpawnBody : RpcValidator<DeadPlayer>
    {
        public override string Name => "SpawnBody";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            int modelId = execution.GetArgument<int>(0);

            return true;
        }
    }
}
