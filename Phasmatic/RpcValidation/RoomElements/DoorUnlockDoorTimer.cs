using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorUnlockDoorTimer : RpcValidator<Door>
    {
        public override string Name => "UnlockDoorTimer";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            float timer = execution.GetArgument<float>(0);

            return true;
        }
    }
}
