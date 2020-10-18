using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Items
{
    public class CCTVOnGrabbedSync : RpcValidator<CCTV>
    {
        public override string Name => "OnGrabbedSync";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            return true;
        }
    }
}
