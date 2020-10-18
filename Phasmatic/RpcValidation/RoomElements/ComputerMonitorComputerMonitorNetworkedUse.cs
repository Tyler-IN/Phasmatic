using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.RoomElements
{
    public class ComputerMonitorComputerMonitorNetworkedUse : RpcValidator<ComputerMonitor>
    {
        public override string Name => "ComputerMonitorNetworkedUse";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
