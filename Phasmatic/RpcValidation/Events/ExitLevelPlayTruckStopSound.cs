using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Events
{
    public class ExitLevelPlayTruckStopSound : RpcValidator<ExitLevel>
    {
        public override string Name => "PlayTruckStopSound";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
