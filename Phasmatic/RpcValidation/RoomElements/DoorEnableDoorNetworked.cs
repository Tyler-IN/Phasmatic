using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorEnableDoorNetworked : RpcValidator<Door>
    {
        public override string Name => "EnableDoorNetworked";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            return true;
        }
    }
}
