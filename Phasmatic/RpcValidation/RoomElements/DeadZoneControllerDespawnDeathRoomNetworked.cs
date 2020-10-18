using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.RoomElements
{
    public class DeadZoneControllerDespawnDeathRoomNetworked : RpcValidator<DeadZoneController>
    {
        public override string Name => "DespawnDeathRoomNetworked";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            return true;
        }
    }
}
