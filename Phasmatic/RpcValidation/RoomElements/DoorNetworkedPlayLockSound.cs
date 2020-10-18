using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorNetworkedPlayLockSound : RpcValidator<Door>
    {
        public override string Name => "NetworkedPlayLockSound";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            return true;
        }
    }
}
