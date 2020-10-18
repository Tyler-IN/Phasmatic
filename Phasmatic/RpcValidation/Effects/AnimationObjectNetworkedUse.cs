﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Effects
{
    public class AnimationObjectNetworkedUse : RpcValidator<AnimationObject>
    {
        public override string Name => "NetworkedUse";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            return true;
        }
    }
}
