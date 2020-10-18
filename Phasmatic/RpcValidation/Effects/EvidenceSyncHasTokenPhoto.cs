using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Effects
{
    public class EvidenceSyncHasTokenPhoto : RpcValidator<Evidence>
    {
        public override string Name => "SyncHasTakenPhoto";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            return true;
        }
    }
}
