using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorNetworkedSpawnHandPrintEvidence : RpcValidator<Door>
    {
        public override string Name => "NetworkedSpawnHandPrintEvidence";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            return true;
        }
    }
}
