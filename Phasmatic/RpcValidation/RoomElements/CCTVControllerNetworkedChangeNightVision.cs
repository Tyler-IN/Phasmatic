using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.RoomElements
{
    public class CCTVControllerNetworkedChangeNightVision : RpcValidator<CCTVController>
    {
        public override string Name => "NetworkedChangeNightVision";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            bool on = execution.GetArgument<bool>(0);

            return true;
        }
    }
}
