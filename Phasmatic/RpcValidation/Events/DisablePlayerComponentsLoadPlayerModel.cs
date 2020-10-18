using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Events
{
    public class DisablePlayerComponentsLoadPlayerModel : RpcValidator<DisablePlayerComponents>
    {
        public override string Name => "LoadPlayerModel";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            int index = execution.GetArgument<int>(0);

            return true;
        }
    }
}
