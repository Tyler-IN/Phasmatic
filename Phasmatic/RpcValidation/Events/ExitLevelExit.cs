using Phasmatic.TrackingSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Events
{
    public class ExitLevelExit : RpcValidator<ExitLevel>
    {
        public override string Name => throw new NotImplementedException();

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
//TODO: Validate this should happen.
            InstanceTracker.NewInstance();

            return true;
        }
    }
}
