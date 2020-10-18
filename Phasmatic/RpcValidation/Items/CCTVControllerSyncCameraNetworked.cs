using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Items
{
    public class CCTVControllerSyncCameraNetworked : RpcValidator<CCTVController>
    {
        public override string Name => "SyncCameraNetworked";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            int newIndex = execution.GetArgument<int>(0);

            return true;
        }
    }
}
