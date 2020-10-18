﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Interactables
{
    public class CarTurnAlarmOff : RpcValidator<Car>
    {
        public override string Name => "TurnAlarmOff";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
