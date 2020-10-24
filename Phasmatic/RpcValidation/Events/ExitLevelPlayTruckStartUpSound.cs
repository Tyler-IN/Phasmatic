using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Events
{
    public class ExitLevelPlayTruckStartUpSound : RpcValidator<ExitLevel>
    {
        public override string Name => "PlayTruckStartUpSound";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
