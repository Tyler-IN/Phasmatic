using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Interactables
{
    public class CarTurnAlarmOn : RpcValidator<Car>
    {
        public override string Name => "TurnAlarmOn";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            return true;
        }
    }
}
